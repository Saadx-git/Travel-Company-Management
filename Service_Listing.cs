using Db_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @new
{
    public partial class Service_Listing : Form
{
    public Service_Listing()
    {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
    }

        private void btnServiceConfirmation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Integration serviceIntegration = new Service_Integration();
            serviceIntegration.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 performanceReport = new Form6();
            performanceReport.Show();
        }

        private void btn_BookingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagement bookingManagement = new BookingManagement();
            bookingManagement.Show();
        }
    }
}
