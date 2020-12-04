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
    }
}
