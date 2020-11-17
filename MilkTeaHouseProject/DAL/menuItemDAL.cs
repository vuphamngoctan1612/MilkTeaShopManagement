using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using MilkTeaShopManagement.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DTO;
using System.Windows.Forms;

namespace MilkTeaHouseProject.DAL
{
    public class menuItemDAL
    {
        private static menuItemDAL instance;

        public static menuItemDAL Instance
        {
            get { if (instance == null) instance = new menuItemDAL(); return menuItemDAL.instance; }
            private set { menuItemDAL.instance = value; }
        }

        private menuItemDAL() { }

        public List<MenuItemDTO> LoadDrinks()
        {
            List<MenuItemDTO> drinks = new List<MenuItemDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Drinks");

            foreach (DataRow dataRow in data.Rows)
            {
                MenuItemDTO drink =new MenuItemDTO(dataRow);
                drinks.Add(drink);
            }

            return drinks;
        }
    }
}
