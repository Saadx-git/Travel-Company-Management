using @new;
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
    public partial class Service_Integration : Form
    {
        public Service_Integration()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            load_assignments();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }

        private void BookinMangement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagement bookingManagementForm = new BookingManagement();
            bookingManagementForm.Show();
        }

        private void btnperformance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 performanceManagement = new Form6();
            performanceManagement.Show();
        }

        private void Service_Integration_Load(object sender, EventArgs e)
        {

        }

        private void load_assignments() {
            //Load from service assignment table all the assignments with the listing id matching the listings in the listin table for the loggedin provider id
            // Join the listing table to show the listing name and the service assignment table to show the status
            string query = "SELECT sa.AssignmentID, l.[Listing Name], sa.Status FROM ServiceAssignment sa " +
                           "JOIN Listing l ON sa.ListingID = l.ListingID " +
                           "WHERE l.ProviderID = @providerID";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@providerID", Globals.LoggedInUserID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRequests.DataSource = dt;
            }
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Select the entry from the dgvRequests and assign the status to Completed
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvRequests.SelectedRows[0].Index;
                int assignmentID = (int)dgvRequests.Rows[selectedRowIndex].Cells["AssignmentID"].Value;

                string query = "UPDATE ServiceAssignment SET Status = 'Completed' WHERE AssignmentID = @assignmentID";
                using (SqlConnection conn = new SqlConnection(Globals.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@assignmentID", assignmentID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                load_assignments();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void load_listings()
        {
            // Pull only those listings for this provider that actually have an assignment
            string query = @"
        SELECT 
            l.ListingID,
            l.[Listing Name],
            l.[Listing Description],
            l.[Listing Price],
            sa.Status
        FROM Listing l
        INNER JOIN ServiceAssignment sa 
            ON l.ListingID = sa.ListingID
        WHERE 
            l.ProviderID = @providerID";

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@providerID", Globals.LoggedInUserID);

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                // Assuming you’ve placed a DataGridView on your form called dgvListings
                dgvRequests.DataSource = dt;
                dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select the entry from the dgvRequests and assign the status to Completed
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvRequests.SelectedRows[0].Index;
                int assignmentID = (int)dgvRequests.Rows[selectedRowIndex].Cells["AssignmentID"].Value;

                string query = "UPDATE ServiceAssignment SET Status = 'Rejected' WHERE AssignmentID = @assignmentID";
                using (SqlConnection conn = new SqlConnection(Globals.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@assignmentID", assignmentID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                load_assignments();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
    }
}
