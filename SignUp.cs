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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }


        private void SaveUserDataToDatabase()
        {
            string name = txtName.Text;
            string gender = cmbGender.SelectedItem?.ToString() ?? "Other";
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime dob = dtpDOB.Value;
            string language = txtLanguage.Text;
            string nationality = txtNationality.Text;
            
            try
            {
               using (SqlConnection conn = new SqlConnection(Globals.connectionString))
                {
                    conn.Open();
                     string insertQuery = "INSERT INTO Users (Name, Gender, Email, Password, Phone, Address,UserType) " +
                                         "VALUES (@Name, @Gender, @Email, @Password, @Phone, @Address, @UserType)" +
                                         "SELECT SCOPE_IDENTITY()";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@UserType", "Traveller");
                        object result = cmd.ExecuteScalar();
                        int newUserId = Convert.ToInt32(result);
                        if (newUserId > 0)
                        {
                            MessageBox.Show("Account created successfully and data saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save user data to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        

                        string travellerinsertquery = "Insert into Traveller (TravellerID, DOB, Nationality, PreferredLanguage) " +
                                                       "VALUES (@TravellerID, @DOB, @Nationality, @PreferredLanguage)";
                        using (SqlCommand cmd2 = new SqlCommand(travellerinsertquery, conn)) { 
                            cmd2.Parameters.AddWithValue("@TravellerID", newUserId);
                            cmd2.Parameters.AddWithValue("@DOB", dob);
                            cmd2.Parameters.AddWithValue("@Nationality", nationality);
                            cmd2.Parameters.AddWithValue("@PreferredLanguage", language);
                            int rowsAffected2 = cmd2.ExecuteNonQuery();

                            if (rowsAffected2 > 0) {
                                MessageBox.Show("Traveller data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to save traveller data to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = cmbGender.SelectedItem?.ToString();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime dob = dtpDOB.Value;
            string language = txtLanguage.Text;
            string nationality = txtNationality.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(language) || string.IsNullOrEmpty(nationality))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveUserDataToDatabase();
        }
    }
}
