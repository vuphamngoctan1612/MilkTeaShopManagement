using MilkTeaShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement
{
    public partial class fListStaff : Form
    {
        public fListStaff()
        {
            InitializeComponent();

            LoadStaff();
        }

        void LoadStaff()
        {
            string query = "select * from Staff";
            this.dtgvListStaff.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
