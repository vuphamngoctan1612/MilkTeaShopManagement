namespace MilkTeaShopManagement
{
    partial class fLogin
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lbCaption);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Controls.Add(this.txtPassWord);
            this.pnLogin.Controls.Add(this.txtUserName);
            this.pnLogin.Controls.Add(this.lbUsername);
            this.pnLogin.Location = new System.Drawing.Point(12, 12);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(579, 413);
            this.pnLogin.TabIndex = 1;
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.Location = new System.Drawing.Point(70, 33);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(416, 29);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "Đăng nhập vào phần mềm Quản Lý";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(144, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(287, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(139, 230);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(101, 25);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPassWord.Location = new System.Drawing.Point(144, 274);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(287, 22);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUserName.Location = new System.Drawing.Point(144, 169);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(287, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(139, 117);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(158, 25);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Tên đăng nhập";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 437);
            this.Controls.Add(this.pnLogin);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbCaption;
    }
}

