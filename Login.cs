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

public static class Globals
{
    public static int LoggedInUserID = -1;
    public static string UserType = "";
}


namespace Db_project
{
    public partial class Login : Form
    {
        String Database_Connection = "Data Source=DESKTOP-PIBRB9H\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
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

        using (SqlConnection conn = new SqlConnection(Database_Connection))
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

                        if (userType == "Traveller")
                        {
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
                            this.Hide();
                            Service_Listing serviceIntegration = new Service_Listing();
                            serviceIntegration.Show();

                        }
                        else if (userType == "Tour Operator")
                        {
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
