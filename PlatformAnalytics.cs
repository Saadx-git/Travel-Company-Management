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
    public partial class PlatformAnalytics : Form
    {
        public PlatformAnalytics()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInterface adminInterface = new AdminInterface();
            adminInterface.Show();

        }
    }
}
