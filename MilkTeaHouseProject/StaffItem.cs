using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class StaffItem : UserControl
    {
        public StaffItem()
        {
            InitializeComponent();
        }
        public StaffItem(int id, string name, DateTime birthdate, string position, string userName, int workingTime, int salary)
        {
            InitializeComponent();
            this.lbID.Text = id.ToString();
            this.lbName.Text = name;
            this.lbBirthDate.Text = birthdate.ToString();
            this.lbPosition.Text = position;
            this.lbUserName.Text = userName;
            this.lbOverTime.Text = workingTime.ToString();
            this.lbSalary.Text = salary.ToString();
        }
        public event EventHandler onEdit = null;
        public event EventHandler onDel = null;


        private void btEdit_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onEdit.Invoke(this, new EventArgs());
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }
    }
}
