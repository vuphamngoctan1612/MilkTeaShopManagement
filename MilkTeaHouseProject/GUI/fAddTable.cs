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
        
        #region Method
        private void LoadGroup()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from GroupTable");
            cbbGroup.DataSource = dt;
            cbbGroup.DisplayMember = "NAME";
        }

        private void ShowError(Control control, string error)
        {
            control.Focus();
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }
        #endregion

        #region event

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                    this.Close();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtGroup.Text))
                    {
                        GroupTableDAL.Instance.AddGroupTable(txtGroup.Text);
                        TableFoodDAL.Instance.AddTable(txtName.Text, txtGroup.Text);
                        this.Close();
                    }
                    else
                    {
                        ShowError(txtGroup, "Vui lòng nhập tên nhóm mới");
                    }
                }
            }
            else
            {
                ShowError(txtName, "Vui lòng nhập tên bàn");
            }

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (cbbGroup.Visible)
            {
                cbbGroup.Visible = false;
                txtGroup.Visible = true;
            }
            else
            {
                txtGroup.Visible = false;
                cbbGroup.Visible = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void txtGroup_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }
        #endregion
    }
}
