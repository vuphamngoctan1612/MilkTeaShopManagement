using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance 
        { 
            get { if (instance == null) instance = new MenuDAL(); return instance; }
            set => instance = value; 
        }

        private MenuDAL() { }

        public List<Menu> GetListMenu()
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select d.Name, d.Price, bd.Count from BillInfo as bd, Drinks as d where bd.IdDrink = d.ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
