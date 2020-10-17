namespace MilkTeaShopManagement
{
    partial class fListStaff
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
            this.lbListStaff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvListStaff = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbListStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 31);
            this.panel1.TabIndex = 3;
            // 
            // lbListStaff
            // 
            this.lbListStaff.AutoSize = true;
            this.lbListStaff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListStaff.Location = new System.Drawing.Point(3, 4);
            this.lbListStaff.Name = "lbListStaff";
            this.lbListStaff.Size = new System.Drawing.Size(189, 24);
            this.lbListStaff.TabIndex = 0;
            this.lbListStaff.Text = "Danh Sách Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtgvListStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 506);
            this.panel2.TabIndex = 0;
            // 
            // dtgvListStaff
            // 
            this.dtgvListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListStaff.Location = new System.Drawing.Point(0, 0);
            this.dtgvListStaff.Name = "dtgvListStaff";
            this.dtgvListStaff.RowHeadersWidth = 51;
            this.dtgvListStaff.RowTemplate.Height = 24;
            this.dtgvListStaff.Size = new System.Drawing.Size(936, 506);
            this.dtgvListStaff.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 110);
            this.panel3.TabIndex = 1;
            // 
            // fListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fListStaff";
            this.Text = "fListStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbListStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvListStaff;
        private System.Windows.Forms.Panel panel3;
    }
}