using @new;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Db_project
{
    public partial class AddListing : Form
    {
        public AddListing()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            //Insert the data to the database
            string title = txtTitle.Text;
            string price = txtPrice.Text;
            string description = txtDescription.Text;
            string query = "INSERT INTO Listing ([ProviderID],[Listing Name],[Listing Price],[Listing Description]) VALUES (@pid,@title, @price, @description)";
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pid", Globals.LoggedInUserID);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);

                    connection.Open();
                    int row = command.ExecuteNonQuery();
                    if (row > 0) {
                        //Print success
                        MessageBox.Show("Listing added successfully.");
                    }
                    else
                    {
                        //Print failure
                        MessageBox.Show("Failed to add listing.");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }
    }
}
