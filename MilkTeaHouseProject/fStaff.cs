using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditStaff f = new fEditStaff();
            f.ShowDialog();
        }
        public void LoadStaff()
        {
            List<Staff> staffs = StaffDAL.Instance.LoadStaffs();

            foreach (Staff staff in staffs)
            {
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.BirthDate, staff.Position, staff.UserName, staff.BasicSalary, staff.WorkingTime, staff.Salary);
                flowLayoutPanelStaff.Controls.Add(staffItem);
            }
            usTitle ustitle = new usTitle();
            flowLayoutPanelTitle.Controls.Add(ustitle);
        }

        
    }
}
