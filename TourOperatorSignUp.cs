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
    public partial class TourOperatorSignUp : Form
    {
        public TourOperatorSignUp()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void lblLicenseNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtCompanyAddress.Text.Trim(); // Assuming personal address is same as company for this form
            string userType = "Tour Operator";

            string companyName = txtCompanyName.Text.Trim();
            string companyAddress = txtCompanyAddress.Text.Trim();
            string licenseNumber = txtLicenseNumber.Text.Trim();

            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1: Insert into Users and get the generated UserID
                    string userInsertQuery = @"
                INSERT INTO Users (Name, Gender, Email, Password, Phone, Address, UserType)
                OUTPUT INSERTED.UserID
                VALUES (@Name, @Gender, @Email, @Password, @Phone, @Address, @UserType)";

                    SqlCommand cmdUser = new SqlCommand(userInsertQuery, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@Name", name);
                    cmdUser.Parameters.AddWithValue("@Gender", gender);
                    cmdUser.Parameters.AddWithValue("@Email", email);
                    cmdUser.Parameters.AddWithValue("@Password", password);
                    cmdUser.Parameters.AddWithValue("@Phone", phone);
                    cmdUser.Parameters.AddWithValue("@Address", address);
                    cmdUser.Parameters.AddWithValue("@UserType", userType);

                    int userID = (int)cmdUser.ExecuteScalar();

                    // Step 2: Insert into TourOperator
                    string operatorInsertQuery = @"
                INSERT INTO TourOperator (OperatorID, CompanyName, CompanyAddress, LicenseNumber, ManagedBy)
                VALUES (@OperatorID, @CompanyName, @CompanyAddress, @LicenseNumber, NULL)";

                    SqlCommand cmdOperator = new SqlCommand(operatorInsertQuery, conn, transaction);
                    cmdOperator.Parameters.AddWithValue("@OperatorID", userID);
                    cmdOperator.Parameters.AddWithValue("@CompanyName", companyName);
                    cmdOperator.Parameters.AddWithValue("@CompanyAddress", companyAddress);
                    cmdOperator.Parameters.AddWithValue("@LicenseNumber", licenseNumber);

                    cmdOperator.ExecuteNonQuery();

                    // Commit if all successful
                    transaction.Commit();
                    MessageBox.Show("Tour Operator registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
