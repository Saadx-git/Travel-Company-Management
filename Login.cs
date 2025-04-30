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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TripDashboard tripDashboardForm = new TripDashboard();
            tripDashboardForm.Show();
        }
    }
}
