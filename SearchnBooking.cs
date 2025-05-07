using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Db_project
{
    public partial class SearchnBooking : Form
    {
        public SearchnBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            btnSearch.Click += btnSearch_Click;
            btnBook.Click += btnBook_Click;

            LoadTrips(); // load all trips on form start
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tripDashboardForm = new TripDashboard();
            tripDashboardForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text.Trim();
            DateTime minDate = dtpDate.Value.Date;
            int.TryParse(txtGroupSize.Text.Trim(), out int minGroupSize);
            string audienceType = cmbActivityType.Text.Trim();
            int.TryParse(txtPriceRange.Text.Trim(), out int maxBudget);

            var sb = new StringBuilder();
            sb.Append(@"
                SELECT 
                    t.TripID,
                    t.Title,
                    t.StartDate,
                    t.EndDate,
                    t.Duration,
                    t.GroupSize,
                    t.AudienceType,
                    t.Trip_Price,
                    d.City,
                    d.Country,
                    d.Region
                FROM Trip AS t
                JOIN Trip_Offers_Destination AS tod ON tod.TripID = t.TripID
                JOIN Destination AS d ON d.DestinationID = tod.DestinationID
                WHERE 1 = 1
            ");

            if (!string.IsNullOrEmpty(destination))
                sb.Append(" AND (d.City LIKE @Destination OR d.Country LIKE @Destination OR d.Region LIKE @Destination)\n");

            sb.Append(" AND t.StartDate >= @MinDate\n");

            if (minGroupSize > 0)
                sb.Append(" AND t.GroupSize >= @MinGroupSize\n");

            if (!string.IsNullOrEmpty(audienceType))
                sb.Append(" AND t.AudienceType = @AudienceType\n");

            if (maxBudget > 0)
                sb.Append(" AND t.Trip_Price <= @MaxBudget\n");

            sb.Append(" ORDER BY t.StartDate;");

            using (var con = new SqlConnection(Globals.connectionString))
            using (var cmd = new SqlCommand(sb.ToString(), con))
            {
                if (!string.IsNullOrEmpty(destination))
                    cmd.Parameters.AddWithValue("@Destination", "%" + destination + "%");

                cmd.Parameters.Add("@MinDate", SqlDbType.Date).Value = minDate;

                if (minGroupSize > 0)
                    cmd.Parameters.AddWithValue("@MinGroupSize", minGroupSize);

                if (!string.IsNullOrEmpty(audienceType))
                    cmd.Parameters.AddWithValue("@AudienceType", audienceType);

                if (maxBudget > 0)
                    cmd.Parameters.AddWithValue("@MaxBudget", maxBudget);

                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                dgv1.DataSource = table;
                dgv1.Columns["Trip_Price"].HeaderText = "Price";
                dgv1.Columns["TripID"].Visible = true; // Always show TripID
            }
        }

                if (maxBudget > 0)
                    cmd.Parameters.AddWithValue("@MaxBudget", maxBudget);

                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                dgv1.DataSource = table;
                dgv1.Columns["TripID"].Visible = false;
                dgv1.Columns["Trip_Price"].HeaderText = "Price";
            }
        }

        private void LoadTrips()
        {
            string query = @"
                SELECT 
                    t.TripID,
                    t.Title,
                    t.StartDate,
                    t.EndDate,
                    t.Duration,
                    t.GroupSize,
                    t.Trip_Price,
                    d.City,
                    d.Country,
                    d.Region
                FROM Trip AS t
                JOIN Trip_Offers_Destination AS tod ON tod.TripID = t.TripID
                JOIN Destination AS d ON d.DestinationID = tod.DestinationID
                WHERE t.StartDate > GETDATE()
                ORDER BY t.StartDate;
            ";

            using (var conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    var adapter = new SqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgv1.DataSource = dt;
                    dgv1.Columns["Trip_Price"].HeaderText = "Price";
                    dgv1.Columns["TripID"].Visible = true; // Always show TripID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip to book.");
                return;
            }

            int tripId = (int)dgv1.SelectedRows[0].Cells["TripID"].Value;
            decimal fee = Convert.ToDecimal(dgv1.SelectedRows[0].Cells["Trip_Price"].Value);

            int travellerId = Globals.LoggedInUserID;

            using (var checkCon = new SqlConnection(Globals.connectionString))
            using (var checkCmd = new SqlCommand("SELECT COUNT(1) FROM Traveller WHERE TravellerID = @T", checkCon))
            {
                checkCmd.Parameters.AddWithValue("@T", travellerId);
                checkCon.Open();
                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show($"TravellerID {travellerId} does not exist.");
                    return;
                }
            }

            using (var con = new SqlConnection(Globals.connectionString))
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    var bookingCmd = new SqlCommand(@"
                        INSERT INTO Booking ([Date], Amount, Status, TravellerID, TripID)
                        VALUES (GETDATE(), @Amount, 'Completed', @TravellerID, @TripID);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);", con, tx);
                    bookingCmd.Parameters.AddWithValue("@Amount", fee);
                    bookingCmd.Parameters.AddWithValue("@TravellerID", travellerId);
                    bookingCmd.Parameters.AddWithValue("@TripID", tripId);

                    int bookingId = (int)bookingCmd.ExecuteScalar();

                    var passCmd = new SqlCommand(@"
                        INSERT INTO DigitalPass (PassType, PassDetails, IssueDate, BookingID)
                        VALUES (@PassType, @PassDetails, GETDATE(), @BookingID);", con, tx);
                    passCmd.Parameters.AddWithValue("@PassType", "E-Ticket");
                    passCmd.Parameters.AddWithValue("@PassDetails", $"Booked for Trip #{tripId}");
                    passCmd.Parameters.AddWithValue("@BookingID", bookingId);
                    passCmd.ExecuteNonQuery();

                    tx.Commit();
                }
            }

            MessageBox.Show($"Trip #{tripId} booked under TravellerID {travellerId}.\nDigital pass issued!");
            LoadTrips(); // Refresh available trips
        }
    }
}
