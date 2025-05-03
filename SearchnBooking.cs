using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_project
{
    public partial class SearchnBooking : Form
    {
        public SearchnBooking()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadTrips();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                TripDashboard tripDashboardForm = new TripDashboard();
                tripDashboardForm.Show(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text.Trim();
            string date = dtpDate.Value.Date.ToString("yyyy-MM-dd");
            string groupSize = txtGroupSize.Text.Trim();

            string query = @"
        SELECT Trip.Title, Trip.StartDate, Trip.EndDate, Trip.Duration, Trip.GroupSize,
               Destination.City, Destination.Country, Destination.Region
        FROM Trip
        JOIN Trip_Offers_Destination ON Trip.TripID = Trip_Offers_Destination.TripID
        JOIN Destination ON Trip_Offers_Destination.DestinationID = Destination.DestinationID
        WHERE 1=1";

            if (!string.IsNullOrEmpty(destination))
                query += " AND (Destination.City LIKE @Destination OR Destination.Country LIKE @Destination OR Destination.Region LIKE @Destination)";
            if (!string.IsNullOrEmpty(groupSize))
                query += " AND Trip.GroupSize >= @GroupSize";
            query += " AND Trip.StartDate >= @Date";

            using (SqlConnection con = new SqlConnection(Globals.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(destination))
                        cmd.Parameters.AddWithValue("@Destination", "%" + destination + "%");
                    if (!string.IsNullOrEmpty(groupSize))
                        cmd.Parameters.AddWithValue("@GroupSize", Convert.ToInt32(groupSize));
                    cmd.Parameters.AddWithValue("@Date", date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv1.DataSource = dt;
                }
            }
        }



        private void LoadTrips()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT Trip.Title, Trip.StartDate, Trip.EndDate, Trip.Duration, Trip.GroupSize,
                       Destination.City, Destination.Country, Destination.Region
                FROM Trip
                JOIN Trip_Offers_Destination ON Trip.TripID = Trip_Offers_Destination.TripID
                JOIN Destination ON Trip_Offers_Destination.DestinationID = Destination.DestinationID
                WHERE Trip.StartDate > GETDATE()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }



    }
}
