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

namespace MilkTeaHouseProject
{
    public partial class fSetSalary : Form
    {
        public fSetSalary()
        {
            InitializeComponent();
        }

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
            string pos = this.cbbStaff.Text;
            int salary = ConvertToNumber(this.txtSalary.Text);
            int overTimeSalary = ConvertToNumber(this.txtOverTime.Text);
            int minusSalary = ConvertToNumber(this.txtMinusSalary.Text);
            if(string.IsNullOrEmpty(pos))
            {
                MessageBox.Show("Chọn vị trí công việc", "Error");
            }    
            else if (string.IsNullOrEmpty(salary.ToString()))
            {
                MessageBox.Show("Nhập mức lương cơ bản", "Error");
            }    
            else if (string.IsNullOrEmpty(overTimeSalary.ToString()))
            {
                MessageBox.Show("Nhập mức lương tăng ca", "Error");
            }
            else if (string.IsNullOrEmpty(minusSalary.ToString()))
            {
                MessageBox.Show("Nhập mức lương trừ khi dính lỗi", "Error");
            }    
            else
            {
                StaffDAL.Instance.UpdateSalary(pos, salary, overTimeSalary, minusSalary);
                this.Close();
            }    
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMinusSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
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
    }
}
