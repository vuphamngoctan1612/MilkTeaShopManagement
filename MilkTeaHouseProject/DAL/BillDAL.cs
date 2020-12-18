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

        public bool ExistBill()
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
                return 0;
            }
        }

        public void InsertBill(int id, int staffID, string tableid, int price)
        {
            DateTime checkin = DateTime.Now;
            string query = string.Format("insert into Bill (ID, STAFFID, NOTE, TABLEID, CHECKIN, TOTAL) values ({0}, {1}, N'Bán hàng', {2}, '{3}', {4})", id, staffID, tableid, checkin, price);
            DataProvider.Instance.ExecuteNonQuery(query);
            //DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @ID , @StaffID , @Note", new object[] { id, staffID, "Đặt món" });
        }

        public void MakeABill(int idStaff, string note, int total)
        {
            int idBill = GetMAXIDBill() + 1;
            DateTime time = DateTime.Now;

            DataProvider.Instance.ExecuteNonQuery(string.Format("INSERT INTO Bill(ID, STAFFID, CHECKOUT, STATUS, TOTAL, NOTE, CHECKIN) VALUES({0}, {1}, '{2}', 1, {3}, N'{4}', '{5}')"
                , idBill, idStaff, time, total, note, time));
        }
        // add tableID

        public void UpdateBill(int id, int price)
        {
            string query = string.Format("UPDATE BILL set Total = Total + {0} where ID = {1}",
                price, id);
            DataProvider.Instance.ExecuteNonQuery(query);
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

        public void UpdateBillSalary(string username, int totalSalary)
        {
            int id = GetMAXIDBill() + 1;
            int idStaff = StaffDAL.Instance.GetStaffIDbyUsername(username);
            DateTime time = DateTime.Now;
            string month = time.Month.ToString() + "/" + time.Year.ToString();
            string query = string.Format("INSERT INTO BILL(ID, STAFFid, CHECKOUT, STATUS, TOTAL, NOTE) VALUES({0}, {1}, '{2}', 1, {3}, N'Kết toán lương tháng {4}')",
                id, idStaff, time, totalSalary, month);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool ExistBillbyIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM Bill where ID = {0}", idBill));

            return data.Rows.Count > 0;
        }
        //add
        public bool GetStatusbyIDBill(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM Bill where ID = {0}", id));

            DataRow dr = data.Rows[0];

            DTO.Bill bill = new DTO.Bill(dr);

            return bill.Status;
        }

        public int GetBillIdbyTableID(int tableID)
        {
            string query = string.Format("select * from Bill where tableID = {0}", tableID);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                Bill item = new Bill(dr);

                return item.ID;
            }
            else
                return 0;
        }

        public void SetTableNullbyTableID(int id)
        {
            string que = "UPDATE Bill SET tableID = NULL WHERE tableID = " + id;
            DataProvider.Instance.ExecuteNonQuery(que);
        }

        public void UpdateBillnoTableID(int id, DateTime checkOut, int total, int staffID)
        {
            string query = string.Format("UPDATE BILL set StaffID = {0}, CheckOut = '{1}', Status = 1, Total = {2} where ID = {3}",
                staffID, checkOut, total, id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void PayBill(int id, int tableid)
        {
            DateTime time = DateTime.Now;

            SetTableNullbyTableID(tableid);

            string query = string.Format("UPDATE BILL set CHECKOUT = '{0}', STATUS = 1 where ID = {1}",
               time, id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void MakeBillforUpdateCountDrink(string nameDrink, int count, int total)
        {
            DateTime time = DateTime.Now;

            int id = GetMAXIDBill() + 1;

            string query = string.Format("INSERT INTO BILL(ID, CHECKOUT, STATUS, TOTAL, NOTE, CHECKIN) VALUES({0}, '{1}', 1, {2}, N'Nhập thêm {3} số lượng {4}', '{5}')",
                    id, time, total, nameDrink, count, time);

            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
