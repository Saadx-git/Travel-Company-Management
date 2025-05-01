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
        string Database_Connection = "Data Source=DESKTOP-PIBRB9H\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
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
            string maxBudget = txtPriceRange.Text.Trim();
            string activity = cmbActivityType.SelectedItem?.ToString();
            string groupSize = txtGroupSize.Text.Trim();

            string query = "SELECT * FROM Trip WHERE 1=1";
            if (!string.IsNullOrEmpty(destination))
                query += " AND Destination LIKE @Destination";
            if (!string.IsNullOrEmpty(maxBudget))
                query += " AND Price <= @MaxBudget";
            if (!string.IsNullOrEmpty(activity))
                query += " AND ActivityType = @Activity";
            if (!string.IsNullOrEmpty(groupSize))
                query += " AND GroupSize >= @GroupSize";
            query += " AND TripDate = @Date";

            using (SqlConnection con = new SqlConnection(Database_Connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(destination))
                        cmd.Parameters.AddWithValue("@Destination", "%" + destination + "%");
                    if (!string.IsNullOrEmpty(maxBudget))
                        cmd.Parameters.AddWithValue("@MaxBudget", Convert.ToDecimal(maxBudget));
                    if (!string.IsNullOrEmpty(activity))
                        cmd.Parameters.AddWithValue("@Activity", activity);
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
            using (SqlConnection conn = new SqlConnection(Database_Connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Trip WHERE StartDate > GETDATE()"; // Use WHERE instead of HAVING
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
