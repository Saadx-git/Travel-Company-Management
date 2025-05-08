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
    public partial class DestinationInfo : Form
    {
        public DestinationInfo()
        {
            InitializeComponent();
        }

        private void InsertDestination() {
           

            string city = txtcity.Text;
            string country = txtcountry.Text;
            string region = txtregion.Text;
            string description = txtdescription.Text;
            int destinationID;
            // 2) Insert into Destination table
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                conn.Open();
           
                string insertDestinationQuery = "INSERT INTO Destination (City, Country, Region, Destination_Description) OUTPUT INSERTED.DestinationID VALUES (@City, @Country, @Region, @Description)";
                using (SqlCommand cmd = new SqlCommand(insertDestinationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Region", region);
                    cmd.Parameters.AddWithValue("@Description", description);
                    destinationID = (int)cmd.ExecuteScalar();
                   
                }
            }

            //nOW INSERT INTO TRIP OFFERS DESTINATION TABLE
            using (SqlConnection conn = new SqlConnection(Globals.connectionString))
            {
                conn.Open();
                string insertTripOffersDestinationQuery = "INSERT INTO Trip_Offers_Destination (TripID, DestinationID) VALUES (@TripID, @DestinationID)";
                using (SqlCommand cmd = new SqlCommand(insertTripOffersDestinationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TripID", Globals.temporaryint);
                    
                    cmd.Parameters.AddWithValue("@DestinationID", destinationID);
                    cmd.ExecuteNonQuery();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertDestination();
            MessageBox.Show("Destination inserted successfully!");
            this.Hide();
            new HotelAssignment().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateTrip().Show();
        }
    }
}
