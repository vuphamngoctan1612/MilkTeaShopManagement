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
        public void LoadStaff()
        {
            List<Staff> staffs = StaffDAL.Instance.LoadStaffs();

            foreach (Staff staff in staffs)
            {
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image,staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Salary);
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.Tag = staff;
                flowLayoutPanelStaff.Controls.Add(staffItem);
                staffItem.Width = flowLayoutPanelStaff.Width;
            }

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
            int salary = ((sender as StaffItem).Tag as Staff).Salary;
            fEditStaff frm = new fEditStaff(iD, name, birthDate, pos, salary);
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
                item.Width = this.flowLayoutPanelStaff.Width;
            }
            int space = this.flowLayoutPanelStaff.Width / 8 + 3;
            lbID.Location = new Point(5, 6);
            lbName.Location = new Point(space + 5, 6);
            lbBirthDate.Location = new Point(space * 3, 6);
            lbPosition.Location = new Point(space * 4 + 10, 6);
            lbUserName.Location = new Point(space * 5 - 10, 6);
            lbSalary.Location = new Point(space * 6 + 20, 6);
        }


    }
}
