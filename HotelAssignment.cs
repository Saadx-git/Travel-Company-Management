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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Db_project
{
    public partial class HotelAssignment : Form
    {
        public HotelAssignment()
        {
            InitializeComponent();
            Load_Hotels();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void HotelAssignment_Load(object sender, EventArgs e)
        {

        }
        private void Load_Hotels() { 
            string query = "SELECT * FROM Listing";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString)) {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTrip login = new CreateTrip();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a hotel to assign.");
                return;
            }


            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            int listingID = Convert.ToInt32(selectedRow.Cells["ListingID"].Value);
            int tourOperatorID = Globals.LoggedInUserID;
            string status = "Assigned";
            string query = "INSERT INTO ServiceAssignment (Status, TourOperatorID,ListingID,TripID) VALUES (@status, @tourOperatorID, @listingID,@TripID)";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@tourOperatorID", tourOperatorID);
                cmd.Parameters.AddWithValue("@listingID", listingID);
                cmd.Parameters.AddWithValue("@TripID", Globals.temporaryint);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Hotel Assigned Successfully");
                }
                else
                {
                    MessageBox.Show("Error assigning hotel");
                }
            }
            //Refresh the datagridview
            Load_Hotels();  


        }
    }
}
