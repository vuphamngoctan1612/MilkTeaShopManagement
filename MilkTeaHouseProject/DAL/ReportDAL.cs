using LiveCharts;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    public class ReportDAL
    {
        private static ReportDAL instance;

        public static ReportDAL Instance
        {
            get { if (instance == null) instance = new ReportDAL(); return instance; }
            private set => instance = value;
        }

        private ReportDAL() { }

        public int GetNumberOfBillsPaid(int dd, int mm, int yy)
        {
            string query = string.Format("SELECT COUNT(*) FROM Bill " +
                "WHERE STATUS = 1 " +
                "AND DAY(CHECKOUT) = {0} " +
                "AND MONTH(CHECKOUT) = {1} " +
                "AND YEAR(CHECKOUT) = {2}", dd, mm, yy);
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                return 0;
            }
        }
        //public int GetNumberOfTablesInServed()
        //{
        //    //try
        //    //{
        //    //    return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM TableFood WHERE STATUS = 1");
        //    //}
        //    //catch
        //    //{
        //    //    return 0;
        //    //}
        //}

        //Báo cáo doanh thu
        public string[] GetDayInMonth(string mm, string yy)
        {
            List<string> daysOfMonth = new List<string>();

            try
            {
                string query = string.Format("SELECT DAY(CHECKOUT) AS DAY FROM Bill " +
                    "WHERE MONTH(CHECKOUT) = {0} AND YEAR(CHECKOUT) = {1} " +
                    "GROUP BY DAY(CHECKOUT)", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    daysOfMonth.Add(row["DAY"].ToString());
                }

                return daysOfMonth.ToArray();
            }
            catch
            {
                return daysOfMonth.ToArray();
            }
        }
        public string[] GetMonthInYear(string yy)
        {
            List<string> monthsOfYear = new List<string>();

            try
            {
                string query = string.Format("SELECT MONTH(CHECKOUT) AS MONTH FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} " +
                    "GROUP BY MONTH(CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    monthsOfYear.Add(row["MONTH"].ToString());
                }

                return monthsOfYear.ToArray();
            }
            catch
            {
                return monthsOfYear.ToArray();
            }
        }
        public string[] GetQuarterInYear(string yy)
        {
            List<string> quarterInYear = new List<string>();

            try
            {
                string query = string.Format("SELECT DATEPART(QUARTER, CHECKOUT) AS QUARTER FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} " +
                    "GROUP BY DATEPART(QUARTER, CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    quarterInYear.Add(row["QUARTER"].ToString());
                }

                return quarterInYear.ToArray();
            }
            catch
            {
                return quarterInYear.ToArray();
            }
        }

        public ChartValues<int> GetRevenueByMonth(string mm, string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT DAY(CHECKOUT) AS DAY, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE MONTH(CHECKOUT) = {0} AND YEAR(CHECKOUT) = {1}  AND TOTAL > 0 GROUP BY DAY(CHECKOUT)", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] daysOfMonth = this.GetDayInMonth(mm, yy);
                int[] revenue = new int[daysOfMonth.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < daysOfMonth.Length && j < numOfRows; i++)
                {
                    if (daysOfMonth[i] == data.Rows[j]["DAY"].ToString())
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
        public ChartValues<int> GetRevenueByYear(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT MONTH(CHECKOUT) AS MONTH, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL > 0 GROUP BY MONTH(CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] monthsOfYear = this.GetMonthInYear(yy);
                int[] revenue = new int[monthsOfYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < monthsOfYear.Length && j < numOfRows; i++)
                {
                    if (monthsOfYear[i] == data.Rows[j]["MONTH"].ToString())
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
        public ChartValues<int> GetRevenueByQuarter(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT DATEPART(QUARTER, CHECKOUT) AS QUARTER, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL > 0 " +
                    "GROUP BY DATEPART(QUARTER, CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] quarterInYear = this.GetQuarterInYear(yy);
                int[] revenue = new int[quarterInYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < quarterInYear.Length && j < numOfRows; i++)
                {
                    if (quarterInYear[i] == data.Rows[j]["QUARTER"].ToString())
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

        public ChartValues<int> GetExpenseByMonth(string mm, string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT DAY(CHECKOUT) AS DAY, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE MONTH(CHECKOUT) = {0} AND YEAR(CHECKOUT) = {1} AND TOTAL < 0 GROUP BY DAY(CHECKOUT)", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] daysOfMonth = this.GetDayInMonth(mm, yy);
                int[] expense = new int[daysOfMonth.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < daysOfMonth.Length && j < numOfRows; i++)
                {
                    if (daysOfMonth[i] == data.Rows[j]["DAY"].ToString())
                    {
                        expense[i] = Math.Abs(int.Parse(data.Rows[j]["TOTAL"].ToString()));
                        j++;
                    }
                }

                res = new ChartValues<int>(expense);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<int> GetExpenseByYear(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT MONTH(CHECKOUT) AS MONTH, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL < 0 GROUP BY MONTH(CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] monthsOfYear = this.GetMonthInYear(yy);
                int[] expense = new int[monthsOfYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < monthsOfYear.Length && j < numOfRows; i++)
                {
                    if (monthsOfYear[i] == data.Rows[j]["MONTH"].ToString())
                    {
                        expense[i] = Math.Abs(int.Parse(data.Rows[j]["TOTAL"].ToString()));
                        j++;
                    }
                }

                res = new ChartValues<int>(expense);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<int> GetExpenseByQuarter(string yy)
        {
            ChartValues<int> res = new ChartValues<int>();

            try
            {
                string query = string.Format("SELECT DATEPART(QUARTER, CHECKOUT) AS QUARTER, SUM(TOTAL) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL < 0 " +
                    "GROUP BY DATEPART(QUARTER, CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] quarterInYear = this.GetQuarterInYear(yy);
                int[] revenue = new int[quarterInYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < quarterInYear.Length && j < numOfRows; i++)
                {
                    if (quarterInYear[i] == data.Rows[j]["QUARTER"].ToString())
                    {
                        revenue[i] = Math.Abs(int.Parse(data.Rows[j]["TOTAL"].ToString()));
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