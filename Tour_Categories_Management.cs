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
    public partial class Tour_Categories_Management : Form
    {
        public Tour_Categories_Management()
        {
            InitializeComponent();
            load_categories();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface adminInterface = new AdminInterface();
            adminInterface.Show();
        }

        private void load_categories()
        {
            try
            {
                dgvTourCategories.DataSource = GetCategoriesFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message);
            }
        }

        private DataTable GetCategoriesFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                string query = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }


        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Category SET Name = @Name, Description = @Description WHERE CategoryID = @CategoryID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(textBox1.Text));
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Description", richTextBox1.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category updated successfully.");
                        load_categories(); // refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to update category.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            load_categories();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Delete From Category WHERE CategoryID = @CategoryID";

                    SqlCommand command = new SqlCommand(query, connection);
                     command.Parameters.AddWithValue("@CategoryID", textBox1.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Deleted successfully.");
                        load_categories(); // refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete category.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            load_categories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Category (Name, Description) VALUES (@Name, @Description)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Description", richTextBox1.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category added successfully.");
                        load_categories(); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to add category.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            load_categories();
        }

    }
}
