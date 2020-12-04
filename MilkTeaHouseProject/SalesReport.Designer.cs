namespace MilkTeaHouseProject
{
    partial class SalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CartesianChartReport = new LiveCharts.WinForms.CartesianChart();
            this.cbbPeriod = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbbTime = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbPeriod);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.cbbTime);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 93);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CartesianChartReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 563);
            this.panel2.TabIndex = 2;
            // 
            // CartesianChartReport
            // 
            this.CartesianChartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartReport.Location = new System.Drawing.Point(0, 0);
            this.CartesianChartReport.Name = "CartesianChartReport";
            this.CartesianChartReport.Size = new System.Drawing.Size(989, 563);
            this.CartesianChartReport.TabIndex = 0;
            this.CartesianChartReport.Text = "cartesianChart1";
            // 
            // cbbPeriod
            // 
            this.cbbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cbbPeriod.BaseColor = System.Drawing.Color.White;
            this.cbbPeriod.BorderColor = System.Drawing.Color.Silver;
            this.cbbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriod.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPeriod.ForeColor = System.Drawing.Color.Black;
            this.cbbPeriod.FormattingEnabled = true;
            this.cbbPeriod.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.cbbPeriod.Location = new System.Drawing.Point(505, 50);
            this.cbbPeriod.Name = "cbbPeriod";
            this.cbbPeriod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbPeriod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbPeriod.Size = new System.Drawing.Size(210, 31);
            this.cbbPeriod.TabIndex = 3;
            this.cbbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbbPeriod_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(757, 11);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(91, 25);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Thời gian";
            // 
            // cbbTime
            // 
            this.cbbTime.BackColor = System.Drawing.Color.Transparent;
            this.cbbTime.BaseColor = System.Drawing.Color.White;
            this.cbbTime.BorderColor = System.Drawing.Color.Silver;
            this.cbbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTime.ForeColor = System.Drawing.Color.Black;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(762, 50);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTime.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTime.Size = new System.Drawing.Size(210, 31);
            this.cbbTime.TabIndex = 4;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(500, 11);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 25);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Giai đoạn";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalesReport";
            this.Size = new System.Drawing.Size(989, 656);
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.CartesianChart CartesianChartReport;
        private Guna.UI.WinForms.GunaComboBox cbbPeriod;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cbbTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
