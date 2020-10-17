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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(944, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(3, 4);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(58, 24);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "Order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flpDrink);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 600);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPay);
            this.panel5.Controls.Add(this.btnDel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(547, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 93);
            this.panel5.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(50, 23);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(154, 43);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(234, 23);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(154, 43);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvOrder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(547, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 505);
            this.panel4.TabIndex = 0;
            // 
            // lvOrder
            // 
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colPrice});
            this.lvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrder.GridLines = true;
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(0, 0);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(428, 505);
            this.lvOrder.TabIndex = 0;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Tên Sản Phẩm";
            this.colName.Width = 131;
            // 
            // colCount
            // 
            this.colCount.Text = "Số Lượng";
            this.colCount.Width = 82;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn Giá";
            this.colPrice.Width = 98;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(547, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 95);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Order";
            // 
            // flpDrink
            // 
            this.flpDrink.AutoScroll = true;
            this.flpDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpDrink.Location = new System.Drawing.Point(0, 0);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(547, 600);
            this.flpDrink.TabIndex = 0;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt món";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
    }
}