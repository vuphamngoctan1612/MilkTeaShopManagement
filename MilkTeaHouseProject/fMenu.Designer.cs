namespace MilkTeaHouseProject
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.pnBtn = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnDelCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnStaff = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.pnBtn.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnStaff.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBtn
            // 
            this.pnBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnBtn.Controls.Add(this.pnSearch);
            this.pnBtn.Controls.Add(this.btnDelCategory);
            this.pnBtn.Controls.Add(this.btnAddCategory);
            this.pnBtn.Controls.Add(this.gunaAdvenceButton1);
            this.pnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBtn.Location = new System.Drawing.Point(0, 0);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(967, 63);
            this.pnBtn.TabIndex = 1;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(643, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(324, 63);
            this.pnSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::MilkTeaHouseProject.Properties.Resources.searchlue;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(244, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(32, 26);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AllowDrop = true;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(38, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(247, 33);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelCategory.AnimationHoverSpeed = 0.07F;
            this.btnDelCategory.AnimationSpeed = 0.03F;
            this.btnDelCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDelCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnDelCategory.BorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelCategory.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelCategory.CheckedImage")));
            this.btnDelCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelCategory.ForeColor = System.Drawing.Color.White;
            this.btnDelCategory.Image = null;
            this.btnDelCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelCategory.Location = new System.Drawing.Point(417, 14);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnDelCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelCategory.OnHoverImage = null;
            this.btnDelCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelCategory.Radius = 10;
            this.btnDelCategory.Size = new System.Drawing.Size(154, 34);
            this.btnDelCategory.TabIndex = 0;
            this.btnDelCategory.Text = "Xóa loại";
            this.btnDelCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddCategory.AnimationSpeed = 0.03F;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnAddCategory.BorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddCategory.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.CheckedImage")));
            this.btnAddCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = null;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.Location = new System.Drawing.Point(219, 14);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.Radius = 10;
            this.btnAddCategory.Size = new System.Drawing.Size(154, 34);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm loại";
            this.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(19, 14);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(154, 34);
            this.gunaAdvenceButton1.TabIndex = 0;
            this.gunaAdvenceButton1.Text = "Thêm món";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnStaff
            // 
            this.pnStaff.Controls.Add(this.panel3);
            this.pnStaff.Controls.Add(this.pnBtn);
            this.pnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaff.Location = new System.Drawing.Point(0, 0);
            this.pnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(967, 514);
            this.pnStaff.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 451);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 410);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(967, 410);
            this.flowLayoutPanelMenu.TabIndex = 2;
            this.flowLayoutPanelMenu.SizeChanged += new System.EventHandler(this.flowLayoutPanelMenu_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(729, 9);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(77, 25);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Giá bán";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(431, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(47, 25);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Loại";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(565, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên món";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbID.Location = new System.Drawing.Point(213, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(128, 25);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã sản phẩm";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 514);
            this.Controls.Add(this.pnStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMenu";
            this.Text = "MENU";
            this.pnBtn.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnStaff.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBtn;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Panel pnStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddCategory;
        private System.Windows.Forms.Label lbCategory;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelCategory;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
    }
}