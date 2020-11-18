using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class StaffItem : UserControl
    {
        public StaffItem()
        {
            InitializeComponent();
        }
        public StaffItem(string id, string name, string birthdate, string position, string userName, int workingTime, int salary)
        {
            InitializeComponent();
            this.lbID.Text = id;
            this.lbName.Text = name;
            this.lbBirthDate.Text = birthdate;
            this.lbPosition.Text = position;
            this.lbUserName.Text = userName;
            this.lbWorkingTime.Text = workingTime.ToString();
            this.lbSalary.Text = salary.ToString();
        }

        private void StaffItem_Load(object sender, EventArgs e)
        {

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

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }
    }
}
