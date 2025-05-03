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
    public partial class SignUpAs : Form
    {
        public SignUpAs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TourOperatorSignUp tourOperatorSignUpForm = new TourOperatorSignUp();
            tourOperatorSignUpForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
