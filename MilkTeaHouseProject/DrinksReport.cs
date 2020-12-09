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
        private int flag;
        public DrinksReport()
        {
            InitializeComponent();
        }

        public int Flag { get => flag; set => flag = value; }

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
            this.cbbCount_or_Revenue.Text = "Theo doanh số";

            string mm = DateTime.Now.Month.ToString();
            string yy = DateTime.Now.Year.ToString();

            this.LoadRowChartCountByMonth(mm, yy);
        }

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

            this.Flag = 1;  //flag == 0 => month       
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo doanh số
            if (this.cbbCount_or_Revenue.SelectedIndex == 0)
            {
                //theo tháng
                if (this.Flag == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowsChartRevenueByMonth(mm, yy);
                }
                //theo năm
                if (this.Flag == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowsChartRevenueByYear(yy);
                }
            }
            //theo số lượng
            else
            {
                //theo tháng
                if (this.Flag == 0)
                {
                    string mm = this.cbbTime.Text;
                    string yy = DateTime.Now.Year.ToString();

                    this.LoadRowChartCountByMonth(mm, yy);
                }
                //theo năm
                if (this.Flag == 1)
                {
                    string yy = this.cbbTime.Text;

                    this.LoadRowChartCountByYear(yy);
                }
            }
        }
        #endregion
    }
}
