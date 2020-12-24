namespace MilkTeaHouseProject
{
    partial class fAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            this.pn = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.errorShow = new Guna.UI.WinForms.GunaLabel();
            this.txtUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtRepass = new Guna.UI.WinForms.GunaLineTextBox();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pn.Controls.Add(this.btnExit);
            this.pn.Controls.Add(this.lbNameForm);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(378, 35);
            this.pn.TabIndex = 48;
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
            this.btnExit.Location = new System.Drawing.Point(336, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(42, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(8, 5);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(83, 23);
            this.lbNameForm.TabIndex = 1;
            this.lbNameForm.Text = "Tài khoản";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPass.Location = new System.Drawing.Point(52, 150);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(91, 25);
            this.lbPass.TabIndex = 55;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUser.Location = new System.Drawing.Point(52, 74);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(141, 25);
            this.lbUser.TabIndex = 56;
            this.lbUser.Text = "Tên đăng nhập:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(52, 227);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(170, 25);
            this.lbName.TabIndex = 45;
            this.lbName.Text = "Nhập lại mật khẩu:";
            // 
            // btnReturn
            // 
            this.btnReturn.AnimationHoverSpeed = 0.07F;
            this.btnReturn.AnimationSpeed = 0.03F;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnReturn.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReturn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedForeColor = System.Drawing.Color.White;
            this.btnReturn.CheckedImage = null;
            this.btnReturn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.FocusedColor = System.Drawing.Color.Empty;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.Location = new System.Drawing.Point(202, 322);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(120, 35);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(55, 322);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Đổi";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorShow
            // 
            this.errorShow.AutoSize = true;
            this.errorShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorShow.ForeColor = System.Drawing.Color.Red;
            this.errorShow.Location = new System.Drawing.Point(68, 365);
            this.errorShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorShow.Name = "errorShow";
            this.errorShow.Size = new System.Drawing.Size(86, 20);
            this.errorShow.TabIndex = 100000;
            this.errorShow.Text = "gunaLabel2";
            this.errorShow.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.LineColor = System.Drawing.Color.Gainsboro;
            this.txtUser.LineSize = 2;
            this.txtUser.Location = new System.Drawing.Point(57, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(265, 30);
            this.txtUser.TabIndex = 100001;
            this.txtUser.Text = "gunaLineTextBox1";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPass.LineSize = 2;
            this.txtPass.Location = new System.Drawing.Point(57, 178);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(265, 30);
            this.txtPass.TabIndex = 100001;
            this.txtPass.Text = "gunaLineTextBox1";
            // 
            // txtRepass
            // 
            this.txtRepass.BackColor = System.Drawing.Color.White;
            this.txtRepass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRepass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRepass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtRepass.LineSize = 2;
            this.txtRepass.Location = new System.Drawing.Point(57, 258);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '\0';
            this.txtRepass.SelectedText = "";
            this.txtRepass.Size = new System.Drawing.Size(265, 30);
            this.txtRepass.TabIndex = 100001;
            this.txtRepass.Text = "gunaLineTextBox1";
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(378, 407);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.errorShow);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(378, 667);
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccount";
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbName;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaLabel errorShow;
        private Guna.UI.WinForms.GunaLineTextBox txtUser;
        private Guna.UI.WinForms.GunaLineTextBox txtPass;
        private Guna.UI.WinForms.GunaLineTextBox txtRepass;
    }
}