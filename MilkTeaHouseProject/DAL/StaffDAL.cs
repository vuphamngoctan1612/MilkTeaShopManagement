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

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Staff");

            foreach (DataRow dataRow in data.Rows)
            {
                Staff staff = new Staff(dataRow);
                staffs.Add(staff);
            }

            return staffs;
        }
        public void EditStaff(string name, string birthDate, string position, int basicSalary, int iD)
        {
            string query = "UPDATE Staff SET Name = N'" + name + "', BirthDate = '" + birthDate + "', Position = N'" + position + "', BasicSalary = " + basicSalary + ", Salary = " + basicSalary * 96 + "WHERE ID = " + iD + ";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DelStaff(int iD)
        {
            string query = "DELETE FROM Staff WHERE ID = " + iD +";";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
