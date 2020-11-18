using MilkTeaShopManagement.DTO;
using MilkTeaHouseProject.DTO;
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
    public class StaffDAL
    {
        private static StaffDAL instance;
        public static StaffDAL Instance
        {
            get { if (instance == null) instance = new StaffDAL(); return StaffDAL.instance; }
            private set { StaffDAL.instance = value; }
        }
        private StaffDAL() { }
        public List<Staff> LoadStaffs()
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
        public void EditStaff(int ID, string name, DateTime birthDate, string pos, int overtime, int salary)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_EditStaff @ID , @Name , @birthday , @pos , @overtime , @salary ", new object[] { ID, name, birthDate, pos, overtime,salary });
        }
        public void DelStaff(int iD)
        {
            string query = "DELETE FROM Staff WHERE ID = " + iD +";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void AddStaff(string name, DateTime birthDate, string pos, int overtime, int salary, string username)
        {
            string queryStaff = "SELECT MAX(ID) FROM Staff";
            int id = (int)DataProvider.Instance.ExecuteScalar(queryStaff) + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaff @ID , @Name , @birthday , @pos , @username , @workingtime , @salary ",
                new object[] { id, name, birthDate, pos, username, overtime, salary });
        }
    }
}
