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
    public partial class CreateTrip : Form
    {
        public CreateTrip()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageTrip Manage = new ManageTrip();
            Manage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertTrip();
            HotelAssignment hotel = new HotelAssignment();
            hotel.Show();
            this.Hide();
        }
        public void InsertTrip()
        {
            string title = titlebox.Text;
            string itinerary = richTextBox1.Text;
            DateTime startDate = startdate.Value;
            DateTime endDate = enddate.Value;
            int duration = int.Parse(durationbox.Text);
            int groupSize = int.Parse(groupsize.Text);
            string audienceType = audience.Text;
            int tripPrice = int.Parse(txtprice.Text);
            string category = textBox1.Text;
            int operatorID = Globals.LoggedInUserID;
            int categoryID = 0;
            string query = "SELECT CategoryID FROM Category WHERE Name = @category";
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@category", category);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    categoryID = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Category not found.");
                    return;
                }
                reader.Close();
            }
            string insertQuery = "INSERT INTO Trip (OperatorID, Title, Itinerary, StartDate, EndDate, Duration, GroupSize, AudienceType, Trip_Price, CategoryID) " +
                "VALUES (@OperatorID, @Title, @Itinerary, @StartDate, @EndDate, @Duration, @GroupSize, @AudienceType, @Trip_Price, @CategoryID)";
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@OperatorID", operatorID);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Itinerary", itinerary);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@GroupSize", groupSize);
                command.Parameters.AddWithValue("@AudienceType", audienceType);
                command.Parameters.AddWithValue("@Trip_Price", tripPrice);
                command.Parameters.AddWithValue("@CategoryID", categoryID);

                connection.Open();
                command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Trip creation failed.");
                    return;
                }
                else
                {
                    MessageBox.Show("Trip created successfully.");
                }
            }
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Management profileManagement = new Profile_Management();
            profileManagement.Show();
        }
    }
}
