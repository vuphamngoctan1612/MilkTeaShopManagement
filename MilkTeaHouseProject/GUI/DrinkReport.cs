using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using MilkTeaHouseProject.DAL;

namespace MilkTeaHouseProject
{
    public partial class DrinksReport : UserControl
    {
        public DrinksReport()
        {
            InitializeComponent();
        }

        #region Method
        //theo doanh số
        private void LoadRowsChartRevenueByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = BillInfoDAL.Instance.GetRevenueDrinkByMonth(month, year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Doanh Thu",
              
                LabelFormatter = value => value.ToString("N"),

            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Tên Món",
                Labels = BillInfoDAL.Instance.GetListRevenueDrinkNameByMonth(month, year)
            });
        }
        private void LoadRowsChartRevenueByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = BillInfoDAL.Instance.GetRevenueDrinkByYear(year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Doanh Thu",
                LabelFormatter = value => value.ToString("N"),
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Tên Món",
                Labels = BillInfoDAL.Instance.GetListRevenueDrinkNameByYear(year)
            });
        }
        //theo số lượng
        private void LoadRowChartCountByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Số Lượng",
                    Values = BillInfoDAL.Instance.GetCountDrinkByMonth(month, year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Số Lượng",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Tên Món",
                Labels = BillInfoDAL.Instance.GetListCountDrinkNameByMonth(month, year)
            });
        }
        private void LoadRowChartCountByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Số Lượng",
                    Values = BillInfoDAL.Instance.GetCountDrinkByYear(year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Số Lượng",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Tên Món",
                Labels = BillInfoDAL.Instance.GetListCountDrinkNameByYear(year)
            });
        }
        #endregion

        #region Event
        private void DrinksReport_Load(object sender, EventArgs e)
        {
            string mm = DateTime.Now.Month.ToString();
            string yy = DateTime.Now.Year.ToString();

            this.cbbCount_or_Revenue.Text = "Theo doanh số";
            this.cbbPeriod.Text = "Theo tháng";
            this.cbbTime.Text = mm;

            this.LoadRowChartCountByMonth(mm, yy);
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo doanh số
            if (this.cbbCount_or_Revenue.SelectedIndex == 0)
            {
                if (this.cbbPeriod.SelectedIndex == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowsChartRevenueByMonth(mm, yy);
                }
                //theo năm
                else if (this.cbbPeriod.SelectedIndex == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowsChartRevenueByYear(yy);
                }
            }
            else if (this.cbbCount_or_Revenue.SelectedIndex == 1)
            {
                if (this.cbbPeriod.SelectedIndex == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowChartCountByMonth(mm, yy);
                }
                //theo năm
                else if (this.cbbPeriod.SelectedIndex == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowChartCountByYear(yy);
                }
            }
        }

        private void cbbCount_or_Revenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo doanh số
            if (this.cbbCount_or_Revenue.SelectedIndex == 0)
            {
                if (this.cbbPeriod.SelectedIndex == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowsChartRevenueByMonth(mm, yy);
                }
                //theo năm
                else if (this.cbbPeriod.SelectedIndex == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowsChartRevenueByYear(yy);
                }
            }
            else if (this.cbbCount_or_Revenue.SelectedIndex == 1)
            {
                if (this.cbbPeriod.SelectedIndex == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowChartCountByMonth(mm, yy);
                }
                //theo năm
                else if (this.cbbPeriod.SelectedIndex == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowChartCountByYear(yy);
                }
            }
        }

        private void cbbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo tháng
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                this.cbbTime.Items.Clear();

                string[] monthOfYear = ReportDAL.Instance.GetMonthInYear(DateTime.Now.Year.ToString());
                for (int i = 0; i < monthOfYear.Length; i++)
                {
                    this.cbbTime.Items.Add(monthOfYear[i]);
                }
            }
            //theo năm
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                this.cbbTime.Items.Clear();

                string[] years = ReportDAL.Instance.GetYear();
                for (int i = 0; i < years.Length; i++)
                {
                    this.cbbTime.Items.Add(years[i]);
                }
            }
        }
        #endregion
    }
}
