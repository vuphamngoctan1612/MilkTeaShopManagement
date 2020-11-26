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
            set => BillDAL.instance = value;
        }

        private BillDAL() { }

        public List<Bill> LoadBill()
            {
            List<Bill> bills = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill");

            foreach (DataRow dataRow in data.Rows)
            { 
                Bill bill = new Bill(dataRow);

                if (bill.Status == true)
                {
                    bills.Add(bill);
                }
            }

            return bills;
        }
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
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @ID , @StaffID , @Note", new object[] { id, staffID, "Đặt món" });
        }

        public void MakeABill(int idStaff, string note, int total)
        {
            int idBill = GetMAXIDBill()+1;
            DateTime time = DateTime.Now;

            DataProvider.Instance.ExecuteNonQuery(string.Format("INSERT INTO Bill VALUES({0}, {1}, '{2}', 1, {3}, '{4}')"
                , idBill, idStaff, time, total, note));
        }

        public void UpdateBill(int id, DateTime checkOut, bool status, int total, int staffID)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateBill @ID , @StaffID , @CheckOut , @Status , @Total ",
                new object[] { id, staffID, checkOut, status, total });
        }        

        public void DeleteBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM BILL WHERE ID = {0}", id));
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
        public void UpDateStaffIDtoNULL(int ID)
        {
            string que = "UPDATE Bill SET StaffID = NULL WHERE StaffID = " + ID;
            DataProvider.Instance.ExecuteNonQuery(que);
        }
    }
}
