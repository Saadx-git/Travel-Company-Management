using @new;
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
    public partial class Service_Integration : Form
    {
        public Service_Integration()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }

        private void BookinMangement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagement bookingManagementForm = new BookingManagement();
            bookingManagementForm.Show();
        }

        private void btnperformance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 performanceManagement = new Form6();
            performanceManagement.Show();
        }

        private void Service_Integration_Load(object sender, EventArgs e)
        {

        }
    }
}
