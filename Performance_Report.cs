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
    public partial class Form6 : Form
{
    public Form6()
    {
        InitializeComponent();
    }

    private void Form6_Load(object sender, EventArgs e)
    {

    }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Service_Listing serviceListing = new Service_Listing();
            serviceListing.Show();
        }
    }
}
