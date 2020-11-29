using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MilkTeaHouseProject.DAL;
using System.Data.SqlClient;


namespace MilkTeaHouseProject
{
    public partial class fCategory : Form
    {
        public fCategory()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNameDrink.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên loại!", "Lỗi");
                    return;
                }

                CategoryDAL.Instance.AddCategory(txtNameDrink.Text);
                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Trùng loại");
            }
        }
    }
}
