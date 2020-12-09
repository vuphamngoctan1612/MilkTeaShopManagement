using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject.DAL
{
    public partial class fExport : Form
    {
        public fExport()
        {
            InitializeComponent();
        }

        private void fExport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milkteaManagementDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.milkteaManagementDataSet.Staff);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    object misValue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                    application.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff");

                    worksheet = application.Worksheets.Add(misValue, misValue, misValue, misValue);
                    worksheet.Name = "Staff";
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
                    }    
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                        }    
                    }
                    //workbook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    workbook.SaveAs(sfd.FileName);
                    this.Close();
                }    
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
