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
        public fStaff()
        {
            InitializeComponent();
            LoadStaff();

        }
        #region Method
        public void LoadStaff()
        {
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();

            foreach (Staff staff in staffs)
            {
                int salaryReceived = staff.Salary + staff.OverTime * staff.OverTimeSalary - staff.Fault * staff.MinusSalary;
                StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image,staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault,staff.SalaryReceived);
                
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                staffItem.onFaultChanged += StaffItem_onFaultChanged;
                staffItem.Tag = staff;

                flowLayoutPanelStaff.Controls.Add(staffItem);
                staffItem.Width = flowLayoutPanelStaff.Width;
            }

        }
        #endregion

        #region Events
        private void StaffItem_onFaultChanged (object sender, EventArgs e)
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
            else
            {
                StaffDAL.Instance.DelStaff(iD);
            }

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void Item_OnEdit(object sender, EventArgs args)
        {
            int iD = ((sender as StaffItem).Tag as Staff).ID;
            string name = ((sender as StaffItem).Tag as Staff).Name;
            DateTime birthDate = ((sender as StaffItem).Tag as Staff).BirthDate;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            string phonenumber = ((sender as StaffItem).Tag as Staff).PhoneNumber;
            fEditStaff frm = new fEditStaff(iD, name, birthDate, pos, phonenumber);
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
            foreach (Control item in flowLayoutPanelStaff.Controls)
            {
                item.Width = this.flowLayoutPanelStaff.Width-10;
            }
            int space = this.flowLayoutPanelStaff.Width /8;
            lbID.Location = new Point(85, 5);
            lbName.Location = new Point((int)(space * 1.7), 5);
            lbBirthDate.Location = new Point((int)(space * 3), 5);
            lbPosition.Location = new Point(space * 4, 5);
            lbUserName.Location = new Point((int)(space *4.9), 5);
            lbSalary.Location = new Point(space * 6, 5);
        }

        private void btSetSalary_Click(object sender, EventArgs e)
        {
            fSetSalary f = new fSetSalary();
            f.ShowDialog();
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        #endregion
    }
}
