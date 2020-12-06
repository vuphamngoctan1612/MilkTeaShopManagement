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
    public partial class fAddTable : Form
    {
        public fAddTable(int ID)
        {
            InitializeComponent();
            txtID.Text = ID.ToString();

            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadGroup()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from GroupTable");
            cbbGroup.DataSource = dt;
            cbbGroup.DisplayMember = "NAME";
        }

        private void fAddTable_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (cbbGroup.Visible == true)
                {
                    TableFoodDAL.Instance.AddTable(txtName.Text, cbbGroup.Text);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtGroup.Text))
                    {
                        GroupTableDAL.Instance.AddGroupTable(txtGroup.Text);
                        TableFoodDAL.Instance.AddTable(txtName.Text, txtGroup.Text);
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhập nhóm mới");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập tên bàn");
            }

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (cbbGroup.Visible)
            {
                cbbGroup.Visible = false;
            }
            else
            {
                cbbGroup.Visible = true;
            }
        }
    }
}
