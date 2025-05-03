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
using static System.Collections.Specialized.BitVector32;

namespace Db_project
{
    public partial class DigitalTravelPass : Form
    {
        
        public DigitalTravelPass()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadDigitalPasses();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TripDashboard tripDashboardForm = new TripDashboard();
            tripDashboardForm.Show();
        }

        private void LoadDigitalPasses()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                { 
                    conn.Open();
                    string query = @"
                SELECT dp.PassID, dp.PassType, dp.PassDetails, dp.IssueDate, dp.BookingID, b.Amount, b.Date, b.Status
                FROM DigitalPass dp
                JOIN Booking b ON dp.BookingID = b.BookingID
                WHERE b.TravellerID = @TravellerID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TravellerID", Globals.LoggedInUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPasses.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading digital passes: " + ex.Message);
                }
            }
        }
        private void LoadDigitalPassesByType(string passType)
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT dp.PassID, dp.PassType, dp.PassDetails, dp.IssueDate, dp.BookingID, b.Amount, b.Date, b.Status
                FROM DigitalPass dp
                JOIN Booking b ON dp.BookingID = b.BookingID
                WHERE b.TravellerID = @TravellerID AND dp.PassType = @PassType";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TravellerID", Globals.LoggedInUserID);
                    cmd.Parameters.AddWithValue("@PassType", passType);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPasses.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading digital passes: " + ex.Message);
                }
            }
        }

        private void btnActivityPasses_Click(object sender, EventArgs e)
        {
            LoadDigitalPassesByType("Activity Pass");
        }

        private void btnHotelVouchers_Click(object sender, EventArgs e)
        {
            LoadDigitalPassesByType("Hotel Voucher");
        }

        private void btnETickets_Click(object sender, EventArgs e)
        {
            LoadDigitalPassesByType("E-Ticket");
        }

    }
}
