using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void lbSignup_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
