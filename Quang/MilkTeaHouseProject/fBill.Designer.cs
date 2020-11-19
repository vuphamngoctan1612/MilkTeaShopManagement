namespace MilkTeaHouseProject
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.pnBill = new System.Windows.Forms.Panel();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShow = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnDate = new System.Windows.Forms.Panel();
            this.dtpkBill = new System.Windows.Forms.DateTimePicker();
            this.dtrvBill = new System.Windows.Forms.DataGridView();
            this.pnBill.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.pnDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.pnBtn);
            this.pnBill.Controls.Add(this.pnDate);
            this.pnBill.Controls.Add(this.dtrvBill);
            this.pnBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBill.Location = new System.Drawing.Point(0, 0);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(1088, 642);
            this.pnBill.TabIndex = 0;
            // 
            // pnBtn
            // 
            this.pnBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnBtn.Controls.Add(this.btnExport);
            this.pnBtn.Controls.Add(this.btnShow);
            this.pnBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtn.Location = new System.Drawing.Point(0, 542);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(1088, 100);
            this.pnBtn.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnExport.BorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedForeColor = System.Drawing.Color.White;
            this.btnExport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExport.CheckedImage")));
            this.btnExport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = null;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExport.Location = new System.Drawing.Point(638, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Size = new System.Drawing.Size(110, 42);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "In ";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShow.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShow.CheckedForeColor = System.Drawing.Color.White;
            this.btnShow.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnShow.CheckedImage")));
            this.btnShow.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = null;
            this.btnShow.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShow.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShow.Location = new System.Drawing.Point(360, 26);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Size = new System.Drawing.Size(110, 42);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Xem";
            this.btnShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnDate
            // 
            this.pnDate.Controls.Add(this.dtpkBill);
            this.pnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDate.Location = new System.Drawing.Point(0, 0);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(1088, 39);
            this.pnDate.TabIndex = 1;
            // 
            // dtpkBill
            // 
            this.dtpkBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpkBill.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkBill.Location = new System.Drawing.Point(705, 0);
            this.dtpkBill.Name = "dtpkBill";
            this.dtpkBill.Size = new System.Drawing.Size(383, 37);
            this.dtpkBill.TabIndex = 0;
            // 
            // dtrvBill
            // 
            this.dtrvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtrvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrvBill.Location = new System.Drawing.Point(0, 0);
            this.dtrvBill.Name = "dtrvBill";
            this.dtrvBill.RowHeadersWidth = 62;
            this.dtrvBill.RowTemplate.Height = 28;
            this.dtrvBill.Size = new System.Drawing.Size(1088, 642);
            this.dtrvBill.TabIndex = 0;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 642);
            this.Controls.Add(this.pnBill);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBill";
            this.Text = "HÓA ĐƠN";
            this.pnBill.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.pnDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtrvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Panel pnDate;
        private System.Windows.Forms.DateTimePicker dtpkBill;
        private System.Windows.Forms.DataGridView dtrvBill;
        private System.Windows.Forms.Panel pnBtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnExport;
        private Guna.UI.WinForms.GunaAdvenceButton btnShow;
    }
}