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

            this.cbbStaff.Text = "Thu ngân";
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            foreach(Position pos in positions)
            {
                this.cbbStaff.Items.Add(pos.Name);
            }    
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
            int salary = ConvertToNumber(this.txtSalary.Text);
            int overTimeSalary = ConvertToNumber(this.txtOverTime.Text);
            int MinusSalary = ConvertToNumber(this.txtMinusSalary.Text);

            if (string.IsNullOrEmpty(cbbStaff.Text))
            {
                MessageBox.Show("Chọn vị trí công việc", "Error");
            }
            else
            {
                PositionDAL.Instance.UpdateSalary(position, salary, overTimeSalary, MinusSalary);
                this.Close();
            }
        }

        private void cbbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string position = this.cbbStaff.Text;
            this.txtSalary.Text = PositionDAL.Instance.GetSalarybyPosition(position).ToString();
            this.txtOverTime.Text = PositionDAL.Instance.GetOverTimeSalarybyPosition(position).ToString();
            this.txtMinusSalary.Text = PositionDAL.Instance.GetMinusSalarybyPosition(position).ToString();
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.txtName.Visible = true;
            this.cbbStaff.Visible = false;
            this.btSave.Visible = false;
            this.btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pos = this.txtName.Text;
            int salary = ConvertToNumber(this.txtSalary.Text);
            int overTimeSalary = ConvertToNumber(this.txtOverTime.Text);
            int minusSalary = ConvertToNumber(this.txtMinusSalary.Text);
            if (string.IsNullOrEmpty(pos))
            {
                MessageBox.Show("Nhập vị trí công việc");
            }    
            else
            {
                try
                {
                    PositionDAL.Instance.AddPosition(pos, salary, overTimeSalary, minusSalary);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Trùng vị trí trước đó");
                }
            }    
        }
    }
}
