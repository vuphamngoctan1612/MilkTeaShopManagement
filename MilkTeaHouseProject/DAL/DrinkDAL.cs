using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

                if (drink.Status == true)
                {
                    drinks.Add(drink);
                }
            }

            return drinks;
        }

        public List<Drink> GetListDrinkbyCategory(string category)
        {
            List<Drink> drinks = new List<Drink>();

            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM Drink WHERE Category = '{0}'", category));

            foreach (DataRow row in data.Rows)
            {
                Drink drink = new Drink(row);
                if (drink.Status == true)
                {
                    drinks.Add(drink);
                }
            }

            return drinks;
        }

        public int GetMAXDrinkID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM Drink");
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }
        public void AddDrink(string Name, int Price, string Category, byte[] Image)
        {
            int id = GetMAXDrinkID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddDrink @ID , @Name , @Price , @Category , @Image ",
                new object[] { id, Name, Price, Category, Image });
        }

        public void EditDrink(int id, string name, int price, string category, byte[] image)
        { 
            DataProvider.Instance.ExecuteNonQuery("USP_EditDrink @ID , @Name , @Price , @Category , @Image ",
                new object[] { id, name, price, category, image });
        }

        public void DelDrink(int id)
        {
            string query = string.Format("UPDATE Drink SET STATUS = 0 WHERE ID = {0}", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
