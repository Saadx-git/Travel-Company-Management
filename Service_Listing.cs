using Db_project;
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

namespace @new
{
    public partial class Service_Listing : Form
{
    public Service_Listing()
    {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            load_listings();
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnServiceConfirmation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Integration serviceIntegration = new Service_Integration();
            serviceIntegration.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 performanceReport = new Form6();
            performanceReport.Show();
        }

        private void btn_BookingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagement bookingManagement = new BookingManagement();
            bookingManagement.Show();
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Management profileManagement = new Profile_Management();
            profileManagement.Show();
        }

        private void load_listings()
        {
            string qu1 = "Select * from Listing where ProviderID = @pid";

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(qu1, conn);
               
                cmd.Parameters.AddWithValue("@pid", Globals.LoggedInUserID);

                conn.Open();

                cmd.ExecuteNonQuery();
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
        }

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddListing addListing = new AddListing();
            addListing.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qu1 = "Delete from Listing where ListingID = @lid";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(qu1, conn);
                cmd.Parameters.AddWithValue("@lid", dataGridView1.CurrentRow.Cells[0].Value);

                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Listing Deleted Successfully");
                load_listings();
                conn.Close();
            }
        }
    }
}
