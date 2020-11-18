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
            usTitle ustitle = new usTitle();
            flowLayoutPanelTitle.Controls.Add(ustitle);
            ustitle.onAdd += usTitle_onAdd;
            LoadStaff();
        }
        #region Methods
        public void LoadStaff()
        {
            List<Staff> staffs = StaffDAL.Instance.LoadStaffs();

            foreach (Staff staff in staffs)
            {
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.BirthDate, staff.Position, staff.UserName, staff.WorkingTime, staff.Salary);
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.Tag = staff;
                flowLayoutPanelStaff.Controls.Add(staffItem);
            }
            
        }
        #endregion

        #region Events
        private void usTitle_onAdd(object sender, EventArgs e)
        { 
            fAddStaff f = new fAddStaff();
            f.ShowDialog();
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        
        private void StaffItem_onDel(object sender, EventArgs e)
        {
            StaffDAL.Instance.DelStaff(int.Parse(((sender as StaffItem).Tag as Staff).ID));
            Account.Instance.DelAccount(((sender as StaffItem).Tag as Staff).UserName);
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void Item_OnEdit(object sender, EventArgs args)
        {
            fEditStaff frm = new fEditStaff(int.Parse(((sender as StaffItem).Tag as Staff).ID));
            frm.ShowDialog();
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        #endregion
    }
}
