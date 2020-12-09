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
        private int flag;

        public int Flag { get => flag; set => flag = value; }

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
            string yy = DateTime.Now.Year.ToString();

            LoadRowChartByYear(yy);
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

            this.Flag = 1;  //flag == 1 => year      
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //theo tháng
            if (this.Flag == 0)
            {
                string mm = this.cbbTime.Text;
                string yy = DateTime.Now.Year.ToString();

                LoadRowChartByMonth(mm, yy);
            }
            //theo năm
            else if (this.Flag == 1)
            {
                string yy = this.cbbTime.Text;

                LoadRowChartByYear(yy);
            }
        }
        #endregion
    }
}
