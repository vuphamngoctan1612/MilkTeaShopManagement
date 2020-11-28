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

namespace MilkTeaHouseProject
{
    public partial class MakeABill : Form
    {
        private string username;
        public MakeABill(string username)
        {
            InitializeComponent();
            this.username = username;
            this.txtIDBill.Text = (BillDAL.Instance.GetMAXIDBill() + 1).ToString();
            this.txtStaffID.Text = StaffDAL.Instance.GetStaffIDbyUsername(username).ToString();
        }

        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void SeparateThousands(Guna.UI.WinForms.GunaLineTextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        public int CovertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }
        #endregion

        #region Event
        private void gunaLineTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.btnAdd_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idStaff = StaffDAL.Instance.GetStaffIDbyUsername(this.username);

            if (string.IsNullOrEmpty(txtTotal.Text.ToString()))
                MessageBox.Show("Nhập giá trị phiếu chi");
            else
            {
                BillDAL.Instance.MakeABill(idStaff, txtNote.Text, CovertToNumber(txtTotal.Text) * -1);
                MessageBox.Show("Lập thành công");
                this.Close();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(this.txtTotal);
        }
        #endregion
    }
}
