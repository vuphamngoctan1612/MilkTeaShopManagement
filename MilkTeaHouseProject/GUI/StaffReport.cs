using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MilkTeaHouseProject.DAL;

namespace MilkTeaHouseProject
{
    public partial class StaffReport : UserControl
    {
        public StaffReport()
        {
            InitializeComponent();
        }

        #region Method
        private void LoadRowChartByMonth(string month, string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = StaffDAL.Instance.GetListTopStaffByMonth(month, year)
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
                Title = "Tên",
                Labels = StaffDAL.Instance.GetListStaffNameByMonth(month, year)
            });
        }
        private void LoadRowChartByYear(string year)
        {
            this.CartesianChartReport.Series.Clear();
            this.CartesianChartReport.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Doanh Thu",
                    Values = StaffDAL.Instance.GetListTopStaffByYear(year)
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
                Title = "Tên",
                Labels = StaffDAL.Instance.GetListStaffNameByYear(year)
            });
        }
        #endregion

        #region Event
        private void StaffReport_Load(object sender, EventArgs e)
        {
            this.cbbPeriod.Text = "Theo tháng";
            this.cbbTime.Text = DateTime.Now.Month.ToString();

            string mm = DateTime.Now.Month.ToString();
            string yy = DateTime.Now.Year.ToString();

            this.LoadRowChartByMonth(mm, yy);
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbPeriod.SelectedIndex == 0)
            {

                string mm = this.cbbTime.Text;
                string yy = DateTime.Now.Year.ToString();

                LoadRowChartByMonth(mm, yy);
            }
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                string yy = this.cbbTime.Text;

                LoadRowChartByYear(yy);
            }
        }

        private void cbbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbPeriod.SelectedIndex == 0)
            {
                this.cbbTime.Items.Clear();

                string[] monthInYear = ReportDAL.Instance.GetMonthInYear(DateTime.Now.Year.ToString());
                for (int i = 0; i < monthInYear.Length; i++)
                {
                    this.cbbTime.Items.Add(monthInYear[i]);
                }
            }
            else if (this.cbbPeriod.SelectedIndex == 1)
            {
                this.cbbTime.Items.Clear();

                int currentYear = DateTime.Now.Year;
                this.cbbTime.Items.Add(currentYear - 2);
                this.cbbTime.Items.Add(currentYear - 1);
                this.cbbTime.Items.Add(currentYear);
            }
        }
        #endregion
    }
}
