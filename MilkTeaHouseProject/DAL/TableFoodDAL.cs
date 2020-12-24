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
    public class TableFoodDAL
    {
        private static TableFoodDAL instance;

        public static TableFoodDAL Instance
        {
            get { if (instance == null) instance = new TableFoodDAL(); return TableFoodDAL.instance; }
            private set { TableFoodDAL.instance = value; }
        }

        private TableFoodDAL() { }

        public List<TableFood> LoadTable()
        {
            List<TableFood> tables = new List<TableFood>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood");

            foreach (DataRow dataRow in data.Rows)
            {
                TableFood table = new TableFood(dataRow);

                tables.Add(table);
            }

            return tables;
        }

        public void UpdateTable(int id)
        {
            string query = string.Format("update TableFood set status = 1 where ID = {0}", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GetMAXIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID) from TableFood");
            }
            catch
            {
                return 0;
            }
        }

        public void AddTable(string Name, string namegroup)
        {
            int id = GetMAXIDBill() + 1;

            string query = string.Format("INSERT INTO TABLEFOOD VALUES({0}, N'{1}', 0, N'{2}')", id, Name, namegroup);

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void SetStatusEmpty(int id)
        {
            string query = string.Format("update TableFood set status = 0 where ID = {0}", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void SetStatusBusy(int id)
        {
            string query = string.Format("update TableFood set status = 1 where ID = {0}", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void AddBringtoHome()
        {
            string query = string.Format("INSERT INTO TABLEFOOD VALUES(1, N'Mang về', 0, null)");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool GetStatusbyIdTable(int id)
        {
            string query = string.Format("select * from TableFood where ID = {0}", id);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            TableFood item = new TableFood(dr);

            return item.Status;
        }

        public void DeleteTable(int id)
        {
            string query = string.Format("Delete from TableFood where ID = {0}", id);

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public string GetNamebyIdTable(int id)
        {
            string query = string.Format("select * from TableFood where ID = {0}", id);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            TableFood item = new TableFood(dr);

            return item.Name;
        }

        public string GetNameGroupbyIdTable(int id)
        {
            string query = string.Format("select * from TableFood where ID = {0}", id);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            TableFood item = new TableFood(dr);

            return item.NameGroup;
        }

        public int CountTableTruebyGroupTable(string nameGroup)
        {
            string query = string.Format("select * from tablefood where nameGroup = '{0}' and Status = 1", nameGroup);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows.Count;
        }

        public DataTable GetNamesTablebyGroupTable(string nameGroup, string nameTable)
        {
            string query = string.Format("select Name from tablefood where nameGroup = '{0}' and name <> '{1}'", nameGroup, nameTable);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetIDsTablebyGroupTable(string nameGroup, string nameTable)
        {
            string query = string.Format("select ID from tablefood where nameGroup = '{0}' and name <> '{1}'", nameGroup, nameTable);

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
