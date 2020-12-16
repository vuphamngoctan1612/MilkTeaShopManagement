namespace MilkTeaHouseProject
{
    partial class fAddDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddDrink));
            this.pn = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbNameDrink = new System.Windows.Forms.Label();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbCategory = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lbOriginPrice = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnAddCategory = new Guna.UI.WinForms.GunaButton();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNameDrink = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtOriginPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPrice = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCount = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCategory = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.errorShow = new Guna.UI.WinForms.GunaLabel();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pn.Controls.Add(this.btnExit);
            this.pn.Controls.Add(this.lbNameForm);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(790, 42);
            this.pn.TabIndex = 36;
            this.pn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
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
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MilkTeaHouseProject.Properties.Resources.Delete_32;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.Location = new System.Drawing.Point(740, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(50, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(10, 6);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(112, 28);
            this.lbNameForm.TabIndex = 1;
            this.lbNameForm.Text = "Thêm món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(391, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPrice.Location = new System.Drawing.Point(390, 444);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(96, 28);
            this.lbPrice.TabIndex = 34;
            this.lbPrice.Text = "Giá món:";
            // 
            // lbNameDrink
            // 
            this.lbNameDrink.AutoSize = true;
            this.lbNameDrink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameDrink.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNameDrink.Location = new System.Drawing.Point(390, 268);
            this.lbNameDrink.Name = "lbNameDrink";
            this.lbNameDrink.Size = new System.Drawing.Size(98, 28);
            this.lbNameDrink.TabIndex = 35;
            this.lbNameDrink.Text = "Tên món:";
            // 
            // btnReturn
            // 
            this.btnReturn.AnimationHoverSpeed = 0.07F;
            this.btnReturn.AnimationSpeed = 0.03F;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnReturn.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReturn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedForeColor = System.Drawing.Color.White;
            this.btnReturn.CheckedImage = null;
            this.btnReturn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.FocusedColor = System.Drawing.Color.Empty;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.Location = new System.Drawing.Point(569, 591);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(144, 42);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCategory.Location = new System.Drawing.Point(391, 184);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(56, 28);
            this.lbCategory.TabIndex = 42;
            this.lbCategory.Text = "Loại:";
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImage.Image = global::MilkTeaHouseProject.Properties.Resources.add_32px;
            this.ptbImage.Location = new System.Drawing.Point(58, 99);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(247, 231);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbImage.TabIndex = 41;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.pnImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(394, 591);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(144, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BaseColor = System.Drawing.Color.White;
            this.cbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(396, 217);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.MaxDropDownItems = 100;
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCategory.Size = new System.Drawing.Size(315, 46);
            this.cbCategory.TabIndex = 1;
            // 
            // lbOriginPrice
            // 
            this.lbOriginPrice.AutoSize = true;
            this.lbOriginPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbOriginPrice.Location = new System.Drawing.Point(391, 358);
            this.lbOriginPrice.Name = "lbOriginPrice";
            this.lbOriginPrice.Size = new System.Drawing.Size(88, 28);
            this.lbOriginPrice.TabIndex = 34;
            this.lbOriginPrice.Text = "Giá gốc:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCount.Location = new System.Drawing.Point(392, 514);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(102, 28);
            this.lbCount.TabIndex = 34;
            this.lbCount.Text = "Số lượng:";
            this.lbCount.Visible = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddCategory.AnimationSpeed = 0.03F;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BaseColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = global::MilkTeaHouseProject.Properties.Resources.add_32px;
            this.btnAddCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategory.Location = new System.Drawing.Point(728, 216);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.Radius = 10;
            this.btnAddCategory.Size = new System.Drawing.Size(42, 38);
            this.btnAddCategory.TabIndex = 54;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtID.LineColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(394, 115);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(318, 48);
            this.txtID.TabIndex = 55;
            // 
            // txtNameDrink
            // 
            this.txtNameDrink.BackColor = System.Drawing.Color.White;
            this.txtNameDrink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameDrink.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNameDrink.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNameDrink.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNameDrink.Location = new System.Drawing.Point(394, 295);
            this.txtNameDrink.Name = "txtNameDrink";
            this.txtNameDrink.PasswordChar = '\0';
            this.txtNameDrink.SelectedText = "";
            this.txtNameDrink.Size = new System.Drawing.Size(318, 48);
            this.txtNameDrink.TabIndex = 55;
            this.txtNameDrink.TextChanged += new System.EventHandler(this.txtNameDrink_TextChanged);
            // 
            // txtOriginPrice
            // 
            this.txtOriginPrice.BackColor = System.Drawing.Color.White;
            this.txtOriginPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOriginPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtOriginPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtOriginPrice.Location = new System.Drawing.Point(394, 385);
            this.txtOriginPrice.Name = "txtOriginPrice";
            this.txtOriginPrice.PasswordChar = '\0';
            this.txtOriginPrice.SelectedText = "";
            this.txtOriginPrice.Size = new System.Drawing.Size(318, 48);
            this.txtOriginPrice.TabIndex = 55;
            this.txtOriginPrice.TextChanged += new System.EventHandler(this.txtOriginPrice_TextChanged);
            this.txtOriginPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPrice.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.Location = new System.Drawing.Point(394, 470);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(318, 48);
            this.txtPrice.TabIndex = 55;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.White;
            this.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCount.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCount.Location = new System.Drawing.Point(394, 544);
            this.txtCount.Name = "txtCount";
            this.txtCount.PasswordChar = '\0';
            this.txtCount.SelectedText = "";
            this.txtCount.Size = new System.Drawing.Size(318, 48);
            this.txtCount.TabIndex = 55;
            this.txtCount.Visible = false;
            this.txtCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.White;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCategory.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCategory.Location = new System.Drawing.Point(395, 216);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(318, 48);
            this.txtCategory.TabIndex = 55;
            this.txtCategory.Visible = false;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEdit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedForeColor = System.Drawing.Color.White;
            this.btnEdit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.CheckedImage")));
            this.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.Location = new System.Drawing.Point(394, 591);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(144, 42);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errorShow
            // 
            this.errorShow.AutoSize = true;
            this.errorShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorShow.ForeColor = System.Drawing.Color.Red;
            this.errorShow.Location = new System.Drawing.Point(148, 422);
            this.errorShow.Name = "errorShow";
            this.errorShow.Size = new System.Drawing.Size(103, 25);
            this.errorShow.TabIndex = 57;
            this.errorShow.Text = "gunaLabel2";
            this.errorShow.Visible = false;
            // 
            // fAddDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 658);
            this.Controls.Add(this.errorShow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtOriginPrice);
            this.Controls.Add(this.txtNameDrink);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOriginPrice);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNameDrink);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAddDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddDrink";
            this.Load += new System.EventHandler(this.fAddDrink_Load);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbNameDrink;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private System.Windows.Forms.Label lbCategory;
        private Guna.UI.WinForms.GunaComboBox cbCategory;
        private System.Windows.Forms.Label lbOriginPrice;
        private System.Windows.Forms.Label lbCount;
        private Guna.UI.WinForms.GunaButton btnAddCategory;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private Guna.UI.WinForms.GunaLineTextBox txtNameDrink;
        private Guna.UI.WinForms.GunaLineTextBox txtOriginPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtPrice;
        private Guna.UI.WinForms.GunaLineTextBox txtCount;
        private Guna.UI.WinForms.GunaLineTextBox txtCategory;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Guna.UI.WinForms.GunaLabel errorShow;
    }
}