using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement
{
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            string newPassWord = txtNewPassWord.Text;
            string rePassWord = txtRePassWord.Text;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
