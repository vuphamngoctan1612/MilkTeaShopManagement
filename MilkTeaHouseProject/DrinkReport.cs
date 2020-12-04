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
using MilkTeaHouseProject.DAL;
using LiveCharts;

namespace MilkTeaHouseProject
{
    public partial class DrinkReport : UserControl
    {
        public DrinkReport()
        {
            InitializeComponent();
        }

        #region Method
        //theo số lượng
        private void LoadChartColumnCountByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Số Lượng",
                    Values = ReportDAL.Instance.GetCountDrinkByMonth(month, year)
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
                Labels = ReportDAL.Instance.GetListDrinkName()
            });
        }
        private void LoadChartColumnCountByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Số Lượng",
                    Values = ReportDAL.Instance.GetCountDrinkByYear(year)
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
                Labels = ReportDAL.Instance.GetListDrinkName()
            });
        }
        //theo doanh thu
        private void LoadChartColumnRevenueByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = ReportDAL.Instance.GetRevenueDrinkByMonth(month, year)
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
                Labels = ReportDAL.Instance.GetListDrinkName()
            });
        }
        private void LoadChartColumnRevenueByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = ReportDAL.Instance.GetRevenueDrinkByYear(year)
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
                Labels = ReportDAL.Instance.GetListDrinkName()
            });
        }
        #endregion

        #region Event
        private void DrinkReport_Load(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            LoadChartColumnCountByMonth(month, year);
        }
        #endregion
    }
}
