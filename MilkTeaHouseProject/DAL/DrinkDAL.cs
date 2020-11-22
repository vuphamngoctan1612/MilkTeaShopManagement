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

        public void AddCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("insert into Category values ( N'" + name + "')");
        }
        public int getIdDrinkMax()
        {
            string query = "SELECT MAX(ID) FROM Drink";
            int id = (int)DataProvider.Instance.ExecuteScalar(query)+1;
            return id;
        }
        public void AddDrink(string Name, int Price, string Category, byte[] Image)
        { 
            string query= "SELECT MAX(ID) FROM Drink";
            int id = new int();
            if (DataProvider.Instance.ExecuteScalar(query) == null)
            {
                id = 1;
            }
            else
                id = (int)DataProvider.Instance.ExecuteScalar(query) + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddDrink @ID , @Name , @Price , @Category , @Image ",
                new object[] { id, Name, Price, Category, Image });
        }
        public void EditDrink(int id, string name, int price, string category, byte[] image)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_EditDrink @ID , @Name , @Price , @Category , @Image ",
                new object[] { id, name, price,category, image });
        }
        public void DelDrink(int id)
        {
            string query = "Delete from Drink where ID = '" + id + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
