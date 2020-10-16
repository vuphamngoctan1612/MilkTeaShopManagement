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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();

            LoadDrink();
        }
        
        void LoadDrink()
        {
            string query = "SELECT * FROM Drinks";
            this.dtgvDrinks.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
