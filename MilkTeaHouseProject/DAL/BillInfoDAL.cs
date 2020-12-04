using LiveCharts;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance 
        {
            get { if (instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            set => instance = value; 
        }

        private BillInfoDAL() { }

        public List<BillInfo> GetListBillInfoByIDBill(int idBill)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE BillID = " + idBill);

            foreach (DataRow item in data.Rows)
            {
                BillInfo bill = new BillInfo(item);
                listBillInfo.Add(bill);
            }

            return listBillInfo;
        }


        //fix
        public void InsertBillInfo(int idBill, int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idDrink , @count", new object[] { idBill, idDrink, count });
        }

        public void UpdateBillInfo(int idDrink, int idbill, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("update BillInfo set Count = " + count + " where DrinkID = '" + idDrink + "' and BILLID = " + idbill);
        }

        public void DeleteBillInfobyIDBill(int idBill)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_DeleteBillInfo @BillID ", new object[] { idBill });
        }

        public void DeleteBillInfobyIDDrink(int iddrink, int billid)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("Delete from BillInfo where drinkid = {0} and billid = {1}", iddrink , billid));
        }

        public void SetnullDrinkIdBillInfo(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SetnullDrinkIDinBillInfo @drinkID ",
                new object[] { id });
        }

        public int GetCountbyDrinkBillID(int idbill, int iddrink)
        {
            string query = string.Format("select * from BillInfo where DrinkID = {0} and BillID = {1}", iddrink, idbill);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                BillInfo item = new BillInfo(dr);

                return item.Count;
            }
            else
            {
                return 0;
            }
        }

        //Top món ăn bán chạy
        public string[] GetListDrinkName()
        {
            List<string> drinks = new List<string>();
            try
            {
                string query = string.Format("SELECT * FROM DRINK");
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    drinks.Add(row["NAME"].ToString());
                }

                return drinks.ToArray();
            }
            catch
            {
                return drinks.ToArray();
            }
        }
        public string[] GetListDrinkIDByMonth(string mm, string yy)
        {
            List<string> drinks = new List<string>();
            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID FROM ((BillInfo " +
                    "INNER JOIN Drink ON BillInfo.DRINKID = Drink.ID) " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID) " +
                    "WHERE MONTH(Bill.CHECKOUT) = {0} AND YEAR(Bill.CHECKOUT) = {1} GROUP BY BillInfo.DRINKID", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    drinks.Add(row["ID"].ToString());
                }

                return drinks.ToArray();
            }
            catch
            {
                return drinks.ToArray();
            }
        }
        public string[] GetListDrinkIDByYear(string yy)
        {
            List<string> drinks = new List<string>();
            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID FROM ((BillInfo " +
                    "INNER JOIN Drink ON BillInfo.DRINKID = Drink.ID) " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID) " +
                    "WHERE YEAR(Bill.CHECKOUT) = {0} GROUP BY BillInfo.DRINKID", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    drinks.Add(row["ID"].ToString());
                }

                return drinks.ToArray();
            }
            catch
            {
                return drinks.ToArray();
            }
        }
        //theo số lượng
        public ChartValues<int> GetCountDrinkByMonth(string mm, string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID, SUM(COUNT) AS COUNT FROM BillInfo " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID " +
                    "WHERE MONTH(CHECKOUT) = {0}  AND YEAR(CHECKOUT) = {1} GROUP BY BillInfo.DRINKID", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] drinksID = this.GetListDrinkIDByMonth(mm, yy);
                int[] count = new int[drinksID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < drinksID.Length && j < numOfRows; i++)
                {
                    if (drinksID[i] == data.Rows[j]["ID"].ToString())
                    {
                        count[i] = int.Parse(data.Rows[j]["COUNT"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<int>(count);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<int> GetCountDrinkByYear(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID, SUM(COUNT) AS COUNT FROM BillInfo " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID " +
                    "WHERE YEAR(CHECKOUT) = {0} GROUP BY BillInfo.DRINKID", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] drinksID = this.GetListDrinkIDByYear(yy);
                int[] count = new int[drinksID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < drinksID.Length && j < numOfRows; i++)
                {
                    if (drinksID[i] == data.Rows[j]["ID"].ToString())
                    {
                        count[i] = int.Parse(data.Rows[j]["COUNT"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<int>(count);
                return res;
            }
            catch
            {
                return res;
            }
        }
        //theo doanh thu
        public ChartValues<int> GetRevenueDrinkByMonth(string mm, string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID, BillInfo.COUNT * Drink.PRICE AS PRICE FROM ((BillInfo " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID)" +
                    "INNER JOIN Drink ON BillInfo.DRINKID = Drink.ID)" +
                    "WHERE MONTH(BILL.CHECKOUT) = {0} AND YEAR(Bill.CHECKOUT) = {1} GROUP BY BillInfo.DRINKID, BillInfo.COUNT* Drink.PRICE", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] drinksID = this.GetListDrinkIDByMonth(mm, yy);
                int[] revenue = new int[drinksID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < drinksID.Length && j < numOfRows; i++)
                {
                    if (drinksID[i] == data.Rows[j]["ID"].ToString())
                    {
                        revenue[i] = int.Parse(data.Rows[j]["PRICE"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<int>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<int> GetRevenueDrinkByYear(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT BillInfo.DRINKID AS ID, BillInfo.COUNT * Drink.PRICE AS PRICE FROM ((BillInfo " +
                    "INNER JOIN Bill ON BillInfo.BILLID = Bill.ID)" +
                    "INNER JOIN Drink ON BillInfo.DRINKID = Drink.ID)" +
                    "WHERE YEAR(Bill.CHECKOUT) = {0} GROUP BY BillInfo.DRINKID, BillInfo.COUNT* Drink.PRICE", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] drinksID = this.GetListDrinkIDByYear(yy);
                int[] revenue = new int[drinksID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < drinksID.Length && j < numOfRows; i++)
                {
                    if (drinksID[i] == data.Rows[j]["ID"].ToString())
                    {
                        revenue[i] = int.Parse(data.Rows[j]["PRICE"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<int>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }
    }
}
