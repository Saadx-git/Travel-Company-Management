using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_project
{
    public partial class TripDashboard : Form
    {
        public TripDashboard()
        {
            InitializeComponent();
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDigitalPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalTravelPass digitalTravelPassForm = new DigitalTravelPass();
            digitalTravelPassForm.Show();
        }

        private void btnReviewsRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewAndRatingForm reviewAndRatingForm = new ReviewAndRatingForm();
            reviewAndRatingForm.Show();
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Management profileManagementForm = new Profile_Management();
            profileManagementForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchnBooking searchBookingForm = new SearchnBooking();
            searchBookingForm.Show();
        }
    }
}
