using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Db_project
{
    public partial class Profile_Management : Form
    {
        public Profile_Management()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadUserProfile(); // Call explicitly here only if not using Form.Load event
        }

        string connectionString = "Data Source=DESKTOP-PIBRB9H\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";

        private void LoadUserProfile()
        {
            string query = "SELECT * FROM Users WHERE UserID = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", Globals.LoggedInUserID); // Fixed parameter casing

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUserID.Text = reader.GetInt32(0).ToString();
                        txtName.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        txtGender.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        txtEmail.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        txtPassword.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        txtPhone.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        txtAddress.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);

                        DateTime regDate = reader.GetDateTime(7);
                        txtRegDate.Text = regDate.ToString("yyyy-MM-dd"); 

                        txtUserType.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TripDashboard tripDashboardForm = new TripDashboard();
            tripDashboardForm.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string query = @"
        UPDATE Users
        SET 
            Name = @Name,
            Email = @Email,
            Password = @Password,
            Phone = @Phone,
            Address = @Address
        WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Adding parameters to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@UserID", Globals.LoggedInUserID);
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error: No changes were made");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
    }
}
