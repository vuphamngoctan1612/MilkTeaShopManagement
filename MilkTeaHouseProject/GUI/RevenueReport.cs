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
    public partial class RevenueReport : UserControl
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        #region Method
        private void LoadChartColumnByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh Thu",
                    Values = ReportDAL.Instance.GetRevenueByMonth(month, year)
                },
                new ColumnSeries
                {
                    Title = "Chi Phí",
                    Values = ReportDAL.Instance.GetExpenseByMonth(month, year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = ReportDAL.Instance.GetDayInMonth(month, year),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Số Tiền",
                LabelFormatter = value => value.ToString("N")
            });
        }
        private void LoadChartColumnByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh Thu",
                    Values = ReportDAL.Instance.GetRevenueByYear(year)
                },
                new ColumnSeries
                {
                    Title = "Chi Phí",
                    Values = ReportDAL.Instance.GetExpenseByYear(year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = ReportDAL.Instance.GetMonthInYear(year),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Số Tiền",
                LabelFormatter = value => value.ToString("N")
            });
        }
        private void LoadChartColumnByQuarter(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh Thu",
                    Values = ReportDAL.Instance.GetRevenueByQuarter(year)
                },
                new ColumnSeries
                {
                    Title = "Chi Phí",
                    Values = ReportDAL.Instance.GetExpenseByQuarter(year)
                }
            };

            this.CartesianChartReport.AxisX.Clear();
            this.CartesianChartReport.AxisX.Add(new Axis
            {
                Title = "Quý",
                Labels = ReportDAL.Instance.GetQuarterInYear(year),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            this.CartesianChartReport.AxisY.Clear();
            this.CartesianChartReport.AxisY.Add(new Axis
            {
                Title = "Số Tiền",
                LabelFormatter = value => value.ToString("N")
            });
        }
        #endregion

        #region Event
        private void RevenueReport_Load(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            this.cbbPeriod.Text = "Theo tháng";
            this.cbbTime.Text = month;

            LoadChartColumnByMonth(month, year);
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo tháng
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                string mm = this.cbbTime.Text;
                string yy = DateTime.Now.Year.ToString();

                this.LoadChartColumnByMonth(mm, yy);
            }
            //theo quý
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                string yy = this.cbbTime.Text;

                this.LoadChartColumnByQuarter(yy);
            }
            //theo năm
            else
            {
                string yy = this.cbbTime.Text;

                this.LoadChartColumnByYear(yy);
            }
        }

        private void cbbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo tháng
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                this.cbbTime.Items.Clear();

                string[] monthInYear = ReportDAL.Instance.GetMonthInYear(DateTime.Now.Year.ToString());
                for (int i = 0; i < monthInYear.Length; i++)
                {
                    this.cbbTime.Items.Add(monthInYear[i]);
                }
            }
            //theo quý
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                this.cbbTime.Items.Clear();

                string[] years = ReportDAL.Instance.GetYear();
                for (int i = 0; i < years.Length; i++)
                {
                    this.cbbTime.Items.Add(years[i]);
                }
            }
            //theo năm
            else
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
