namespace MilkTeaHouseProject
{
    partial class fInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPay = new Guna.UI.WinForms.GunaButton();
            this.txtTotalPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtChange = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCustomerPay = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalPrice = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridViewInvoices = new Guna.UI.WinForms.GunaDataGridView();
            this.lbInvoice = new Guna.UI.WinForms.GunaLabel();
            this.easyHTMLReports = new KimToo.EasyHTMLReports(this.components);
            this.btnPrintInvoice = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrintInvoice);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.txtCustomerPay);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(702, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 603);
            this.panel1.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.Location = new System.Drawing.Point(131, 501);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Size = new System.Drawing.Size(160, 42);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTotalPrice.Location = new System.Drawing.Point(241, 144);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(142, 37);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.LineColor = System.Drawing.Color.Gainsboro;
            this.txtChange.Location = new System.Drawing.Point(241, 285);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ReadOnly = true;
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(142, 34);
            this.txtChange.TabIndex = 1;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.BackColor = System.Drawing.Color.White;
            this.txtCustomerPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerPay.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCustomerPay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPay.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCustomerPay.Location = new System.Drawing.Point(241, 217);
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.PasswordChar = '\0';
            this.txtCustomerPay.SelectedText = "";
            this.txtCustomerPay.Size = new System.Drawing.Size(142, 34);
            this.txtCustomerPay.TabIndex = 1;
            this.txtCustomerPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerPay.TextChanged += new System.EventHandler(this.txtCustomerPay_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(3, 285);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(119, 28);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Tiền thối lại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(3, 217);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(173, 28);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Khách thanh toán";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(3, 142);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(110, 28);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Tổng cộng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridViewInvoices);
            this.panel2.Controls.Add(this.lbInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 603);
            this.panel2.TabIndex = 0;
            // 
            // DataGridViewInvoices
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInvoices.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInvoices.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInvoices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewInvoices.EnableHeadersVisualStyles = false;
            this.DataGridViewInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.Location = new System.Drawing.Point(0, 188);
            this.DataGridViewInvoices.Name = "DataGridViewInvoices";
            this.DataGridViewInvoices.RowHeadersVisible = false;
            this.DataGridViewInvoices.RowHeadersWidth = 51;
            this.DataGridViewInvoices.RowTemplate.Height = 24;
            this.DataGridViewInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInvoices.Size = new System.Drawing.Size(675, 415);
            this.DataGridViewInvoices.TabIndex = 1;
            this.DataGridViewInvoices.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInvoices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewInvoices.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewInvoices.ThemeStyle.ReadOnly = false;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInvoices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoice.Location = new System.Drawing.Point(12, 32);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(253, 41);
            this.lbInvoice.TabIndex = 0;
            this.lbInvoice.Text = "Phiếu thanh toán";
            // 
            // easyHTMLReports
            // 
            this.easyHTMLReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AnimationHoverSpeed = 0.07F;
            this.btnPrintInvoice.AnimationSpeed = 0.03F;
            this.btnPrintInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.btnPrintInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintInvoice.Image")));
            this.btnPrintInvoice.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintInvoice.Location = new System.Drawing.Point(131, 549);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrintInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.OnHoverImage = null;
            this.btnPrintInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Size = new System.Drawing.Size(160, 42);
            this.btnPrintInvoice.TabIndex = 2;
            this.btnPrintInvoice.Text = "In hóa đơn";
            this.btnPrintInvoice.Visible = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // fInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel lbInvoice;
        private Guna.UI.WinForms.GunaLabel lbTotalPrice;
        private Guna.UI.WinForms.GunaButton btnPay;
        private Guna.UI.WinForms.GunaLineTextBox txtTotalPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtChange;
        private Guna.UI.WinForms.GunaLineTextBox txtCustomerPay;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private KimToo.EasyHTMLReports easyHTMLReports;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewInvoices;
        private Guna.UI.WinForms.GunaButton btnPrintInvoice;
    }
}