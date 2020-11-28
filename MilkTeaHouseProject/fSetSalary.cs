using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;
using System.Runtime.InteropServices;

namespace MilkTeaHouseProject
{
    public partial class fSetSalary : Form
    {
        public fSetSalary()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Method
        public int ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }

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
        #endregion

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string position = this.cbbStaff.Text;
            int Salary = ConvertToNumber(this.txtSalary.Text);
            int OverTimeSalary = ConvertToNumber(this.txtOverTime.Text);
            int MinusSalary = ConvertToNumber(this.txtMinusSalary.Text);

            if (string.IsNullOrEmpty(cbbStaff.Text))
            {
                MessageBox.Show("Chọn vị trí công việc", "Error");
            }
            else if (string.IsNullOrEmpty(txtSalary.Text))
            {
                this.txtSalary.Text = "0";
                Salary = 0;
            }
            else if (string.IsNullOrEmpty(txtOverTime.Text))
            {
                this.txtOverTime.Text = "0";
                OverTimeSalary = 0;
            }
            else if (string.IsNullOrEmpty(txtMinusSalary.Text))
            {
                this.txtMinusSalary.Text = "0";
                MinusSalary = 0;
            }
            else
            {
                StaffDAL.Instance.UpdateSalary(position, Salary, OverTimeSalary, MinusSalary);
                this.Close();
            }
        }

        private void cbbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string position = this.cbbStaff.Text;

            this.txtSalary.Text = StaffDAL.Instance.GetSalarybyPosition(position).ToString();
            this.txtOverTime.Text = StaffDAL.Instance.GetOvertimeSalarybyPosition(position).ToString();
            this.txtMinusSalary.Text = StaffDAL.Instance.GetMinusSalarybyPosition(position).ToString();
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinusSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(txtSalary);
        }

        private void txtOverTime_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(txtOverTime);
        }

        private void txtMinusSalary_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(txtMinusSalary);
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
