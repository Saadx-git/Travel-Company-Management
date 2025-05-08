using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Db_project;
using Globals = Db_project.Globals;

namespace @new
{
    public partial class Form6 : Form
    {
        private int _listingId;  // Property to hold the Listing ID

        public Form6(int listingId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _listingId = listingId;  
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loadPerformanceData(_listingId);
        }

        private void loadPerformanceData(int listingId)
        {
            string query = @"
                -- Get the number of completed bookings for the given listing
                SELECT COUNT(*) AS CompletedBookings 
                FROM Booking 
                WHERE TripID IN (SELECT TripID FROM ServiceAssignment WHERE ListingID = @ListingID) 
                AND Status = 'Completed';

                -- Get the number of abandoned bookings for the given listing
                SELECT COUNT(*) AS AbandonedBookings
                FROM AbandonedBooking 
                WHERE BookingID IN (SELECT BookingID FROM Booking WHERE TripID IN (SELECT TripID FROM ServiceAssignment WHERE ListingID = @ListingID));

                -- Get the total refund amount for the given listing
                SELECT SUM(Amount) AS TotalRefunds
                FROM Refund 
                WHERE BookingID IN (SELECT BookingID FROM Booking WHERE TripID IN (SELECT TripID FROM ServiceAssignment WHERE ListingID = @ListingID))
                AND Status = 'Completed';
            ";

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ListingID", listingId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int completedBookings = 0;
                int abandonedBookings = 0;
                decimal totalRefunds = 0;

                if (reader.Read())
                {
                    completedBookings = reader.GetInt32(0);
                }
                if (reader.Read())
                {
                    abandonedBookings = reader.GetInt32(0);
                }
                if (reader.Read())
                {
                    totalRefunds = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                }

                reader.Close();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Metric");
                dataTable.Columns.Add("Value");

                dataTable.Rows.Add("Completed Bookings", completedBookings);
                dataTable.Rows.Add("Abandoned Bookings", abandonedBookings);
                dataTable.Rows.Add("Total Refunds", totalRefunds.ToString("C"));

                dataGridViewPerformance.DataSource = dataTable;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }
    }
}
