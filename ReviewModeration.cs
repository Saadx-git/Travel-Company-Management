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
    public partial class ReviewModeration : Form
    {
        

        public ReviewModeration()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadReviews();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface adminInterface = new AdminInterface();
            adminInterface.Show();
        }

        private void LoadReviews()
        {

            string command = "SELECT * FROM Review";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dgvReviews.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string command = "Delete from Review where ReviewID = @id";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtReviewID.Text));
                    conn.Open();
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if(rowsaffected > 0)
                    MessageBox.Show("Review Deleted");
                    else
                    MessageBox.Show("Review Not Found");
                }
               
            }
            LoadReviews();
        }
    }
}
