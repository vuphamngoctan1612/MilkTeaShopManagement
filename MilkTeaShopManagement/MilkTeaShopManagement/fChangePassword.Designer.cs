namespace UIAdmin
{
    partial class fChangePassword
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbRePw = new System.Windows.Forms.Label();
            this.lbNewPw = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.lbRePw);
            this.panel1.Controls.Add(this.lbNewPw);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.txtNewPw);
            this.panel1.Controls.Add(this.txtRePw);
            this.panel1.Controls.Add(this.txtNameLogin);
            this.panel1.Location = new System.Drawing.Point(66, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 320);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(371, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(202, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 48);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lbRePw
            // 
            this.lbRePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbRePw.AutoSize = true;
            this.lbRePw.Location = new System.Drawing.Point(91, 160);
            this.lbRePw.Name = "lbRePw";
            this.lbRePw.Size = new System.Drawing.Size(136, 20);
            this.lbRePw.TabIndex = 6;
            this.lbRePw.Text = "Nhập lại mật khẩu";
            // 
            // lbNewPw
            // 
            this.lbNewPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNewPw.AutoSize = true;
            this.lbNewPw.Location = new System.Drawing.Point(91, 101);
            this.lbNewPw.Name = "lbNewPw";
            this.lbNewPw.Size = new System.Drawing.Size(104, 20);
            this.lbNewPw.TabIndex = 7;
            this.lbNewPw.Text = "Mật khẩu mới";
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(91, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(116, 20);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Tên đăng nhập";
            // 
            // txtNewPw
            // 
            this.txtNewPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNewPw.Location = new System.Drawing.Point(253, 98);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(346, 26);
            this.txtNewPw.TabIndex = 3;
            // 
            // txtRePw
            // 
            this.txtRePw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtRePw.Location = new System.Drawing.Point(253, 154);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.Size = new System.Drawing.Size(346, 26);
            this.txtRePw.TabIndex = 4;
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNameLogin.Location = new System.Drawing.Point(253, 39);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(346, 26);
            this.txtNameLogin.TabIndex = 5;
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePassword";
            this.Text = "fChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbRePw;
        private System.Windows.Forms.Label lbNewPw;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtRePw;
        private System.Windows.Forms.TextBox txtNameLogin;
    }
}