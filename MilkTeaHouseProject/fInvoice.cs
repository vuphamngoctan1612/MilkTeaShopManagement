using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MilkTeaHouseProject
{
    public partial class fInvoice : Form
    {
        private string username;
        private int billID;
        private int totalPrice;
        private int staffID;

        public string Username { get => username; set => username = value; }
        public int BillID { get => billID; set => billID = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int StaffID { get => staffID; set => staffID = value; }

        public fInvoice(string username, int billID, int totalPrice, int staffID)
        {
            InitializeComponent();
            this.Username = username;
            this.BillID = billID;
            this.TotalPrice = totalPrice;
            this.StaffID = staffID;

            this.txtTotalPrice.Text = string.Format("{0:n0}", this.TotalPrice).ToString();

            LoadInvoice();
        }

        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public int ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);  
        }

        public void SeparateThousands(Guna.UI.WinForms.GunaLineTextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        void LoadInvoice()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListInvoicebyBillID @billID ", new object[] { this.BillID });

            this.DataGridViewInvoices.DataSource = data;
        }
        #endregion

        #region Event
        private void btnPay_Click(object sender, EventArgs e)
        {
            DateTime checkout = DateTime.Now;
            bool status = true;

            try
            {
                BillDAL.Instance.UpdateBill(this.BillID, checkout, status, this.TotalPrice, this.StaffID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.btnPrintInvoice_Click(sender, e);
                this.Close();
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            string staffName = StaffDAL.Instance.GetNamebyUsername(this.Username);
            DateTime checkout = DateTime.Now;

            this.easyHTMLReports.Clear();
            this.easyHTMLReports.AddString("<h1>MILKTEA HOUSE</h1>");
            this.easyHTMLReports.AddString("<p>Địa chỉ: blabla</p>");
            this.easyHTMLReports.AddString("<p>Số điện thoại: 0395033608</p>");
            this.easyHTMLReports.AddString("<h3>Hóa đơn thanh toán</h3>");
            this.easyHTMLReports.AddString(string.Format("<p>Số hóa đơn: #{0}</p>", this.BillID));
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddString(string.Format("<p>Nhân viên bán hàng: {0}</p>", staffName));
            this.easyHTMLReports.AddString(string.Format("<p>Ngày: {0}</p>", checkout));
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddLineBreak();
            this.easyHTMLReports.AddDatagridView(this.DataGridViewInvoices);
            this.easyHTMLReports.AddString("<br>");
            this.easyHTMLReports.AddString(string.Format("<h4>Tổng cộng: {0} VNĐ</h4>", string.Format("{0:n0}", this.TotalPrice)));
            this.easyHTMLReports.AddString("<br>");

            this.easyHTMLReports.ShowPrintPreviewDialog();
            this.Close();
        }

        private void txtCustomerPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SeparateThousands(this.txtCustomerPay);

                int customerPay = ConvertToNumber(this.txtCustomerPay.Text);
                int change = customerPay - this.TotalPrice;

                this.txtChange.Text = change.ToString();
            }
            catch
            {
                this.txtCustomerPay.Text = "";
            }
            if (string.IsNullOrEmpty(this.txtCustomerPay.Text))
            {
                this.txtChange.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
