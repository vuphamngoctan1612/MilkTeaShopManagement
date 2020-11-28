using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MilkTeaShopManagement.DAL;

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

        public Staff GetStaff(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff WHERE username = '" + username + "'");
            
            Staff staff = new Staff(data.Rows[0]);

            return staff;
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
            else
            {
                return "null";
            }
        }

        public void EditStaff(int ID, string name, byte[] image, DateTime birthDate, string pos, string phonenumber)
        {
            DataProvider.Instance.ExecuteNonQuery(" USP_EditStaff @ID , @Name , @Image , @birthday , @pos , @phonenumber ",
                new object[] { ID, name, image, birthDate, pos, phonenumber });
        }

        public void DelStaff(int iD)
        {
            string query = "DELETE FROM Staff WHERE ID = " + iD + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void AddStaff(string name, byte[] image, DateTime birthDate, string pos, string username, string phonenumber)
        {
            int id = GetMAXStaffID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaff @ID , @Name , @image , @birthday , @pos , @username , @phonenumber ",
                new object[] { id, name, image, birthDate, pos, username, phonenumber });
        }

        public void AddStaff(string name, byte[] image, DateTime birthdate, string pos, string phonenumber)
        {
            int id = GetMAXStaffID() + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaffnoUsername @ID , @Name , @image , @birthday , @pos , @phonenumber ",
                new object[] { id, name, image, birthdate, pos, phonenumber });
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
            DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE Staff SET OVERTIME = 0, FAULT = 0, SalaryReceived = Salary"));
        }
    }
}
