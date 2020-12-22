namespace MilkTeaHouseProject
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.pnBill = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBill = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbIdStaff = new System.Windows.Forms.Label();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalSpend = new Guna.UI.WinForms.GunaLabel();
            this.lbTotalIncome = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.pnDate = new System.Windows.Forms.Panel();
            this.btnExportExcel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnMakePayment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.pnDate.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.flowLayoutPanelBill);
            this.pnBill.Controls.Add(this.panel1);
            this.pnBill.Controls.Add(this.panel2);
            this.pnBill.Controls.Add(this.pnDate);
            this.pnBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBill.Location = new System.Drawing.Point(0, 0);
            this.pnBill.Margin = new System.Windows.Forms.Padding(2);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(970, 462);
            this.pnBill.TabIndex = 1;
            // 
            // flowLayoutPanelBill
            // 
            this.flowLayoutPanelBill.AutoScroll = true;
            this.flowLayoutPanelBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelBill.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanelBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelBill.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanelBill.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelBill.Name = "flowLayoutPanelBill";
            this.flowLayoutPanelBill.Size = new System.Drawing.Size(970, 343);
            this.flowLayoutPanelBill.TabIndex = 9;
            this.flowLayoutPanelBill.SizeChanged += new System.EventHandler(this.flowLayoutPanelBill_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbNote);
            this.panel1.Controls.Add(this.lbNameStaff);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbIdStaff);
            this.panel1.Controls.Add(this.lbCheckout);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 30);
            this.panel1.TabIndex = 6;
            // 
            // lbNote
            // 
            this.lbNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(650, 4);
            this.lbNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(61, 20);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Ghi chú";
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStaff.Location = new System.Drawing.Point(398, 4);
            this.lbNameStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(105, 20);
            this.lbNameStaff.TabIndex = 0;
            this.lbNameStaff.Text = "Tên nhân viên";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(850, 4);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(105, 20);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Tổng hóa đơn";
            // 
            // lbIdStaff
            // 
            this.lbIdStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdStaff.AutoSize = true;
            this.lbIdStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdStaff.Location = new System.Drawing.Point(242, 4);
            this.lbIdStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdStaff.Name = "lbIdStaff";
            this.lbIdStaff.Size = new System.Drawing.Size(103, 20);
            this.lbIdStaff.TabIndex = 0;
            this.lbIdStaff.Text = "Mã nhân viên";
            // 
            // lbCheckout
            // 
            this.lbCheckout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.Location = new System.Drawing.Point(130, 4);
            this.lbCheckout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(73, 20);
            this.lbCheckout.TabIndex = 0;
            this.lbCheckout.Text = "Thời gian";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(10, 4);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(92, 20);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.gunaPictureBox2);
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Controls.Add(this.gunaLabel7);
            this.panel2.Controls.Add(this.lbTotalSpend);
            this.panel2.Controls.Add(this.lbTotalIncome);
            this.panel2.Controls.Add(this.gunaLabel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 52);
            this.panel2.TabIndex = 5;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::MilkTeaHouseProject.Properties.Resources.moneyout;
            this.gunaPictureBox2.Location = new System.Drawing.Point(830, 2);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(18, 17);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::MilkTeaHouseProject.Properties.Resources.moneybox;
            this.gunaPictureBox1.Location = new System.Drawing.Point(714, 2);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(18, 17);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.gunaLabel7.Location = new System.Drawing.Point(850, 2);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "Tổng chi";
            // 
            // lbTotalSpend
            // 
            this.lbTotalSpend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalSpend.AutoSize = true;
            this.lbTotalSpend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotalSpend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.lbTotalSpend.Location = new System.Drawing.Point(830, 30);
            this.lbTotalSpend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalSpend.Name = "lbTotalSpend";
            this.lbTotalSpend.Size = new System.Drawing.Size(72, 20);
            this.lbTotalSpend.TabIndex = 4;
            this.lbTotalSpend.Text = "1000000";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.lbTotalIncome.Location = new System.Drawing.Point(714, 30);
            this.lbTotalIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(72, 20);
            this.lbTotalIncome.TabIndex = 3;
            this.lbTotalIncome.Text = "1000000";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.gunaLabel12.Image = global::MilkTeaHouseProject.Properties.Resources.Money_Box_32;
            this.gunaLabel12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel12.Location = new System.Drawing.Point(734, 2);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel12.TabIndex = 0;
            this.gunaLabel12.Text = "Tổng thu";
            this.gunaLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDate
            // 
            this.pnDate.BackColor = System.Drawing.SystemColors.Control;
            this.pnDate.Controls.Add(this.btnExportExcel);
            this.pnDate.Controls.Add(this.pnSearch);
            this.pnDate.Controls.Add(this.btnMakePayment);
            this.pnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDate.Location = new System.Drawing.Point(0, 0);
            this.pnDate.Margin = new System.Windows.Forms.Padding(2);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(970, 37);
            this.pnDate.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportExcel.AnimationHoverSpeed = 0.07F;
            this.btnExportExcel.AnimationSpeed = 0.03F;
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnExportExcel.BorderColor = System.Drawing.Color.Black;
            this.btnExportExcel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExportExcel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExportExcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnExportExcel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.CheckedImage")));
            this.btnExportExcel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExportExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = null;
            this.btnExportExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExportExcel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExportExcel.Location = new System.Drawing.Point(157, 7);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnExportExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportExcel.OnHoverImage = null;
            this.btnExportExcel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExportExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportExcel.Radius = 10;
            this.btnExportExcel.Size = new System.Drawing.Size(106, 26);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Xuất file excel";
            this.btnExportExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(728, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(242, 37);
            this.pnSearch.TabIndex = 10;
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
            this.btnSearch.Image = global::MilkTeaHouseProject.Properties.Resources.searchlue1;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(182, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(24, 22);
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
            this.txtSearch.Location = new System.Drawing.Point(30, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(186, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMakePayment.AnimationHoverSpeed = 0.07F;
            this.btnMakePayment.AnimationSpeed = 0.03F;
            this.btnMakePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnMakePayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnMakePayment.BorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMakePayment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.CheckedForeColor = System.Drawing.Color.White;
            this.btnMakePayment.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMakePayment.CheckedImage")));
            this.btnMakePayment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMakePayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMakePayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.ForeColor = System.Drawing.Color.White;
            this.btnMakePayment.Image = null;
            this.btnMakePayment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMakePayment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMakePayment.Location = new System.Drawing.Point(14, 7);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnMakePayment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMakePayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMakePayment.OnHoverImage = null;
            this.btnMakePayment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMakePayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnMakePayment.Radius = 10;
            this.btnMakePayment.Size = new System.Drawing.Size(106, 26);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Lập phiếu chi";
            this.btnMakePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(970, 462);
            this.Controls.Add(this.pnBill);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fBill";
            this.Text = "HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fBill_Load);
            this.pnBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.pnDate.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Panel pnDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbIdStaff;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lbTotalSpend;
        private Guna.UI.WinForms.GunaLabel lbTotalIncome;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaAdvenceButton btnMakePayment;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnExportExcel;
    }
}