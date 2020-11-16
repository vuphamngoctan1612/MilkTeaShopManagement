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
            List<Staff> listStaff = new List<Staff>();

            string query = "select * from Staff";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                listStaff.Add(staff);
            }

            return listStaff;
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
    }
}
