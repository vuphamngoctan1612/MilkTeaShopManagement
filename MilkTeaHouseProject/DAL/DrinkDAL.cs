using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement.DAL
{
    public class DrinkDAL
    {
        private static DrinkDAL instance;

        public static DrinkDAL Instance
        {
            get { if (instance == null) instance = new DrinkDAL(); return DrinkDAL.instance; }
            private set { DrinkDAL.instance = value; }
        }

        private DrinkDAL() { }

        public List<Drink> LoadDrink()
        {
            List<Drink> drinks = new List<Drink>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Drink");

            foreach(DataRow dataRow in data.Rows)
            {
                Drink drink = new Drink(dataRow);
                drinks.Add(drink);
            }

            return drinks;
        }

        public void AddDrink(int id, string Name, int Price, byte[] Image)
        {

            DataProvider.Instance.ExecuteNonQuery("USP_AddDrink @ID , @Name , @Price , @Image ",
                new object[] { id, Name, Price, Image });
        }
        public void EditDrink(int id, string name, int price, byte[] image)
        {
            DataProvider.Instance.ExecuteNonQuery(" USP_EditDrink @ID , @Name , @Price , @Image ",
                new object[] { id, name, price, image });
        }
        public void DelDrink(int id)
        {
            string query = "Delete from Drink where ID = '" + id + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
