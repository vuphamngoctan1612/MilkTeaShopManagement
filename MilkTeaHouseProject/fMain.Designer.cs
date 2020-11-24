namespace MilkTeaHouseProject
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.lbButtonSelected = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.fpnControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStaff = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnOrder = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pnContainName = new System.Windows.Forms.Panel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbDisplay = new Guna.UI.WinForms.GunaLabel();
            this.panelBackground.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.fpnControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnContainName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.pnDesktop);
            this.panelBackground.Controls.Add(this.pnTool);
            this.panelBackground.Controls.Add(this.panelControl);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1229, 637);
            this.panelBackground.TabIndex = 0;
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(319, 101);
            this.pnDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(910, 536);
            this.pnDesktop.TabIndex = 4;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnTool.Controls.Add(this.btnExit);
            this.pnTool.Controls.Add(this.btnMinimize);
            this.pnTool.Controls.Add(this.btnZoom);
            this.pnTool.Controls.Add(this.lbButtonSelected);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnTool.Location = new System.Drawing.Point(319, 0);
            this.pnTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(910, 101);
            this.pnTool.TabIndex = 3;
            this.pnTool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedForeColor = System.Drawing.Color.White;
            this.btnExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExit.CheckedImage")));
            this.btnExit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MilkTeaHouseProject.Properties.Resources.Delete_32;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.Location = new System.Drawing.Point(866, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(44, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(767, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 37);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.Location = new System.Drawing.Point(815, 1);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(48, 37);
            this.btnZoom.TabIndex = 13;
            this.btnZoom.Text = "O";
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbButtonSelected
            // 
            this.lbButtonSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbButtonSelected.AutoSize = true;
            this.lbButtonSelected.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonSelected.ForeColor = System.Drawing.Color.White;
            this.lbButtonSelected.Location = new System.Drawing.Point(401, 35);
            this.lbButtonSelected.Name = "lbButtonSelected";
            this.lbButtonSelected.Size = new System.Drawing.Size(96, 37);
            this.lbButtonSelected.TabIndex = 9;
            this.lbButtonSelected.Text = "HOME";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(193)))), ((int)(((byte)(240)))));
            this.panelControl.Controls.Add(this.fpnControl);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.pnContainName);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(319, 637);
            this.panelControl.TabIndex = 0;
            // 
            // fpnControl
            // 
            this.fpnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.fpnControl.Controls.Add(this.btnMenu);
            this.fpnControl.Controls.Add(this.btnStaff);
            this.fpnControl.Controls.Add(this.btnBill);
            this.fpnControl.Controls.Add(this.btnAccount);
            this.fpnControl.Controls.Add(this.btnOrder);
            this.fpnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnControl.Location = new System.Drawing.Point(0, 219);
            this.fpnControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fpnControl.Name = "fpnControl";
            this.fpnControl.Size = new System.Drawing.Size(319, 418);
            this.fpnControl.TabIndex = 17;
            // 
            // btnMenu
            // 
            this.btnMenu.AnimationHoverSpeed = 0.07F;
            this.btnMenu.AnimationSpeed = 0.03F;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnMenu.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMenu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedForeColor = System.Drawing.Color.White;
            this.btnMenu.CheckedImage = null;
            this.btnMenu.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::MilkTeaHouseProject.Properties.Resources.restaurant_menu_64px;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.Location = new System.Drawing.Point(3, 2);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenu.OnHoverImage = null;
            this.btnMenu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenu.Size = new System.Drawing.Size(316, 63);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnStaff
            // 
            this.btnStaff.AnimationHoverSpeed = 0.07F;
            this.btnStaff.AnimationSpeed = 0.03F;
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnStaff.BorderColor = System.Drawing.Color.Black;
            this.btnStaff.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnStaff.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStaff.CheckedForeColor = System.Drawing.Color.White;
            this.btnStaff.CheckedImage = null;
            this.btnStaff.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::MilkTeaHouseProject.Properties.Resources.account_50px;
            this.btnStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStaff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStaff.Location = new System.Drawing.Point(3, 69);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStaff.OnHoverImage = null;
            this.btnStaff.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnStaff.Size = new System.Drawing.Size(316, 63);
            this.btnStaff.TabIndex = 13;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedForeColor = System.Drawing.Color.White;
            this.btnBill.CheckedImage = null;
            this.btnBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::MilkTeaHouseProject.Properties.Resources.pos_terminal_50px;
            this.btnBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.Location = new System.Drawing.Point(3, 136);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(316, 63);
            this.btnBill.TabIndex = 12;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedForeColor = System.Drawing.Color.White;
            this.btnAccount.CheckedImage = null;
            this.btnAccount.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::MilkTeaHouseProject.Properties.Resources.settings_64px;
            this.btnAccount.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.Location = new System.Drawing.Point(3, 203);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Size = new System.Drawing.Size(316, 63);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AnimationHoverSpeed = 0.07F;
            this.btnOrder.AnimationSpeed = 0.03F;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnOrder.BorderColor = System.Drawing.Color.Black;
            this.btnOrder.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnOrder.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnOrder.CheckedForeColor = System.Drawing.Color.White;
            this.btnOrder.CheckedImage = null;
            this.btnOrder.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::MilkTeaHouseProject.Properties.Resources.kawaii_coffee_64px;
            this.btnOrder.ImageSize = new System.Drawing.Size(40, 40);
            this.btnOrder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnOrder.Location = new System.Drawing.Point(3, 270);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOrder.OnHoverImage = null;
            this.btnOrder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnOrder.OnPressedColor = System.Drawing.Color.Black;
            this.btnOrder.Size = new System.Drawing.Size(316, 63);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Đặt món";
            this.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lbDisplay);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 117);
            this.panel1.TabIndex = 16;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(210, 80);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 24);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name";
            this.lbUserName.Visible = false;
            // 
            // pnContainName
            // 
            this.pnContainName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.pnContainName.Controls.Add(this.lbName);
            this.pnContainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainName.Location = new System.Drawing.Point(0, 0);
            this.pnContainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainName.Name = "pnContainName";
            this.pnContainName.Size = new System.Drawing.Size(319, 102);
            this.pnContainName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(63, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(188, 37);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "MilkTeaHouse";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.Color.White;
            this.lbDisplay.Location = new System.Drawing.Point(125, 47);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(58, 28);
            this.lbDisplay.TabIndex = 2;
            this.lbDisplay.Text = "Hello";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1229, 637);
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1246, 645);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBackground.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.fpnControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnContainName.ResumeLayout(false);
            this.pnContainName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel pnContainName;
        private Guna.UI.WinForms.GunaLabel lbName;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Label lbButtonSelected;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.FlowLayoutPanel fpnControl;
        private Guna.UI.WinForms.GunaAdvenceButton btnMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnStaff;
        private Guna.UI.WinForms.GunaAdvenceButton btnBill;
        private Guna.UI.WinForms.GunaAdvenceButton btnAccount;
        private Guna.UI.WinForms.GunaAdvenceButton btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUserName;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaLabel lbDisplay;
    }
}

