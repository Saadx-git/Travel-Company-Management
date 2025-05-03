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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAs signUpForm = new SignUpAs();
            signUpForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserID, UserType FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string userType = reader["UserType"].ToString();
                        int userId = Convert.ToInt32(reader["UserID"]);

                        Globals.LoggedInUserID = userId;
                        Globals.UserType = userType;

                        reader.Close(); // CLOSE FIRST READER BEFORE RE-USING CONNECTION

                        if (userType == "Traveller")
                        {
                            string qu = "Select * from Traveller where TravellerID = @id";
                            SqlCommand cmd1 = new SqlCommand(qu, conn);
                            cmd1.Parameters.AddWithValue("@id", userId);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader1.Read())
                            {
                                string approvedBy = reader1["ApprovedBy"]?.ToString();
                                reader1.Close();

                                if (string.IsNullOrEmpty(approvedBy))
                                {
                                    MessageBox.Show("Your account is not approved yet.");
                                    return;
                                }
                            }

                            this.Hide();
                            TripDashboard tripDashboardForm = new TripDashboard();
                            tripDashboardForm.Show();
                        }
                        else if (userType == "Admin")
                        {
                            this.Hide();
                            AdminInterface adminInterface = new AdminInterface();
                            adminInterface.Show();
                        }
                        else if (userType == "Service Provider")
                        {
                            string qu = "Select * from ServiceProvider where ProviderID = @id";
                            SqlCommand cmd1 = new SqlCommand(qu, conn);
                            cmd1.Parameters.AddWithValue("@id", userId);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader1.Read())
                            {
                                string approvedBy = reader1["ManagedBy"]?.ToString();
                                reader1.Close();

                                if (string.IsNullOrEmpty(approvedBy))
                                {
                                    MessageBox.Show("Your account is not approved yet.");
                                    return;
                                }
                            }

                            this.Hide();
                            Service_Listing serviceIntegration = new Service_Listing();
                            serviceIntegration.Show();
                        }
                        else if (userType == "Tour Operator")
                        {
                            string qu = "Select * from TourOperator where OperatorID = @id";
                            SqlCommand cmd1 = new SqlCommand(qu, conn);
                            cmd1.Parameters.AddWithValue("@id", userId);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader1.Read())
                            {
                                string approvedBy = reader1["ManagedBy"]?.ToString();
                                reader1.Close();

                                if (string.IsNullOrEmpty(approvedBy))
                                {
                                    MessageBox.Show("Your account is not approved yet.");
                                    return;
                                }
                            }

                            this.Hide();
                            CreateTrip createTrip = new CreateTrip();
                            createTrip.Show();
                        }
                        else
                        {
                            MessageBox.Show("Access denied");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

