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
            this.flowLayoutPanelStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI.WinForms.GunaCircleButton();
            this.btnEdit = new Guna.UI.WinForms.GunaCircleButton();
            this.btnAdd = new Guna.UI.WinForms.GunaCircleButton();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pnStaff.SuspendLayout();
            this.pnBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStaff
            // 
            this.pnStaff.Controls.Add(this.flowLayoutPanelTitle);
            this.pnStaff.Controls.Add(this.flowLayoutPanelStaff);
            this.pnStaff.Controls.Add(this.pnBtn);
            this.pnStaff.Controls.Add(this.dtgvStaff);
            this.pnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaff.Location = new System.Drawing.Point(0, 0);
            this.pnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(725, 418);
            this.pnStaff.TabIndex = 0;
            // 
            // flowLayoutPanelStaff
            // 
            this.flowLayoutPanelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelStaff.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanelStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelStaff.Name = "flowLayoutPanelStaff";
            this.flowLayoutPanelStaff.Size = new System.Drawing.Size(524, 384);
            this.flowLayoutPanelStaff.TabIndex = 5;
            // 
            // pnBtn
            // 
            this.pnBtn.Controls.Add(this.btnDelete);
            this.pnBtn.Controls.Add(this.btnEdit);
            this.pnBtn.Controls.Add(this.btnAdd);
            this.pnBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnBtn.Location = new System.Drawing.Point(521, 0);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(204, 418);
            this.pnBtn.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(67)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MilkTeaHouseProject.Properties.Resources.delete_bin_32px;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(76, 255);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(51, 47);
            this.btnDelete.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(67)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::MilkTeaHouseProject.Properties.Resources.pencil_24px;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(76, 185);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(51, 47);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(67)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAdd.Location = new System.Drawing.Point(76, 115);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(51, 47);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // flowLayoutPanelTitle
            // 
            this.flowLayoutPanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTitle.Name = "flowLayoutPanelTitle";
            this.flowLayoutPanelTitle.Size = new System.Drawing.Size(524, 38);
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
            this.pnBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Panel pnBtn;
        private Guna.UI.WinForms.GunaCircleButton btnDelete;
        private Guna.UI.WinForms.GunaCircleButton btnEdit;
        private Guna.UI.WinForms.GunaCircleButton btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStaff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTitle;
    }
}