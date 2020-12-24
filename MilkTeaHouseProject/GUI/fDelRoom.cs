using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject.GUI
{
    public partial class fDelRoom : Form
    {
        public string nameGroup;
        public bool flag = false;

        public fDelRoom()
        {
            InitializeComponent();

            DropShadow dr = new DropShadow();
            dr.ApplyShadows(this);

            LoadRoom();
        }

        public void LoadRoom()
        {
            List<GroupTable> groups = GroupTableDAL.Instance.GetListGroupTable();

            foreach (GroupTable item in groups)
            {
                if (TableFoodDAL.Instance.CountTableTruebyGroupTable(item.Name) == 0)
                {
                    cbGroup.Items.Add(item.Name);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            GroupTableDAL.Instance.DeleteGroup(cbGroup.Text);
            flag = true;
            nameGroup = cbGroup.Text;
            btnExit_Click(sender, e);
        }
    }
}
