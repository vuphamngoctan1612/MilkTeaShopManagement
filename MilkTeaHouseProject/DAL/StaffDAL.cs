using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MilkTeaShopManagement.DAL;
using LiveCharts;

namespace MilkTeaHouseProject.DAL
{
    public class StaffDAL
    {
        private static StaffDAL instance;

        public static StaffDAL Instance 
        {
            get { if (instance == null) instance = new StaffDAL(); return instance; }
            private set => instance = value; 
        }

        private StaffDAL() { }

        public List<Staff> GetListStaff()
        {
            List<Staff> staffs = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff");

            foreach (DataRow dataRow in data.Rows)
            {
                Staff staff = new Staff(dataRow);
                staffs.Add(staff);
            }

            return staffs;
        }

        public DataRow GetStaff(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff WHERE username = '" + username + "'");

                //Staff staff = new Staff(data.Rows[0]);

            return data.Rows[0];   
        }

        public int GetStaffIDbyUsername(string username)
        {
            string query = string.Format("SELECT * FROM STAFF WHERE USERNAME = '{0}'", username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Staff staff = new Staff(data.Rows[0]);

                return staff.ID;
            }

            return -1;
        }

        public int GetMAXStaffID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM Staff");
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        public string GetNamebyUsername(string username)
        {
            string query = string.Format("SELECT * FROM STAFF WHERE USERNAME = '{0}'", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Staff staff = new Staff(data.Rows[0]);

                return staff.Name;
            }
            else
            {
                return "null";
            }
        }

        public string GetNamebyID(int id)
        {
            string query = string.Format("SELECT * FROM STAFF WHERE ID = '{0}'", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Staff staff = new Staff(data.Rows[0]);

                return staff.Name;
            }
            
            return "null";            
        }

        public void SetUsernameToNULLbyID(int id)
        {
            string query = string.Format("update Staff set USERNAME = null where id = {0}", id);

            DataProvider.Instance.ExecuteNonQuery(query);   
        }

        public void EditStaff(int ID, string name, byte[] image, DateTime birthDate, string pos, string phonenumber, string cmnd, bool sex, string address)
        {

            DataProvider.Instance.ExecuteNonQuery(" USP_EditStaffnoUsername @ID , @Name , @Image , @birthday , @pos , @phonenumber , @cmnd , @sex , @address ",
                new object[] { ID, name, image, birthDate, pos, phonenumber, cmnd, sex, address });
        }

        public void EditStaff(int ID, string name, byte[] image, DateTime birthDate, string pos, string phonenumber, string username, string cmnd, bool sex, string address)
        {

            DataProvider.Instance.ExecuteNonQuery(" USP_EditStaff @ID , @Name , @Image , @birthday , @pos , @phonenumber , @cmnd , @sex, @addres  ",
                new object[] { ID, name, image, birthDate, pos, phonenumber, username, cmnd, sex, address });
        }

        public void DelStaff(int iD)
        {
            string query = "DELETE FROM Staff WHERE ID = " + iD + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void AddStaff(string name, byte[] image, DateTime birthDate, string pos, string username, string phonenumber, string cmnd, bool sex, string address)
        {
            int id = GetMAXStaffID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaff @ID , @Name , @image , @birthday , @pos , @username , @phonenumber , @cmnd , @sex , @address ",
                new object[] { id, name, image, birthDate, pos, username, phonenumber, cmnd, sex, address });
        }

        public void AddStaff(string name, byte[] image, DateTime birthdate, string pos, string phonenumber, string cmnd, bool sex, string address)
        {
            int id = GetMAXStaffID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaffnoUsername @ID , @Name , @image , @birthday , @pos , @phonenumber , @cmnd , @sex , @adress ",
                new object[] { id, name, image, birthdate, pos, phonenumber, cmnd, sex, address });
        }

        public void UpdateOverTime(int id, int overtime)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateOverTime @ID , @OverTime ", new object[] { id, overtime });
        }

        public void UpdateFault(int id, int fault)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateFault @ID , @fault ", new object[] { id, fault });
        }

        public void UpdateSalary(string pos, int salary, int overtimesalary, int minussalary)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateSalary @position , @salary , @overtimesalary , @minussalary ",
                new object[] { pos, salary, overtimesalary, minussalary });
        }

        public void UpdateSalaryReceived(int id, int salaryreceived)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateSalaryReceived @id , @salaryreceived ",
                new object[] { id, salaryreceived });
        }

        public void ResetOverandFault()
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE Staff SET OVERTIME = 0, FAULT = 0"));
        }

        //top 5 nhan vien theo doanh thu
        public string[] GetListStaffNameByMonth(string mm, string yy)
        {
            List<string> topStaff = new List<string>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                    "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                    "WHERE MONTH(Bill.CHECKOUT) = {0} AND YEAR(Bill.CHECKOUT) = {1} " +
                    "GROUP BY Staff.ID, Staff.NAME " +
                    "ORDER BY TOTAL ASC", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    topStaff.Add(row["NAME"].ToString());
                }

                return topStaff.ToArray();
            }
            catch
            {
                return topStaff.ToArray();
            }
        }
        public string[] GetListStaffNameByYear(string yy)
        {
            List<string> topStaff = new List<string>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                    "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                    "WHERE YEAR(Bill.CHECKOUT) = {0} " +
                    "GROUP BY Staff.ID, Staff.NAME " +
                    "ORDER BY TOTAL ASC", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    topStaff.Add(row["NAME"].ToString());
                }

                return topStaff.ToArray();
            }
            catch
            {
                return topStaff.ToArray();
            }
        }

        public string[] GetListStaffIDByMonth(string mm, string yy)
        {
            List<string> topStaff = new List<string>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                    "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                    "WHERE MONTH(Bill.CHECKOUT) = {0} AND YEAR(Bill.CHECKOUT) = {1} " +
                    "GROUP BY Staff.ID, Staff.NAME " +
                    "ORDER BY TOTAL ASC", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    topStaff.Add(row["ID"].ToString());
                }

                return topStaff.ToArray();
            }
            catch
            {
                return topStaff.ToArray();
            }
        }
        public string[] GetListStaffIDByYear(string yy)
        {
            List<string> topStaff = new List<string>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                    "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                    "WHERE YEAR(Bill.CHECKOUT) = {0} " +
                    "GROUP BY Staff.ID, Staff.NAME " +
                    "ORDER BY TOTAL ASC", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    topStaff.Add(row["ID"].ToString());
                }

                return topStaff.ToArray();
            }
            catch
            {
                return topStaff.ToArray();
            }
        }

        public ChartValues<int> GetListTopStaffByMonth(string mm, string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                   "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                   "WHERE MONTH(Bill.CHECKOUT) = {0} AND YEAR(Bill.CHECKOUT) = {1} " +
                   "GROUP BY Staff.ID, Staff.NAME " +
                   "ORDER BY TOTAL ASC", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] staffsID = this.GetListStaffIDByMonth(mm, yy);
                int[] revenue = new int[staffsID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < staffsID.Length && j < numOfRows; i++)
                {
                    if (staffsID[i] == data.Rows[j]["ID"].ToString())
                    {
                        revenue[i] = int.Parse(data.Rows[j]["TOTAL"].ToString());
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
        public ChartValues<int> GetListTopStaffByYear(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT TOP 5 Staff.ID, Staff.NAME, SUM(Bill.TOTAL) AS TOTAL FROM Staff " +
                    "INNER JOIN Bill ON Staff.ID = Bill.STAFFID " +
                    "WHERE YEAR(Bill.CHECKOUT) = {0} " +
                    "GROUP BY Staff.ID, Staff.NAME " +
                    "ORDER BY TOTAL ASC", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] staffsID = this.GetListStaffIDByYear(yy);
                int[] revenue = new int[staffsID.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < staffsID.Length && j < numOfRows; i++)
                {
                    if (staffsID[i] == data.Rows[j]["ID"].ToString())
                    {
                        revenue[i] = int.Parse(data.Rows[j]["TOTAL"].ToString());
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
