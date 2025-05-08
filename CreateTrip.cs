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
            DestinationInfo destinationInfo = new DestinationInfo();
            destinationInfo.Show();
            this.Hide();
        }
        public void InsertTrip()
        {
            // 1) Gather inputs
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

            // 2) Lookup CategoryID
            int categoryID = 0;
            const string lookupSql =
                "SELECT CategoryID FROM Category WHERE Name = @category";
            using (var conn = new SqlConnection(Globals.connectionString))
            using (var cmd = new SqlCommand(lookupSql, conn))
            {
                cmd.Parameters.AddWithValue("@category", category);
                conn.Open();
                object cat = cmd.ExecuteScalar();
                if (cat == null)
                {
                    MessageBox.Show("Category not found.");
                }
                categoryID = Convert.ToInt32(cat);
            }

            // 3) Insert and OUTPUT the new TripID
            const string insertSql = @"
        INSERT INTO Trip
          (OperatorID, Title, Itinerary, StartDate, EndDate, Duration,
           GroupSize, AudienceType, Trip_Price, CategoryID)
        OUTPUT INSERTED.TripID
        VALUES
          (@OperatorID, @Title, @Itinerary, @StartDate, @EndDate,
           @Duration, @GroupSize, @AudienceType, @Trip_Price, @CategoryID)";

            using (var conn = new SqlConnection(Globals.connectionString))
            using (var cmd = new SqlCommand(insertSql, conn))
            {
                cmd.Parameters.AddWithValue("@OperatorID", operatorID);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Itinerary", itinerary);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@GroupSize", groupSize);
                cmd.Parameters.AddWithValue("@AudienceType", audienceType);
                cmd.Parameters.AddWithValue("@Trip_Price", tripPrice);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newTripID))
                {
                    MessageBox.Show($"Trip created successfully. TripID: {newTripID}");
                    Globals.temporaryint = newTripID;
                }
                else
                {
                    MessageBox.Show("Trip creation failed.");
                   
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
