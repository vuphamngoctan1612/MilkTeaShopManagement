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

        public int GetMAXIDBillInfo()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID) from BillInfo");
            }
            catch
            {
                return 0;
            }
        }

        public void InsertBillInfo(int id, int idBill, int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @id , @idBill , @idDrink , @count", new object[] { id, idBill, idDrink, count });
        }

        public void UpdateBillInfo(int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("update BillInfo set Count = " + count + " where DrinkID = '" + idDrink + "'");
        }
    }
}
