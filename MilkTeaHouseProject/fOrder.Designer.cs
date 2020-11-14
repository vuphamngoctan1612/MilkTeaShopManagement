namespace MilkTeaHouseProject
{
    partial class fOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrder));
            this.pnPay = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnShowError = new System.Windows.Forms.Panel();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDrinks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBill = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnPay.SuspendLayout();
            this.pnTotal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPay
            // 
            this.pnPay.Controls.Add(this.btnCancel);
            this.pnPay.Controls.Add(this.btnPay);
            this.pnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPay.Location = new System.Drawing.Point(0, 657);
            this.pnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPay.Name = "pnPay";
            this.pnPay.Size = new System.Drawing.Size(500, 63);
            this.pnPay.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.CheckedImage")));
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.Location = new System.Drawing.Point(251, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(249, 63);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy đơn";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPay.CheckedForeColor = System.Drawing.Color.White;
            this.btnPay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPay.CheckedImage")));
            this.btnPay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = null;
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPay.Location = new System.Drawing.Point(0, 0);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Size = new System.Drawing.Size(249, 63);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(365, 11);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(60, 23);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "0 VNĐ";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(324, 10);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(21, 25);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(214, 10);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(92, 25);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Tổng tiền";
            // 
            // pnShowError
            // 
            this.pnShowError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(178)))));
            this.pnShowError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnShowError.Location = new System.Drawing.Point(0, 578);
            this.pnShowError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnShowError.Name = "pnShowError";
            this.pnShowError.Size = new System.Drawing.Size(500, 33);
            this.pnShowError.TabIndex = 6;
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnTotal.Controls.Add(this.lbTotalPrice);
            this.pnTotal.Controls.Add(this.lbCount);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTotal.Location = new System.Drawing.Point(0, 611);
            this.pnTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(500, 46);
            this.pnTotal.TabIndex = 5;
            // 
            // flowLayoutPanelDrinks
            // 
            this.flowLayoutPanelDrinks.AutoScroll = true;
            this.flowLayoutPanelDrinks.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrinks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDrinks.Name = "flowLayoutPanelDrinks";
            this.flowLayoutPanelDrinks.Size = new System.Drawing.Size(740, 720);
            this.flowLayoutPanelDrinks.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(740, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 720);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnShowError);
            this.panel2.Controls.Add(this.pnTotal);
            this.panel2.Controls.Add(this.pnPay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(744, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 720);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.gunaLinePanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 578);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanelBill);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 511);
            this.panel5.TabIndex = 3;
            // 
            // flowLayoutPanelBill
            // 
            this.flowLayoutPanelBill.AutoScroll = true;
            this.flowLayoutPanelBill.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBill.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBill.Name = "flowLayoutPanelBill";
            this.flowLayoutPanelBill.Size = new System.Drawing.Size(500, 511);
            this.flowLayoutPanelBill.TabIndex = 1;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(500, 67);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(370, 20);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(110, 28);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Thành tiền";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(257, 20);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(83, 28);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Đơn giá";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(125, 20);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Số lượng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(32, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(44, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanelDrinks);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 720);
            this.panel1.TabIndex = 4;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fOrder";
            this.Text = "ĐẶT HÀNG";
            this.pnPay.ResumeLayout(false);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnPay;
        private System.Windows.Forms.Panel pnPay;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel pnShowError;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDrinks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBill;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}