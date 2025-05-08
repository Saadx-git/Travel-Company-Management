using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Db_project;

namespace @new
{
    public partial class BookingManagement : Form
    {
        public BookingManagement()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            // after InitializeComponent, load your grid
            loadBookedListings();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            // if you prefer to load on the form‐load event:
            // loadBookedListings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }

        private void loadBookedListings()
        {
            // show only those listings for this provider which have been booked
            var query = @"
                SELECT 
                    b.BookingID,
                    sa.ListingID,
                    l.[Listing Name],
                    b.TripID,
                    b.TravellerID,
                    b.[Date]      AS BookingDate,
                    b.Status      AS BookingStatus,
                    b.Amount      AS BookingAmount
                FROM Booking b
                INNER JOIN ServiceAssignment sa 
                    ON b.TripID = sa.TripID
                INNER JOIN Listing l 
                    ON sa.ListingID = l.ListingID
                WHERE l.ProviderID = @providerID;";

            using (var conn = new SqlConnection(Globals.connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@providerID", Globals.LoggedInUserID);
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
        }
    }
}
