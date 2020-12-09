namespace MilkTeaHouseProject
{
    partial class StaffReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CartesianChartReport = new LiveCharts.WinForms.CartesianChart();
            this.pnSales = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbTime = new Guna.UI.WinForms.GunaComboBox();
            this.pnContainSales = new System.Windows.Forms.Panel();
            this.lbSalesYear = new Guna.UI.WinForms.GunaLabel();
            this.lbSalesMonth = new Guna.UI.WinForms.GunaLabel();
            this.lbSales = new System.Windows.Forms.Label();
            this.pnSales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnContainSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartesianChartReport
            // 
            this.CartesianChartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartReport.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartReport.Name = "CartesianChartReport";
            this.CartesianChartReport.Size = new System.Drawing.Size(1005, 464);
            this.CartesianChartReport.TabIndex = 6;
            this.CartesianChartReport.Text = "cartesianChart1";
            // 
            // pnSales
            // 
            this.pnSales.BackColor = System.Drawing.Color.Transparent;
            this.pnSales.BaseColor = System.Drawing.Color.White;
            this.pnSales.Controls.Add(this.panel1);
            this.pnSales.Controls.Add(this.panel4);
            this.pnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSales.Location = new System.Drawing.Point(0, 0);
            this.pnSales.Margin = new System.Windows.Forms.Padding(0);
            this.pnSales.Name = "pnSales";
            this.pnSales.Radius = 5;
            this.pnSales.ShadowColor = System.Drawing.Color.Black;
            this.pnSales.ShadowShift = 3;
            this.pnSales.Size = new System.Drawing.Size(1005, 580);
            this.pnSales.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CartesianChartReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 464);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbTime);
            this.panel4.Controls.Add(this.pnContainSales);
            this.panel4.Controls.Add(this.lbSales);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 116);
            this.panel4.TabIndex = 5;
            // 
            // cbbTime
            // 
            this.cbbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTime.BackColor = System.Drawing.Color.Transparent;
            this.cbbTime.BaseColor = System.Drawing.Color.White;
            this.cbbTime.BorderColor = System.Drawing.Color.Silver;
            this.cbbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTime.ForeColor = System.Drawing.Color.Black;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(847, 64);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTime.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTime.Size = new System.Drawing.Size(121, 31);
            this.cbbTime.TabIndex = 5;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // pnContainSales
            // 
            this.pnContainSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainSales.Controls.Add(this.lbSalesYear);
            this.pnContainSales.Controls.Add(this.lbSalesMonth);
            this.pnContainSales.Location = new System.Drawing.Point(598, 58);
            this.pnContainSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainSales.Name = "pnContainSales";
            this.pnContainSales.Size = new System.Drawing.Size(220, 46);
            this.pnContainSales.TabIndex = 4;
            // 
            // lbSalesYear
            // 
            this.lbSalesYear.AutoSize = true;
            this.lbSalesYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalesYear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalesYear.Location = new System.Drawing.Point(128, 13);
            this.lbSalesYear.Name = "lbSalesYear";
            this.lbSalesYear.Size = new System.Drawing.Size(87, 23);
            this.lbSalesYear.TabIndex = 2;
            this.lbSalesYear.Text = "Theo năm";
            this.lbSalesYear.Click += new System.EventHandler(this.lbSalesYear_Click);
            // 
            // lbSalesMonth
            // 
            this.lbSalesMonth.AutoSize = true;
            this.lbSalesMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalesMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalesMonth.Location = new System.Drawing.Point(3, 13);
            this.lbSalesMonth.Name = "lbSalesMonth";
            this.lbSalesMonth.Size = new System.Drawing.Size(98, 23);
            this.lbSalesMonth.TabIndex = 2;
            this.lbSalesMonth.Text = "Theo tháng";
            this.lbSalesMonth.Click += new System.EventHandler(this.lbSalesMonth_Click);
            // 
            // lbSales
            // 
            this.lbSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSales.Location = new System.Drawing.Point(25, 21);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(200, 36);
            this.lbSales.TabIndex = 1;
            this.lbSales.Text = "Top 5 nhân viên ";
            // 
            // StaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnSales);
            this.Name = "StaffReport";
            this.Size = new System.Drawing.Size(1005, 580);
            this.Load += new System.EventHandler(this.StaffReport_Load);
            this.pnSales.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnContainSales.ResumeLayout(false);
            this.pnContainSales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart CartesianChartReport;
        private Guna.UI.WinForms.GunaShadowPanel pnSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaComboBox cbbTime;
        private System.Windows.Forms.Panel pnContainSales;
        private Guna.UI.WinForms.GunaLabel lbSalesYear;
        private Guna.UI.WinForms.GunaLabel lbSalesMonth;
        private System.Windows.Forms.Label lbSales;
    }
}
