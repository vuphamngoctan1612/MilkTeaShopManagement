using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject
{
    public partial class fDelCategory : Form
    {
        public fDelCategory()
        {
            InitializeComponent();
            LoadNameCategory();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LoadNameCategory()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Category");
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "NAME";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string category = cbCategory.Text;

            DrinkDAL.Instance.SetnullForCategory(category);
            CategoryDAL.Instance.DeleteCategory(category);
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDelCategory_Load(object sender, EventArgs e)
        {
            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }
    }
}
