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
    public partial class ManageTrip : Form
    {
        public ManageTrip()
        {
            InitializeComponent();
            Load_Trip();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        void Load_Trip() {
            string query = "SELECT TripID, Title, Itinerary, StartDate, EndDate, Duration, GroupSize, AudienceType, Trip_Price FROM Trip where OperatorID = @id and EndDate > @today";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Globals.LoggedInUserID);
                cmd.Parameters.AddWithValue("@today", DateTime.Now);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                //the data is not showing in the table maybe the text color is white
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //selected the selected trip id from the datagrid
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int tripId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["TripID"].Value);
                Globals.temporaryint = tripId;
                this.Hide();
                UpdateTrip updateTrip = new UpdateTrip();
                updateTrip.Show();
            }
            else
            {
                MessageBox.Show("Please select a trip to update.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            this.Hide();
            CreateTrip login = new CreateTrip();
            login.Show();

        }
        private void load_trips()
        {
            string query = "SELECT * FROM Trip where OperatorID = @id";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Globals.LoggedInUserID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete from trip table the trip id that is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int tripId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["TripID"].Value);
                string query = "DELETE FROM Trip WHERE TripID = @tripid";
                using (SqlConnection conn = new SqlConnection(Globals.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tripid", tripId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip deleted successfully.");
                        Load_Trip();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting trip.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to delete.");
            }
        }
    }
}
