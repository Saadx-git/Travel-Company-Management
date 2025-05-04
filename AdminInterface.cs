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
    public partial class AdminInterface : Form
    {
        int showing = 0;
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void lblTripID_Click(object sender, EventArgs e)
        {

        }

        private void load_travellers() {
           using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT TravellerID, DOB, Nationality, PreferredLanguage FROM Traveller WHERE ApprovedBy IS NULL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
            showing = 1;
        }
        private void LoadTourOperators()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT OperatorID, CompanyName, CompanyAddress, LicenseNumber FROM TourOperator WHERE ManagedBy IS NULL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tour operator data: " + ex.Message);
                }
            }

            showing = 2;
        }

        private void LoadServiceProvidersIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ProviderID, ServiceType, Description, Rating FROM ServiceProvider WHERE ManagedBy IS NULL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading service provider data: " + ex.Message);
                }
            }

            showing = 3;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tour_Categories_Management tourCategoriesManagement = new Tour_Categories_Management();
            tourCategoriesManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlatformAnalytics platformAnalytics = new PlatformAnalytics();
            platformAnalytics.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewModeration reviewModeration = new ReviewModeration();
            reviewModeration.Show();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void prfile_mng_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Management profileManagement = new Profile_Management();
            profileManagement.Show();
        }

        private void showtravellers_Click(object sender, EventArgs e)
        {
            load_travellers();
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void showoperators_Click(object sender, EventArgs e)
        {
            LoadTourOperators();
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void showproviders_Click(object sender, EventArgs e)
        {
            LoadServiceProvidersIntoGrid();
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (showing == 1) {
                UpdateTravellerManagedBy();
            }
            else if(showing == 2){
                UpdateTourOperatorManagedBy();
            }
            else if (showing == 3) {
                UpdateManagedBy_Provider();
            }


        }
        private void UpdateTravellerManagedBy()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Traveller SET ApprovedBy = @ManagedByValue WHERE TravellerID = @TravellerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagedByValue", Globals.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@TravellerID",Convert.ToInt32(txtUserID.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Traveller updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching traveller found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating traveller: " + ex.Message);
                }
            }
            showtravellers_Click(null, null);
        }
        private void UpdateTourOperatorManagedBy()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE TourOperator SET ManagedBy = @ManagedByValue WHERE OperatorID = @OperatorID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagedByValue", Globals.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@OperatorID", txtUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tour operator updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching tour operator found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating tour operator: " + ex.Message);
                }
            }
            showoperators_Click(null,null);
        }

        private void UpdateManagedBy_Provider()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE ServiceProvider SET ManagedBy = @ManagedByValue WHERE ProviderID = @ProviderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagedByValue", Globals.LoggedInUserID);
                        cmd.Parameters.AddWithValue("@ProviderID", int.Parse(txtUserID.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service provider updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching service provider found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating service provider: " + ex.Message);
                }
            }
            showproviders_Click(null, null);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (showing == 1)
            {
                DeleteTraveller();
            }
            else if (showing == 2)
            {
                DeleteTourOperator();
            }
            else if (showing == 3)
            {
                DeleteServiceProvider();
            }

        }
        
        // DELETE Traveller and related User
        private void DeleteTraveller()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();
                        // Delete from Traveller table
                        string deleteTravellerQuery = "DELETE FROM Traveller WHERE TravellerID = @TravellerID";
                        SqlCommand deleteTravellerCmd = new SqlCommand(deleteTravellerQuery, conn);
                        deleteTravellerCmd.Parameters.AddWithValue("@TravellerID", int.Parse(txtUserID.Text));
                        deleteTravellerCmd.ExecuteNonQuery();

                        // Delete from User table
                        string deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";
                        SqlCommand deleteUserCmd = new SqlCommand(deleteUserQuery, conn);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", int.Parse(txtUserID.Text));
                        deleteUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Traveller and corresponding user deleted.");
                        showtravellers_Click(null, null);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting traveller: " + ex.Message);
                }
            }
        }

        // DELETE Tour Operator and related User
        private void DeleteTourOperator()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                        string deleteOperatorQuery = "DELETE FROM TourOperator WHERE OperatorID = @OperatorID";
                        SqlCommand deleteOperatorCmd = new SqlCommand(deleteOperatorQuery, conn);
                        deleteOperatorCmd.Parameters.AddWithValue("@OperatorID", int.Parse(txtUserID.Text));
                        deleteOperatorCmd.ExecuteNonQuery();

                        string deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";
                        SqlCommand deleteUserCmd = new SqlCommand(deleteUserQuery, conn);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", int.Parse(txtUserID.Text));
                        deleteUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Tour operator and corresponding user deleted.");
                        showoperators_Click(null, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting tour operator: " + ex.Message);
                }
            }
        }

        // DELETE Service Provider and related User
        private void DeleteServiceProvider()
        {
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    conn.Open();

                        string deleteProviderQuery = "DELETE FROM ServiceProvider WHERE ProviderID = @ProviderID";
                        SqlCommand deleteProviderCmd = new SqlCommand(deleteProviderQuery, conn);
                        deleteProviderCmd.Parameters.AddWithValue("@ProviderID", int.Parse(txtUserID.Text));
                        deleteProviderCmd.ExecuteNonQuery();

                        string deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";
                        SqlCommand deleteUserCmd = new SqlCommand(deleteUserQuery, conn);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", int.Parse(txtUserID.Text));
                        deleteUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Service provider and corresponding user deleted.");
                        showproviders_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting service provider: " + ex.Message);
                }
            }
        }

    }
}
