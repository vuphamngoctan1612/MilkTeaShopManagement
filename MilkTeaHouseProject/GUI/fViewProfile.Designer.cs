
namespace MilkTeaHouseProject
{
    partial class fViewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViewProfile));
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pn = new System.Windows.Forms.Panel();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbPos = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.pnContain = new System.Windows.Forms.Panel();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPos = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtBirth = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtName = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnStraight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.pn.SuspendLayout();
            this.pnContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImage.Image = global::MilkTeaHouseProject.Properties.Resources.add_32px;
            this.ptbImage.Location = new System.Drawing.Point(57, 89);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(205, 193);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbImage.TabIndex = 42;
            this.ptbImage.TabStop = false;
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
            this.btnReturn.FocusedColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.Location = new System.Drawing.Point(552, 342);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(119, 34);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(16, 7);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(166, 25);
            this.lbNameForm.TabIndex = 1;
            this.lbNameForm.Text = "Thông tin cá nhân";
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
            this.btnExit.FocusedColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MilkTeaHouseProject.Properties.Resources.Delete_32;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.Location = new System.Drawing.Point(842, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(42, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pn.Controls.Add(this.lbNameForm);
            this.pn.Controls.Add(this.btnExit);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(2);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(884, 34);
            this.pn.TabIndex = 1;
            this.pn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_MouseDown);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSalary.Location = new System.Drawing.Point(380, 258);
            this.lbSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(48, 23);
            this.lbSalary.TabIndex = 13;
            this.lbSalary.Text = "SĐT:";
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPos.Location = new System.Drawing.Point(380, 207);
            this.lbPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(55, 23);
            this.lbPos.TabIndex = 13;
            this.lbPos.Text = "Vị trí:";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbBirth.Location = new System.Drawing.Point(380, 147);
            this.lbBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(94, 23);
            this.lbBirth.TabIndex = 13;
            this.lbBirth.Text = "Ngày sinh:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(380, 89);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 23);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Họ tên:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbId.Location = new System.Drawing.Point(52, 322);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 23);
            this.lbId.TabIndex = 13;
            this.lbId.Text = "ID:";
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnContain.Controls.Add(this.txtPhone);
            this.pnContain.Controls.Add(this.txtPos);
            this.pnContain.Controls.Add(this.txtBirth);
            this.pnContain.Controls.Add(this.txtID);
            this.pnContain.Controls.Add(this.txtName);
            this.pnContain.Controls.Add(this.pnStraight);
            this.pnContain.Controls.Add(this.ptbImage);
            this.pnContain.Controls.Add(this.btnReturn);
            this.pnContain.Controls.Add(this.lbSalary);
            this.pnContain.Controls.Add(this.lbPos);
            this.pnContain.Controls.Add(this.lbBirth);
            this.pnContain.Controls.Add(this.lbName);
            this.pnContain.Controls.Add(this.lbId);
            this.pnContain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Margin = new System.Windows.Forms.Padding(2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(884, 406);
            this.pnContain.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Enabled = false;
            this.txtPhone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtPhone.LineSize = 2;
            this.txtPhone.Location = new System.Drawing.Point(520, 252);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(288, 42);
            this.txtPhone.TabIndex = 44;
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.Color.White;
            this.txtPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPos.Enabled = false;
            this.txtPos.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtPos.LineSize = 2;
            this.txtPos.Location = new System.Drawing.Point(520, 198);
            this.txtPos.Margin = new System.Windows.Forms.Padding(2);
            this.txtPos.Name = "txtPos";
            this.txtPos.PasswordChar = '\0';
            this.txtPos.SelectedText = "";
            this.txtPos.Size = new System.Drawing.Size(288, 42);
            this.txtPos.TabIndex = 44;
            // 
            // txtBirth
            // 
            this.txtBirth.BackColor = System.Drawing.Color.White;
            this.txtBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirth.Enabled = false;
            this.txtBirth.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirth.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtBirth.LineSize = 2;
            this.txtBirth.Location = new System.Drawing.Point(520, 139);
            this.txtBirth.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.PasswordChar = '\0';
            this.txtBirth.SelectedText = "";
            this.txtBirth.Size = new System.Drawing.Size(288, 42);
            this.txtBirth.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtID.LineSize = 2;
            this.txtID.Location = new System.Drawing.Point(98, 315);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(62, 42);
            this.txtID.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtName.LineSize = 2;
            this.txtName.Location = new System.Drawing.Point(520, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(288, 42);
            this.txtName.TabIndex = 44;
            // 
            // pnStraight
            // 
            this.pnStraight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pnStraight.Location = new System.Drawing.Point(306, 7);
            this.pnStraight.Margin = new System.Windows.Forms.Padding(2);
            this.pnStraight.Name = "pnStraight";
            this.pnStraight.Size = new System.Drawing.Size(17, 507);
            this.pnStraight.TabIndex = 8;
            // 
            // fViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.pnContain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fViewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fViewProfile";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.pnContain.ResumeLayout(false);
            this.pnContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImage;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private System.Windows.Forms.Label lbNameForm;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnContain;
        private Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private Guna.UI.WinForms.GunaLineTextBox txtPos;
        private Guna.UI.WinForms.GunaLineTextBox txtBirth;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private Guna.UI.WinForms.GunaLineTextBox txtName;
        private System.Windows.Forms.Panel pnStraight;
    }
}