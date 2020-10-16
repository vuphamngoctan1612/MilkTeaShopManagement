namespace MilkTeaShopManagement
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
            this.pnBill = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPay = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btPay = new System.Windows.Forms.Button();
            this.lbListOrder = new System.Windows.Forms.Label();
            this.pnBill.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.lvBill);
            this.pnBill.Location = new System.Drawing.Point(580, 80);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(417, 417);
            this.pnBill.TabIndex = 0;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colPrice,
            this.colTotalPrice});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(0, 0);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(417, 417);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Tên";
            this.colName.Width = 132;
            // 
            // colCount
            // 
            this.colCount.Text = "Số Lượng";
            this.colCount.Width = 88;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn Giá";
            this.colPrice.Width = 92;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Tổng";
            this.colTotalPrice.Width = 95;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // flpDrink
            // 
            this.flpDrink.AutoScroll = true;
            this.flpDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpDrink.Location = new System.Drawing.Point(0, 28);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(566, 549);
            this.flpDrink.TabIndex = 0;
            // 
            // pnPay
            // 
            this.pnPay.Controls.Add(this.btCancel);
            this.pnPay.Controls.Add(this.btPrint);
            this.pnPay.Controls.Add(this.btPay);
            this.pnPay.Location = new System.Drawing.Point(580, 503);
            this.pnPay.Name = "pnPay";
            this.pnPay.Size = new System.Drawing.Size(417, 74);
            this.pnPay.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(298, 6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(116, 56);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.SkyBlue;
            this.btPrint.FlatAppearance.BorderSize = 0;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(152, 6);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(116, 56);
            this.btPrint.TabIndex = 0;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = false;
            // 
            // btPay
            // 
            this.btPay.BackColor = System.Drawing.Color.SkyBlue;
            this.btPay.FlatAppearance.BorderSize = 0;
            this.btPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.Location = new System.Drawing.Point(3, 6);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(116, 56);
            this.btPay.TabIndex = 0;
            this.btPay.Text = "Thanh Toán";
            this.btPay.UseVisualStyleBackColor = false;
            // 
            // lbListOrder
            // 
            this.lbListOrder.AutoSize = true;
            this.lbListOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOrder.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbListOrder.Location = new System.Drawing.Point(572, 31);
            this.lbListOrder.Name = "lbListOrder";
            this.lbListOrder.Size = new System.Drawing.Size(345, 46);
            this.lbListOrder.TabIndex = 2;
            this.lbListOrder.Text = "Danh Sách Order";
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 577);
            this.Controls.Add(this.lbListOrder);
            this.Controls.Add(this.pnPay);
            this.Controls.Add(this.flpDrink);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt món";
            this.pnBill.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnPay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.Panel pnPay;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private System.Windows.Forms.Label lbListOrder;
    }
}