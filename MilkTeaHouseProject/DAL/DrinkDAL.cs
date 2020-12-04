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
using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;

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

        //fix
        public void AddDrink(string Name, int Price, string Category, byte[] Image, int origin, int count)
        {
            int id = GetMAXDrinkID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddDrink @ID , @Name , @Price , @Category , @Image , @Origin , @Count",
                new object[] { id, Name, Price, Category, Image, origin, count });
        }

        public void EditDrink(int id, string name, int price, string category, byte[] image, int origin, int count)
        { 
            DataProvider.Instance.ExecuteNonQuery("USP_EditDrink @ID , @Name , @Price , @Category , @Image , @Origin , @Count",
                new object[] { id, name, price, category, image, origin, count });
        }

        public void DelDrink(int id)
        {
            string query = string.Format("UPDATE Drink SET STATUS = 0 WHERE ID = {0}", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void SetnullForCategory(string category)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE DRINK " +
                "SET CATEGORY = NULL, STATUS = 0" +
                " WHERE CATEGORY = '{0}'", category));
        }

        public string getCategorybyID(int id)
        {
            return (string)DataProvider.Instance.ExecuteScalar("SELECT Category FROM Drink WHERE ID = " + id);
        }

        public void MinusCount(int billID)
        {
            List<BillInfo> billinfo = BillInfoDAL.Instance.GetListBillInfoByIDBill(billID);

            foreach (BillInfo item in billinfo)
            {
                string query = string.Format("update Drink set COUNT = COUNT - {0} where ID = {1}", item.Count, item.IdDrink);
                DataProvider.Instance.ExecuteNonQuery(query);
            }
        }

        public int GetCountbyDrinkID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM Drink where ID = {0}", id));

            DataRow dr = data.Rows[0];

            DTO.Drink item = new DTO.Drink(dr);

            return item.Count;
        }
    }
}
