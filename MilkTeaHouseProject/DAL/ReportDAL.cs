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

        public string[] GetYear()
        {
            List<string> years = new List<string>();

            try
            {
                string query = string.Format("SELECT YEAR(BILL.CHECKOUT) AS YEAR FROM Bill " +
                    "GROUP BY YEAR(BILL.CHECKOUT)");
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach(DataRow row in data.Rows)
                {
                    years.Add(row["YEAR"].ToString());
                }

                return years.ToArray();
            }
            catch
            {
                return years.ToArray();
            }
        }

        public ChartValues<long> GetRevenueByMonth(string mm, string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT DAY(CHECKOUT) AS DAY, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE MONTH(CHECKOUT) = {0} AND YEAR(CHECKOUT) = {1}  AND TOTAL > 0 " +
                    "GROUP BY DAY(CHECKOUT)", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] daysOfMonth = this.GetDayInMonth(mm, yy);
                long[] revenue = new long[daysOfMonth.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < daysOfMonth.Length && j < numOfRows; i++)
                {
                    if (daysOfMonth[i] == data.Rows[j]["DAY"].ToString())
                    {
                        revenue[i] = long.Parse(data.Rows[j]["TOTAL"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<long>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<long> GetRevenueByYear(string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT MONTH(CHECKOUT) AS MONTH, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL > 0 " +
                    "GROUP BY MONTH(CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] monthsOfYear = this.GetMonthInYear(yy);
                long[] revenue = new long[monthsOfYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < monthsOfYear.Length && j < numOfRows; i++)
                {
                    if (monthsOfYear[i] == data.Rows[j]["MONTH"].ToString())
                    {
                        revenue[i] = long.Parse(data.Rows[j]["TOTAL"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<long>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<long> GetRevenueByQuarter(string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT DATEPART(QUARTER, CHECKOUT) AS QUARTER, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL > 0 " +
                    "GROUP BY DATEPART(QUARTER, CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] quarterInYear = this.GetQuarterInYear(yy);
                long[] revenue = new long[quarterInYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < quarterInYear.Length && j < numOfRows; i++)
                {
                    if (quarterInYear[i] == data.Rows[j]["QUARTER"].ToString())
                    {
                        revenue[i] = long.Parse(data.Rows[j]["TOTAL"].ToString());
                        j++;
                    }
                }

                res = new ChartValues<long>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }

        public ChartValues<long> GetExpenseByMonth(string mm, string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT DAY(CHECKOUT) AS DAY, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE MONTH(CHECKOUT) = {0} AND YEAR(CHECKOUT) = {1} AND TOTAL < 0 " +
                    "GROUP BY DAY(CHECKOUT)", mm, yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] daysOfMonth = this.GetDayInMonth(mm, yy);
                long[] expense = new long[daysOfMonth.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < daysOfMonth.Length && j < numOfRows; i++)
                {
                    if (daysOfMonth[i] == data.Rows[j]["DAY"].ToString())
                    {
                        expense[i] = Math.Abs(long.Parse(data.Rows[j]["TOTAL"].ToString()));
                        j++;
                    }
                }

                res = new ChartValues<long>(expense);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<long> GetExpenseByYear(string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT MONTH(CHECKOUT) AS MONTH, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL < 0 " +
                    "GROUP BY MONTH(CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] monthsOfYear = this.GetMonthInYear(yy);
                long[] expense = new long[monthsOfYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < monthsOfYear.Length && j < numOfRows; i++)
                {
                    if (monthsOfYear[i] == data.Rows[j]["MONTH"].ToString())
                    {
                        expense[i] = Math.Abs(long.Parse(data.Rows[j]["TOTAL"].ToString()));
                        j++;
                    }
                }

                res = new ChartValues<long>(expense);
                return res;
            }
            catch
            {
                return res;
            }
        }
        public ChartValues<long> GetExpenseByQuarter(string yy)
        {
            ChartValues<long> res = new ChartValues<long>();

            try
            {
                string query = string.Format("SELECT DATEPART(QUARTER, CHECKOUT) AS QUARTER, (CAST(SUM(TOTAL) AS bigint)) AS TOTAL FROM Bill " +
                    "WHERE YEAR(CHECKOUT) = {0} AND TOTAL < 0 " +
                    "GROUP BY DATEPART(QUARTER, CHECKOUT)", yy);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                string[] quarterInYear = this.GetQuarterInYear(yy);
                long[] revenue = new long[quarterInYear.Length];
                int numOfRows = data.Rows.Count;

                int j = 0;
                for (int i = 0; i < quarterInYear.Length && j < numOfRows; i++)
                {
                    if (quarterInYear[i] == data.Rows[j]["QUARTER"].ToString())
                    {
                        revenue[i] = Math.Abs(long.Parse(data.Rows[j]["TOTAL"].ToString()));
                        j++;
                    }
                }

                res = new ChartValues<long>(revenue);
                return res;
            }
            catch
            {
                return res;
            }
        }
    }
}