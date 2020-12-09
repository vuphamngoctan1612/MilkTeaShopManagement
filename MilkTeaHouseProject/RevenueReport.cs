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
        private int flag;
        
        public int Flag { get => flag; set => flag = value; }

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
        private void lbSalesMonth_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnContainSales.Controls)
            {
                item.ForeColor = Color.Black;
            }
            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            this.cbbTime.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                this.cbbTime.Items.Add(i + 1);
            }

            this.Flag = 0;  //flag == 0 => month            
        }
        private void lbSalesSeason_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnContainSales.Controls)
            {
                item.ForeColor = Color.Black;
            }
            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            this.cbbTime.Items.Clear();

            int currentYear = DateTime.Now.Year;
            this.cbbTime.Items.Add(currentYear - 2);
            this.cbbTime.Items.Add(currentYear - 1);
            this.cbbTime.Items.Add(currentYear);

            this.Flag = 1;  //flag == 0 => quarter            
        }
        private void lbSalesYear_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnContainSales.Controls)
            {
                item.ForeColor = Color.Black;
            }
            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            this.cbbTime.Items.Clear();

            int currentYear = DateTime.Now.Year;
            this.cbbTime.Items.Add(currentYear - 2);
            this.cbbTime.Items.Add(currentYear - 1);
            this.cbbTime.Items.Add(currentYear);

            this.Flag = 2;  //flag == 0 => year            
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (this.Flag == 0)
            {
                string month = this.cbbTime.Text;
                string year = DateTime.Now.Year.ToString();

                LoadChartColumnByMonth(month, year);
            }
            if (this.Flag == 1)
            {
                string year = this.cbbTime.Text;

                LoadChartColumnByQuarter(year);
            }
            if (this.Flag == 2)
            {
                string year = this.cbbTime.Text;

                LoadChartColumnByYear(year);
            }
        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            this.cbbTime.Text = month;

            LoadChartColumnByMonth(month, year);
        }
        #endregion

    }
}
