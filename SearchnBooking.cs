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
            btnBack.Click += btnBack_Click;

            LoadTrips();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TripDashboard().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text.Trim();
            DateTime minDate = dtpDate.Value.Date;
            int minGroupSize = 0; int.TryParse(txtGroupSize.Text, out minGroupSize);
            string audienceType = cmbActivityType.Text.Trim();
            int maxBudget = 0; int.TryParse(txtPriceRange.Text, out maxBudget);

            var sb = new StringBuilder();
            sb.Append(@"
SELECT 
    t.TripID,
    t.Title,
    t.StartDate,
    t.GroupSize,
    t.AudienceType,
    t.Trip_Price AS Price,
    d.City,
    d.Country
FROM Trip AS t
JOIN Trip_Offers_Destination tod ON tod.TripID = t.TripID
JOIN Destination d             ON d.DestinationID = tod.DestinationID
WHERE 1=1
");

            if (!string.IsNullOrEmpty(destination))
                sb.Append("  AND (d.City LIKE @Destination OR d.Country LIKE @Destination OR d.Region LIKE @Destination)\r\n");

            sb.Append("  AND t.StartDate >= @MinDate\r\n");

            if (minGroupSize > 0)
                sb.Append("  AND t.GroupSize >= @MinGroupSize\r\n");

            if (!string.IsNullOrEmpty(audienceType))
                sb.Append("  AND t.AudienceType = @AudienceType\r\n");

            if (maxBudget > 0)
                sb.Append("  AND t.Trip_Price <= @MaxBudget\r\n");

            sb.Append("ORDER BY t.StartDate;");

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
                dgv1.Columns["TripID"].Visible = false;
                dgv1.Columns["Price"].HeaderText = "Price";
            }
        }

        private void LoadTrips()
        {
            const string query = @"
SELECT 
    t.TripID,
    t.Title,
    t.StartDate,
    t.GroupSize,
    t.AudienceType,
    t.Trip_Price AS Price,
    d.City,
    d.Country
FROM Trip AS t
JOIN Trip_Offers_Destination tod ON tod.TripID = t.TripID
JOIN Destination d             ON d.DestinationID = tod.DestinationID
ORDER BY t.StartDate;";

            using (var conn = new SqlConnection(Globals.connectionString))
            using (var adapter = new SqlDataAdapter(query, conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);

                dgv1.DataSource = dt;
                dgv1.Columns["TripID"].Visible = false;
                dgv1.Columns["Price"].HeaderText = "Price";
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
            decimal fee = Convert.ToDecimal(dgv1.SelectedRows[0].Cells["Price"].Value);

            int travellerId = Globals.LoggedInUserID;
            using (var checkCon = new SqlConnection(Globals.connectionString))
            using (var checkCmd = new SqlCommand("SELECT COUNT(1) FROM Traveller WHERE TravellerID=@T", checkCon))
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
                    var bookCmd = new SqlCommand(@"
                INSERT INTO Booking ([Date], Amount, Status, TravellerID, TripID)
                VALUES (GETDATE(), @Amount, 'Completed', @TravellerID, @TripID);
                SELECT CAST(SCOPE_IDENTITY() AS INT);", con, tx);
                    bookCmd.Parameters.AddWithValue("@Amount", fee);
                    bookCmd.Parameters.AddWithValue("@TravellerID", travellerId);
                    bookCmd.Parameters.AddWithValue("@TripID", tripId);

                    int bookingId = (int)bookCmd.ExecuteScalar();

                    Random rand = new Random();
                    string[] passTypes = { "E-Ticket", "Activity Pass", "Hotel Voucher" };
                    string selectedPassType = passTypes[rand.Next(passTypes.Length)];

                    string[] passDetailsOptions =
                    {
                $"Booked for Trip #{tripId}",
                $"Includes accommodation for Trip #{tripId}",
                $"Activity access for Trip #{tripId}"
            };
                    string selectedPassDetails = passDetailsOptions[rand.Next(passDetailsOptions.Length)];

                    var passCmd = new SqlCommand(@"
                INSERT INTO DigitalPass (PassType, PassDetails, IssueDate, BookingID)
                VALUES (@PassType, @PassDetails, GETDATE(), @BookingID);", con, tx);
                    passCmd.Parameters.AddWithValue("@PassType", selectedPassType);
                    passCmd.Parameters.AddWithValue("@PassDetails", selectedPassDetails);
                    passCmd.Parameters.AddWithValue("@BookingID", bookingId);
                    passCmd.ExecuteNonQuery();

                    tx.Commit();
                }
            }

            MessageBox.Show($"Trip #{tripId} booked under TravellerID {travellerId}.\nDigital pass issued!");
            LoadTrips();
        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv1.Rows[e.RowIndex];
            txtSelTitle.Text = row.Cells["Title"].Value.ToString();
            dtpSelStartDate.Value = (DateTime)row.Cells["StartDate"].Value;
            txtSelGroupSize.Text = row.Cells["GroupSize"].Value.ToString();
            cmbSelAudienceType.Text = row.Cells["AudienceType"].Value.ToString();
            txtSelPrice.Text = row.Cells["Price"].Value.ToString();
            txtSelCity.Text = row.Cells["City"].Value.ToString();
            txtSelCountry.Text = row.Cells["Country"].Value.ToString();

            txtTravellerName.Clear();
            dtpTravellerDOB.Value = DateTime.Today;
            txtTravellerNationality.Clear();
            txtTravellerLanguage.Clear();
        }

        private void SearchnBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
