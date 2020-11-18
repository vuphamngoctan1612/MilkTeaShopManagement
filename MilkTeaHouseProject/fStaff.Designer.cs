namespace MilkTeaHouseProject
{
    partial class fStaff
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
            this.pnStaff = new System.Windows.Forms.Panel();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pnStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStaff
            // 
            this.pnStaff.Controls.Add(this.flowLayoutPanelTitle);
            this.pnStaff.Controls.Add(this.flowLayoutPanelStaff);
            this.pnStaff.Controls.Add(this.dtgvStaff);
            this.pnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaff.Location = new System.Drawing.Point(0, 0);
            this.pnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(725, 418);
            this.pnStaff.TabIndex = 0;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.RowHeadersWidth = 62;
            this.dtgvStaff.RowTemplate.Height = 28;
            this.dtgvStaff.Size = new System.Drawing.Size(725, 418);
            this.dtgvStaff.TabIndex = 0;
            // 
            // flowLayoutPanelStaff
            // 
            this.flowLayoutPanelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelStaff.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanelStaff.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelStaff.Name = "flowLayoutPanelStaff";
            this.flowLayoutPanelStaff.Size = new System.Drawing.Size(725, 384);
            this.flowLayoutPanelStaff.TabIndex = 5;
            // 
            // flowLayoutPanelTitle
            // 
            this.flowLayoutPanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTitle.Name = "flowLayoutPanelTitle";
            this.flowLayoutPanelTitle.Size = new System.Drawing.Size(725, 38);
            this.flowLayoutPanelTitle.TabIndex = 0;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 418);
            this.Controls.Add(this.pnStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fStaff";
            this.Text = "NHÂN VIÊN";
            this.pnStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStaff;
    }
}