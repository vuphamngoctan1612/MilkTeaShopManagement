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
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set => BillDAL.instance = value;
        }

        private BillDAL() { }

        public int GetIDBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select ID from Bill");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public bool existBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill");

            return data.Rows.Count > 0;
        }

        public int GetMAXIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID) from Bill");
            }
            catch
            {
                return 1;
            }
        }

        public void InsertBill(int id, int staffID)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @ID , @StaffID", new object[] { id, staffID });
        }

        public void UpdateBill(int id, DateTime checkOut, bool status, int total, int staffID)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateBill @CheckOut , @Status , @Total , @ID , @StaffID ", new object[] { checkOut, status, total, id, staffID });
        }

        public void DeleteBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_DeleteBill @ID ", new object[] { id });
        }

        public int GetStaffID(int id)
        {
            try
            {
                string query = "SELECT StaffID FROM Bill WHERE ID = " + id;

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    Bill bill = new Bill(data.Rows[0]);

                    return bill.StaffID;
                }

                return -1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
