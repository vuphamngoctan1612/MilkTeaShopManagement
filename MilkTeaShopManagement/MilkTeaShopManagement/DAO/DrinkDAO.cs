using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static DrinkDAO Instance
        {
            get { if (instance == null) instance = new DrinkDAO(); return DrinkDAO.instance; }
            private set { DrinkDAO.instance = value; }
        }

        private DrinkDAO() { }

        public static int DrinkWidth = 90;
        public static int DrinkHeight = 90;

        public List<Drink> LoadDrinkList()
        {
            List<Drink> drinks = new List<Drink>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetDrinkList");

            foreach(DataRow dataRow in data.Rows)
            {
                Drink drink = new Drink(dataRow);
                drinks.Add(drink);
            }

            return drinks;
        }
    }
}
