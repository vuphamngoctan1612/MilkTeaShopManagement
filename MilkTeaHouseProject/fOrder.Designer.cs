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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.pnTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(648, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 640);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(440, 398);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pnTotal
            // 
            this.pnTotal.Controls.Add(this.lbUnit);
            this.pnTotal.Controls.Add(this.lbPrice);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Controls.Add(this.btnDelete);
            this.pnTotal.Controls.Add(this.btnPay);
            this.pnTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTotal.Location = new System.Drawing.Point(0, 398);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(440, 242);
            this.pnTotal.TabIndex = 0;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(370, 34);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(43, 20);
            this.lbUnit.TabIndex = 2;
            this.lbUnit.Text = "VND";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(250, 27);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(56, 28);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(73, 27);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(136, 32);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Tổng cộng:";
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(238, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(136, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Hủy đơn";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPay.CheckedForeColor = System.Drawing.Color.White;
            this.btnPay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPay.CheckedImage")));
            this.btnPay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = null;
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPay.Location = new System.Drawing.Point(75, 122);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Size = new System.Drawing.Size(136, 42);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(648, 640);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOrder";
            this.Text = "ĐẶT HÀNG";
            this.panel1.ResumeLayout(false);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotal;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbUnit;
    }
}