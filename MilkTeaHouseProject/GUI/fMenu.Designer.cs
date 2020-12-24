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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.pnBtn = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.cbSearch = new Guna.UI.WinForms.GunaComboBox();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnStaff = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbOriginPrice = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.pnBtn.Controls.Add(this.gunaAdvenceButton1);
            this.pnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBtn.Location = new System.Drawing.Point(0, 0);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(1320, 79);
            this.pnBtn.TabIndex = 1;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.cbSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(689, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(631, 79);
            this.pnSearch.TabIndex = 11;
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BaseColor = System.Drawing.Color.White;
            this.cbSearch.BorderColor = System.Drawing.Color.Silver;
            this.cbSearch.BorderSize = 1;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.Empty;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbSearch.ForeColor = System.Drawing.Color.Black;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbSearch.Location = new System.Drawing.Point(55, 32);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSearch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSearch.Size = new System.Drawing.Size(203, 37);
            this.cbSearch.TabIndex = 12;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(539, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(36, 32);
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(310, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(278, 39);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(54, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelCategory.AnimationHoverSpeed = 0.07F;
            this.btnDelCategory.AnimationSpeed = 0.03F;
            this.btnDelCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDelCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnDelCategory.BorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelCategory.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelCategory.CheckedImage")));
            this.btnDelCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelCategory.ForeColor = System.Drawing.Color.White;
            this.btnDelCategory.Image = null;
            this.btnDelCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelCategory.Location = new System.Drawing.Point(234, 18);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDelCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelCategory.OnHoverImage = null;
            this.btnDelCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelCategory.Radius = 10;
            this.btnDelCategory.Size = new System.Drawing.Size(173, 42);
            this.btnDelCategory.TabIndex = 2;
            this.btnDelCategory.Text = "Xóa loại";
            this.btnDelCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
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
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(20, 18);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(173, 42);
            this.gunaAdvenceButton1.TabIndex = 1;
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
            this.pnStaff.Margin = new System.Windows.Forms.Padding(2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(1320, 799);
            this.pnStaff.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 720);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 670);
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
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1320, 670);
            this.flowLayoutPanelMenu.TabIndex = 2;
            this.flowLayoutPanelMenu.SizeChanged += new System.EventHandler(this.flowLayoutPanelMenu_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbCount);
            this.panel1.Controls.Add(this.lbOriginPrice);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCount.Location = new System.Drawing.Point(978, 11);
            this.lbCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(103, 30);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Số lượng";
            // 
            // lbOriginPrice
            // 
            this.lbOriginPrice.AutoSize = true;
            this.lbOriginPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbOriginPrice.Location = new System.Drawing.Point(751, 11);
            this.lbOriginPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOriginPrice.Name = "lbOriginPrice";
            this.lbOriginPrice.Size = new System.Drawing.Size(87, 30);
            this.lbOriginPrice.TabIndex = 0;
            this.lbOriginPrice.Text = "Giá gốc";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(859, 11);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(88, 30);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Giá bán";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(485, 11);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(54, 30);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Loại";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(614, 11);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(99, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên món";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbID.Location = new System.Drawing.Point(240, 11);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(145, 30);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã sản phẩm";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1320, 799);
            this.Controls.Add(this.pnStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMenu";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.pnBtn.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
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
        private System.Windows.Forms.Label lbCategory;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelCategory;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbOriginPrice;
        private Guna.UI.WinForms.GunaComboBox cbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}