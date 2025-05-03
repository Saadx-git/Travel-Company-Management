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
    public partial class ReviewAndRatingForm : Form
    {
        public ReviewAndRatingForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            load_reviews();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TripDashboard tripDashboardForm = new TripDashboard();
            tripDashboardForm.Show();
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            string comments = txtComments.Text.Trim();
            int rating = (int)numRating.Value;

            // You must have a selected TripID; assume it's stored somewhere
            string tripID = txtTripID.Text.ToString(); // Replace with actual TripID source

            if (string.IsNullOrWhiteSpace(comments))
            {
                MessageBox.Show("Please enter comments before submitting.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO Review (TravellerID, TripID, Comments, Rating)
                VALUES (@TravellerID, @TripID, @Comments, @Rating)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TravellerID", Globals.LoggedInUserID);
                    cmd.Parameters.AddWithValue("@TripID", tripID);
                    cmd.Parameters.AddWithValue("@Comments", comments);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Review submitted successfully.");
                    else
                        MessageBox.Show("Failed to submit review.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting review: " + ex.Message);
                }
            }
            load_reviews();
        }

        private void load_reviews()
        {
            int userId = Globals.LoggedInUserID; 
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                string query = @"    
                         SELECT T.Title AS TripName, R.Comments, R.Rating
                         FROM Trip T
                         JOIN Review R
                         ON R.TripID = T.TripID
                         WHERE R.TravellerID = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
        }


    }
}
