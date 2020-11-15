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
        public StaffItem(string id, string name, string birthdate, string position, string userName, int basicSalary, int workingTime, int salary)
        {
            InitializeComponent();
            this.lbID.Text = id;
            this.lbName.Text = name;
            this.lbBirthDate.Text = birthdate;
            this.lbPosition.Text = position;
            this.lbUserName.Text = userName;
            this.lbBasicSalary.Text = basicSalary.ToString();
            this.lbWorkingTime.Text = workingTime.ToString();
            this.lbSalary.Text = salary.ToString();
        }

        private void StaffItem_Load(object sender, EventArgs e)
        {

        }

        
    }
}
