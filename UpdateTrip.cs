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
    public partial class UpdateTrip : Form
    {
        public UpdateTrip()
        {
            InitializeComponent();
            load_details();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTrip login = new CreateTrip();
            login.Show();

        }
        private void load_details() {
            string query = "SELECT TripID, Title, Itinerary, StartDate, EndDate, Duration, GroupSize, AudienceType, Trip_Price FROM Trip WHERE TripID = @tripid";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tripid", Globals.temporaryint);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    titlebox.Text = reader["Title"].ToString();
                    richTextBox1.Text = reader["Itinerary"].ToString();
                    startdate.Value = Convert.ToDateTime(reader["StartDate"]);
                    enddate.Value = Convert.ToDateTime(reader["EndDate"]);
                    durationbox.Text = reader["Duration"].ToString();
                    groupsize.Text = reader["GroupSize"].ToString();
                    audience.Text = reader["AudienceType"].ToString();
                    txtprice.Text = reader["Trip_Price"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Trip SET Title = @title, Itinerary = @itinerary, StartDate = @startdate, EndDate = @enddate, Duration = @duration, GroupSize = @groupsize, AudienceType = @audience, Trip_Price = @price WHERE TripID = @tripid";
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", titlebox.Text);
                cmd.Parameters.AddWithValue("@itinerary", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@startdate", startdate.Value);
                cmd.Parameters.AddWithValue("@enddate", enddate.Value);
                cmd.Parameters.AddWithValue("@duration", durationbox.Text);
                cmd.Parameters.AddWithValue("@groupsize", groupsize.Text);
                cmd.Parameters.AddWithValue("@audience", audience.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.Parameters.AddWithValue("@tripid", Globals.temporaryint);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Trip updated successfully.");
                    this.Hide();
                    ManageTrip manageTrip = new ManageTrip();
                    manageTrip.Show();
                }
                else
                {
                    MessageBox.Show("Error updating trip.");
                }
                load_details();
            }

        }
    }
}
