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
            this.flowLayoutPanelBill = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbIdStaff = new System.Windows.Forms.Label();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalSpend = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalIncome = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.pnDate = new System.Windows.Forms.Panel();
            this.btnMakePayment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.flowLayoutPanelBill);
            this.pnBill.Controls.Add(this.panel1);
            this.pnBill.Controls.Add(this.panel2);
            this.pnBill.Controls.Add(this.pnDate);
            this.pnBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBill.Location = new System.Drawing.Point(0, 0);
            this.pnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(1294, 555);
            this.pnBill.TabIndex = 1;
            // 
            // flowLayoutPanelBill
            // 
            this.flowLayoutPanelBill.AutoScroll = true;
            this.flowLayoutPanelBill.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelBill.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanelBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelBill.Location = new System.Drawing.Point(0, 144);
            this.flowLayoutPanelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBill.Name = "flowLayoutPanelBill";
            this.flowLayoutPanelBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBill.Size = new System.Drawing.Size(1294, 411);
            this.flowLayoutPanelBill.TabIndex = 9;
            this.flowLayoutPanelBill.SizeChanged += new System.EventHandler(this.flowLayoutPanelBill_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbNote);
            this.panel1.Controls.Add(this.lbNameStaff);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbIdStaff);
            this.panel1.Controls.Add(this.lbCheckout);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 36);
            this.panel1.TabIndex = 6;
            // 
            // lbNote
            // 
            this.lbNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(866, 5);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(77, 25);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Ghi chú";
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStaff.Location = new System.Drawing.Point(532, 5);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(130, 25);
            this.lbNameStaff.TabIndex = 0;
            this.lbNameStaff.Text = "Tên nhân viên";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(1134, 5);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(132, 25);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Tổng hóa đơn";
            // 
            // lbIdStaff
            // 
            this.lbIdStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdStaff.AutoSize = true;
            this.lbIdStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdStaff.Location = new System.Drawing.Point(324, 5);
            this.lbIdStaff.Name = "lbIdStaff";
            this.lbIdStaff.Size = new System.Drawing.Size(129, 25);
            this.lbIdStaff.TabIndex = 0;
            this.lbIdStaff.Text = "Mã nhân viên";
            // 
            // lbCheckout
            // 
            this.lbCheckout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.Location = new System.Drawing.Point(175, 5);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(92, 25);
            this.lbCheckout.TabIndex = 0;
            this.lbCheckout.Text = "Thời gian";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(15, 5);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(117, 25);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.gunaLabel7);
            this.panel2.Controls.Add(this.lbTotalSpend);
            this.panel2.Controls.Add(this.lbTotalIncome);
            this.panel2.Controls.Add(this.gunaLabel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 63);
            this.panel2.TabIndex = 5;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.Location = new System.Drawing.Point(1108, 2);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "Tổng chi";
            // 
            // lbTotalSpend
            // 
            this.lbTotalSpend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalSpend.AutoSize = true;
            this.lbTotalSpend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotalSpend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.lbTotalSpend.Location = new System.Drawing.Point(1106, 37);
            this.lbTotalSpend.Name = "lbTotalSpend";
            this.lbTotalSpend.Size = new System.Drawing.Size(89, 25);
            this.lbTotalSpend.TabIndex = 0;
            this.lbTotalSpend.Text = "1000000";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.lbTotalIncome.Location = new System.Drawing.Point(972, 37);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(89, 25);
            this.lbTotalIncome.TabIndex = 0;
            this.lbTotalIncome.Text = "1000000";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel12.Location = new System.Drawing.Point(973, 2);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(88, 25);
            this.gunaLabel12.TabIndex = 0;
            this.gunaLabel12.Text = "Tổng thu";
            // 
            // pnDate
            // 
            this.pnDate.BackColor = System.Drawing.SystemColors.Control;
            this.pnDate.Controls.Add(this.btnMakePayment);
            this.pnDate.Controls.Add(this.gunaAdvenceButton1);
            this.pnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDate.Location = new System.Drawing.Point(0, 0);
            this.pnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(1294, 45);
            this.pnDate.TabIndex = 1;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMakePayment.AnimationHoverSpeed = 0.07F;
            this.btnMakePayment.AnimationSpeed = 0.03F;
            this.btnMakePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnMakePayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnMakePayment.BorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMakePayment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.CheckedForeColor = System.Drawing.Color.White;
            this.btnMakePayment.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMakePayment.CheckedImage")));
            this.btnMakePayment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMakePayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMakePayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.ForeColor = System.Drawing.Color.White;
            this.btnMakePayment.Image = null;
            this.btnMakePayment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMakePayment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMakePayment.Location = new System.Drawing.Point(923, 6);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.btnMakePayment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMakePayment.OnHoverImage = null;
            this.btnMakePayment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMakePayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnMakePayment.Radius = 10;
            this.btnMakePayment.Size = new System.Drawing.Size(142, 30);
            this.btnMakePayment.TabIndex = 1;
            this.btnMakePayment.Text = "Lập phiếu chi";
            this.btnMakePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1110, 6);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(142, 30);
            this.gunaAdvenceButton1.TabIndex = 1;
            this.gunaAdvenceButton1.Text = "Xuất file";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 555);
            this.Controls.Add(this.pnBill);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fBill";
            this.Text = "HÓA ĐƠN";
            this.pnBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Panel pnDate;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbIdStaff;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lbTotalSpend;
        private Guna.UI.WinForms.GunaLabel lbTotalIncome;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaAdvenceButton btnMakePayment;
    }
}