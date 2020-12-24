using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MilkTeaShopManagement.DAL;
using System.IO;

namespace MilkTeaHouseProject.DAL
{
    class PositionDAL
    {
        private static PositionDAL instance;

        public static PositionDAL Instance
        {
            get { if (instance == null) instance = new PositionDAL(); return instance; }
        }

        private PositionDAL() { }

        public List<Position> GetListPosistion()
        {
            List<Position> posistions = new List<Position>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Position");

            foreach (DataRow dataRow in data.Rows)
            {
                Position position = new Position(dataRow);
                posistions.Add(position);
            }
            return posistions;
        }

        public bool UpdateSalary(string pos, long salary, long overtimesalary, long minussalary)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery("USP_UpdateSalary @position , @salary , @overtimesalary , @minussalary ",
                   new object[] { pos, salary, overtimesalary, minussalary }) > 0;
            }
            catch
            {
                return false;
            }
        }
        public long GetSalarybyPosition(string position)
        {
            string query = string.Format("SELECT * FROM Position WHERE Name = N'{0}'", position);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Position pos = new Position(data.Rows[0]);

                return pos.Salary;
            }

            return 0;
        }
        public long GetOverTimeSalarybyPosition(string position)
        {
            string query = string.Format("SELECT * FROM Position WHERE Name = N'{0}'", position);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Position pos = new Position(data.Rows[0]);

                return pos.OverTimeSalary;
            }

            return 0;
        }
        public long GetMinusSalarybyPosition(string position)
        {
            string query = string.Format("SELECT * FROM Position WHERE Name = N'{0}'", position);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Position pos = new Position(data.Rows[0]);

                return pos.MinusSalary;
            }

            return 0;
        }
        public void AddPosition(string pos, long salary, long overtimesalary, int minussalary)
        {

            string query = string.Format("INSERT INTO Position VALUES (N'{0}',{1},{2},{3})", pos, salary, overtimesalary, minussalary);
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
