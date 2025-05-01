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
    public partial class TripDashboard : Form
    {
        string Database_Connection = "Data Source=DESKTOP-PIBRB9H\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";

        public TripDashboard()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadTrips();
        }
        private void LoadTrips()
        {
            using (SqlConnection conn = new SqlConnection(Database_Connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Trip WHERE StartDate > GETDATE()"; // Use WHERE instead of HAVING
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTrips.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trips: " + ex.Message);
                }
            }
        }


        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDigitalPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalTravelPass digitalTravelPassForm = new DigitalTravelPass();
            digitalTravelPassForm.Show();
        }

        private void btnReviewsRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewAndRatingForm reviewAndRatingForm = new ReviewAndRatingForm();
            reviewAndRatingForm.Show();
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Management profileManagementForm = new Profile_Management();
            profileManagementForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchnBooking searchBookingForm = new SearchnBooking();
            searchBookingForm.Show();
        }
    }
}
