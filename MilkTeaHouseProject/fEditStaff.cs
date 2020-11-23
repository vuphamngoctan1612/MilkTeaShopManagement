using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fEditStaff : Form
    {
        public fEditStaff(int ID, string name, DateTime BirthDate, string pos, int salary)
        {
            InitializeComponent();
            this.lbIdIncrease.Text = ID.ToString();
            this.txtName.Text = name;
            this.dateTimePicker1.Value = BirthDate;
            this.comboBox1.Text = pos;
            this.txtSalary.Text = salary.ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string iD = this.lbIdIncrease.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dateTimePicker1.Value;
            string pos = this.comboBox1.Text;
            string salary = this.txtSalary.Text;
            int overtime = 0;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập Họ Tên", "Error");
            }
            else if (string.IsNullOrEmpty(pos))
            {
                MessageBox.Show("Chọn Công việc", "Error");
            }
            else if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Nhập mức lương cơ bản", "Error");
            }
            else
            {
                StaffDAL.Instance.EditStaff(int.Parse(iD), name, birthdate, pos, int.Parse(salary), overtime);
                this.Close();
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
