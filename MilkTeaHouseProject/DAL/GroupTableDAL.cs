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
    class GroupTableDAL
    {
        private static GroupTableDAL instance;

        public static GroupTableDAL Instance
        {
            get { if (instance == null) instance = new GroupTableDAL(); return GroupTableDAL.instance; }
            private set { GroupTableDAL.instance = value; }
        }

        private GroupTableDAL() { }

        public List<GroupTable> GetListGroupTable()
        {
            List<GroupTable> groups = new List<GroupTable>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GroupTable");

            foreach (DataRow row in data.Rows)
            {
                GroupTable group = new GroupTable(row);
                groups.Add(group);
            }

            return groups;
        }

        public void AddGroupTable(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("insert into GroupTable values ( N'" + name + "')");
        }

        public void DeleteCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM GroupTable WHERE NAME = '{0}'", name));
        }

    }
}
