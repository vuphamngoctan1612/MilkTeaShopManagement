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
    public partial class SalesReport : UserControl
    {
        public SalesReport()
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
        private void SalesReport_Load(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            this.cbbPeriod.Text = "Tháng";
            this.cbbTime.Text = month;

            LoadChartColumnByMonth(month, year);
        }

        private void cbbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbTime.Items.Clear();
            //month
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                for (int i = 0; i < DateTime.Now.Month; i++)
                {
                    this.cbbTime.Items.Add((i + 1).ToString());
                }
            }
            else
            {
                int currentYear = DateTime.Now.Year;
                this.cbbTime.Items.Add(currentYear - 2);
                this.cbbTime.Items.Add(currentYear - 1);
                this.cbbTime.Items.Add(currentYear);
            }
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //month            
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                string month = this.cbbTime.Text;
                string year = DateTime.Now.Year.ToString();

                LoadChartColumnByMonth(month, year);
            }
            //year
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                string year = this.cbbTime.Text;

                LoadChartColumnByQuarter(year);
            }
            if (this.cbbPeriod.SelectedIndex == 2)
            {
                string year = this.cbbTime.Text;

                LoadChartColumnByYear(year);
            }
        }
        #endregion
    }
}
