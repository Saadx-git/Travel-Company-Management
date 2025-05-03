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


//using System.Windows.Forms.DataVisualization.Charting;

namespace Db_project
{
    public partial class PlatformAnalytics : Form
    {
        public PlatformAnalytics()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            btnRefreshAnalytics_Click(null, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface adminInterface = new AdminInterface();
            adminInterface.Show();

        }

        private void btnRefreshAnalytics_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.connectionString))
                {
                    conn.Open();

                    // Total User Traffic
                    SqlCommand cmdUserCount = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserType = 'Traveller';", conn);
                    int totalUsers = (int)cmdUserCount.ExecuteScalar();
                    txtUserTraffic.Text = totalUsers.ToString();

                    // Booking Trends - let's say total number of bookings for now
                    SqlCommand cmdBookings = new SqlCommand("SELECT COUNT(*) FROM Booking;", conn);
                    int totalBookings = (int)cmdBookings.ExecuteScalar();
                    txtBookingTrends.Text = totalBookings.ToString();

                    // Revenue Generated
                    SqlCommand cmdRevenue = new SqlCommand("SELECT SUM(Amount) FROM CompletedPayment WHERE Status = 'Success';", conn);
                    object revenueObj = cmdRevenue.ExecuteScalar();
                    decimal revenue = revenueObj != DBNull.Value ? (decimal)revenueObj : 0;

                    SqlCommand cmdBookingRevenue = new SqlCommand("SELECT SUM(PaidAmount) FROM CompletedBooking;", conn);
                    object BookingRevenueObj = cmdBookingRevenue.ExecuteScalar();
                    decimal bookingrevenue = BookingRevenueObj != DBNull.Value ? (decimal)BookingRevenueObj : 0;
                    int final_revenue = (int)(revenue + bookingrevenue);
                    txtRevenue.Text = "Rs. " + final_revenue.ToString("N2");
                    //txtRevenue.Text = "Rs. " + revenue.ToString("N2") + bookingrevenue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching analytics: " + ex.Message);
            }
        }


    }
}
