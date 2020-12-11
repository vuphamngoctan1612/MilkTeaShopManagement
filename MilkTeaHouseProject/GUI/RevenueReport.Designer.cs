namespace MilkTeaHouseProject
{
    partial class RevenueReport
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
            this.pnContainSales = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbbPeriod = new Guna.UI.WinForms.GunaComboBox();
            this.cbbTime = new Guna.UI.WinForms.GunaComboBox();
            this.pnSales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnContainSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartesianChartReport
            // 
            this.CartesianChartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartReport.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartReport.Name = "CartesianChartReport";
            this.CartesianChartReport.Size = new System.Drawing.Size(1050, 477);
            this.CartesianChartReport.TabIndex = 6;
            this.CartesianChartReport.Text = "cartesianChart1";
            // 
            // pnSales
            // 
            this.pnSales.BackColor = System.Drawing.Color.Transparent;
            this.pnSales.BaseColor = System.Drawing.Color.White;
            this.pnSales.Controls.Add(this.panel1);
            this.pnSales.Controls.Add(this.pnContainSales);
            this.pnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSales.Location = new System.Drawing.Point(0, 0);
            this.pnSales.Margin = new System.Windows.Forms.Padding(0);
            this.pnSales.Name = "pnSales";
            this.pnSales.Radius = 5;
            this.pnSales.ShadowColor = System.Drawing.Color.Black;
            this.pnSales.ShadowShift = 3;
            this.pnSales.Size = new System.Drawing.Size(1050, 593);
            this.pnSales.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CartesianChartReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 477);
            this.panel1.TabIndex = 7;
            // 
            // pnContainSales
            // 
            this.pnContainSales.Controls.Add(this.gunaLabel1);
            this.pnContainSales.Controls.Add(this.cbbPeriod);
            this.pnContainSales.Controls.Add(this.cbbTime);
            this.pnContainSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSales.Location = new System.Drawing.Point(0, 0);
            this.pnContainSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainSales.Name = "pnContainSales";
            this.pnContainSales.Size = new System.Drawing.Size(1050, 116);
            this.pnContainSales.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(21, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(157, 32);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "DOANH THU";
            // 
            // cbbPeriod
            // 
            this.cbbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cbbPeriod.BaseColor = System.Drawing.Color.White;
            this.cbbPeriod.BorderColor = System.Drawing.Color.Silver;
            this.cbbPeriod.BorderSize = 1;
            this.cbbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriod.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPeriod.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPeriod.ForeColor = System.Drawing.Color.Black;
            this.cbbPeriod.FormattingEnabled = true;
            this.cbbPeriod.Items.AddRange(new object[] {
            "Theo tháng",
            "Theo quý",
            "Theo năm"});
            this.cbbPeriod.Location = new System.Drawing.Point(616, 58);
            this.cbbPeriod.Name = "cbbPeriod";
            this.cbbPeriod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbPeriod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbPeriod.Size = new System.Drawing.Size(184, 32);
            this.cbbPeriod.TabIndex = 5;
            this.cbbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbbPeriod_SelectedIndexChanged);
            // 
            // cbbTime
            // 
            this.cbbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTime.BackColor = System.Drawing.Color.Transparent;
            this.cbbTime.BaseColor = System.Drawing.Color.White;
            this.cbbTime.BorderColor = System.Drawing.Color.Silver;
            this.cbbTime.BorderSize = 1;
            this.cbbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTime.ForeColor = System.Drawing.Color.Black;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(843, 58);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTime.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTime.Size = new System.Drawing.Size(184, 31);
            this.cbbTime.TabIndex = 5;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSales);
            this.Name = "RevenueReport";
            this.Size = new System.Drawing.Size(1050, 593);
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            this.pnSales.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnContainSales.ResumeLayout(false);
            this.pnContainSales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart CartesianChartReport;
        private Guna.UI.WinForms.GunaShadowPanel pnSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContainSales;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbbPeriod;
        private Guna.UI.WinForms.GunaComboBox cbbTime;
    }
}
