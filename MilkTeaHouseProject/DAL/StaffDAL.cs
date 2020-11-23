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

        public int GetStaffID(string username)
        {
            string query = "USP_GetStaffID @UserName ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (data.Rows.Count > 0)
            {
                Staff staff = new Staff(data.Rows[0]);

                return staff.ID;
            }
            return -1;
        }
        public void EditStaff(int ID, string name, byte[] image,DateTime birthDate, string pos,  int overtime, int salary)
        {
            DataProvider.Instance.ExecuteNonQuery(" USP_EditStaff @ID , @Name , @Image , @birthday , @pos , @salary , @overtime ",
                new object[] { ID, name, image,birthDate, pos, overtime, salary });
        }
        public void DelStaff(int iD)
        {
            string query = "DELETE FROM Staff WHERE ID = " + iD + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void AddStaff(string name, byte[] image,DateTime birthDate, string pos,  int salary,int overtime, string username)
        {
            string queryStaff = "SELECT MAX(ID) FROM Staff";
            int id = (int)DataProvider.Instance.ExecuteScalar(queryStaff) + 1;

            DataProvider.Instance.ExecuteNonQuery("USP_AddStaff @ID , @Name , @image , @birthday , @pos , @username , @salary , @overtime ",
                new object[] { id, name, image,birthDate, pos, username, overtime, salary });
        }
    }
}
