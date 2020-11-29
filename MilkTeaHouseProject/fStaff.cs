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
    public partial class fStaff : Form
    {
        private int totalSalary;
        private string username;
        public fStaff(string username)
        {
            InitializeComponent();
            LoadStaff();
            this.username = username;
        }
        #region Method

        void sizeChange()
        {
            foreach (Control item in flowLayoutPanelStaff.Controls)
            {
                item.Width = this.flowLayoutPanelStaff.Width;
            }
            int space = this.flowLayoutPanelStaff.Width / 8;
            lbID.Location = new Point(85, 5);
            lbName.Location = new Point((int)(space * 1.7), 5);
            lbBirthDate.Location = new Point((int)(space * 2.8), 5);
            lbPosition.Location = new Point((int)(space * 3.6), 5);
            lbUserName.Location = new Point((int)(space * 4.2), 5);
            lbOvertime.Location = new Point((int)(space * 5.1), 5);
            lbFaust.Location = new Point((int)(space * 6), 5);
            lbSalary.Location = new Point((int)(space * 6.6), 5);
        }
        public void LoadStaff()
        {
            totalSalary = 0;
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();
            bool setcolor = true;

            foreach (Staff staff in staffs)
            {
                if (setcolor == true)
                {
                    setcolor = false;
                }
                else
                {
                    setcolor = true;
                }

                int salaryReceived = staff.Salary + staff.OverTime * staff.OverTimeSalary - staff.Fault * staff.MinusSalary;
                StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, staff.SalaryReceived, setcolor);

                totalSalary += staff.SalaryReceived;
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                staffItem.onFaultChanged += StaffItem_onFaultChanged;
                staffItem.Tag = staff;

                flowLayoutPanelStaff.Controls.Add(staffItem);
                sizeChange();
            }

        }

        public void SearchStaff(string search)
        {
            totalSalary = 0;
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();
            this.flowLayoutPanelStaff.Controls.Clear();
            bool setcolor = true;

            foreach (Staff staff in staffs)
            {
                string name = staff.Name;
                if (name.ToLower().Contains(this.txtSearch.Text.ToLower()))
                {
                    if (setcolor == true)
                        setcolor = false;
                    else
                        setcolor = true;
                    int salaryReceived = staff.Salary + staff.OverTime * staff.OverTimeSalary - staff.Fault * staff.MinusSalary;
                    StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                    StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, staff.SalaryReceived, setcolor);

                    totalSalary += staff.SalaryReceived;
                    staffItem.onEdit += Item_OnEdit;
                    staffItem.onDel += StaffItem_onDel;
                    staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                    staffItem.onFaultChanged += StaffItem_onFaultChanged;
                    staffItem.Tag = staff;

                    flowLayoutPanelStaff.Controls.Add(staffItem);
                }
                sizeChange();
            }
        }
        #endregion

        #region Events
        private void StaffItem_onFaultChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void StaffItem_onOverTimeValueChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void StaffItem_onDel(object sender, EventArgs e)
        {
            int iD = ((sender as StaffItem).Tag as Staff).ID;
            string username = ((sender as StaffItem).Tag as Staff).UserName;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            if (pos == "Thu Ngân")
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.DelStaff(iD);
                AccountDAL.Instance.DelAccount(username);
            }
            else if (pos == "Quản lí")
            {
                MessageBox.Show("Không thể xóa chức vụ này");
            }
            else
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.DelStaff(iD);
            }

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void Item_OnEdit(object sender, EventArgs args)
        {
            int id = ((sender as StaffItem).Tag as Staff).ID;
            string name = ((sender as StaffItem).Tag as Staff).Name;
            DateTime birthDate = ((sender as StaffItem).Tag as Staff).BirthDate;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            string phonenumber = ((sender as StaffItem).Tag as Staff).PhoneNumber;
            string username = ((sender as StaffItem).Tag as Staff).UserName;

            fEditStaff frm = new fEditStaff(id, name, birthDate, pos, phonenumber, username);
            //fAddStaff frm = new fAddStaff(id, name, birthDate, pos, phonenumber);
            frm.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void flowLayoutPanelStaff_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }

        private void btSetSalary_Click(object sender, EventArgs e)
        {
            fSetSalary f = new fSetSalary();
            f.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelStaff.Controls.Count > 0)
            {
                StaffDAL.Instance.ResetOverandFault();
                BillDAL.Instance.UpdateBillSalary(username, totalSalary * -1);
                MessageBox.Show("Kết toán lương thành công");
                this.flowLayoutPanelStaff.Controls.Clear();
                LoadStaff();
            }
            else
            {
                MessageBox.Show("Không có nhân viên nào");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStaff(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStaff(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

    }
}
