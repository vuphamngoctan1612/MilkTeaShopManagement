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
            private set => instance = value;
        }

        private MenuDAL() { }

        public List<Menu> GetListMenu()
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select bd.ID as IDBillInfo, d.ID as IDDrink, d.Name, d.Price, bd.Count " +
                            "from BillInfo as bd " +
                            "inner join Drink as d " +
                            "on bd.DrinkID = d.ID";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<Menu> GetListMenu(int idBill)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select b.ID as BillID, bf.ID as IDBillInfo, d.ID as IDDrink, d.Name, d.Price, bf.Count " +
                            "from (" +
                            "(BillInfo as bf inner join Drink as d on bf.DrinkID = d.ID)" +
                            " inner join Bill as b on b.ID = bf.BillID) " +
                            "where b.ID = " + idBill;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public int GetCount()
        {
            List<Menu> listMenu = this.GetListMenu(BillDAL.Instance.GetMAXIDBill());

            int Count = 0;

            foreach (Menu item in listMenu)
            {
                Count += item.Count;
            }

            return Count;
        }

        public int GetTotalPrice()
        {
            List<Menu> listMenu = this.GetListMenu(BillDAL.Instance.GetMAXIDBill());

            int totalPrice = 0;

            foreach (Menu item in listMenu)
            {
                totalPrice += item.Price * item.Count;
            }

            return totalPrice;
        }
    }
}
