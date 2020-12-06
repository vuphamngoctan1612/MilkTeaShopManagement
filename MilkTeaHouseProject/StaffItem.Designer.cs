
namespace MilkTeaHouseProject
{
    partial class StaffItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbPosition = new Guna.UI.WinForms.GunaLabel();
            this.lbUserName = new Guna.UI.WinForms.GunaLabel();
            this.lbSalary = new Guna.UI.WinForms.GunaLabel();
            this.btEdit = new Guna.UI.WinForms.GunaButton();
            this.btDel = new Guna.UI.WinForms.GunaButton();
            this.picStaff = new Guna.UI.WinForms.GunaPictureBox();
            this.numericUpDownOverTime = new Guna.UI.WinForms.GunaNumeric();
            this.numericFault = new Guna.UI.WinForms.GunaNumeric();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Phone = new Guna.UI.WinForms.GunaLabel();
            this.Address = new Guna.UI.WinForms.GunaLabel();
            this.CMND = new Guna.UI.WinForms.GunaLabel();
            this.Sex = new Guna.UI.WinForms.GunaLabel();
            this.CMNDShow = new Guna.UI.WinForms.GunaLabel();
            this.SexShow = new Guna.UI.WinForms.GunaLabel();
            this.PosShow = new Guna.UI.WinForms.GunaLabel();
            this.NameShow = new Guna.UI.WinForms.GunaLabel();
            this.BirthShow = new Guna.UI.WinForms.GunaLabel();
            this.Pos = new Guna.UI.WinForms.GunaLabel();
            this.PhoneShow = new Guna.UI.WinForms.GunaLabel();
            this.Namelb = new Guna.UI.WinForms.GunaLabel();
            this.AddressShow = new Guna.UI.WinForms.GunaLabel();
            this.BirthDate = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbID.Location = new System.Drawing.Point(232, 26);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(143, 30);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Mã nhân viên";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbName.Location = new System.Drawing.Point(454, 15);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(146, 30);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tên nhân viên";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPosition.Location = new System.Drawing.Point(856, 25);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(58, 30);
            this.lbPosition.TabIndex = 11;
            this.lbPosition.Text = "Vị trí";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbUserName.Location = new System.Drawing.Point(954, 25);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(156, 30);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbSalary.Location = new System.Drawing.Point(1407, 34);
            this.lbSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(74, 30);
            this.lbSalary.TabIndex = 14;
            this.lbSalary.Text = "Lương";
            // 
            // btEdit
            // 
            this.btEdit.AnimationHoverSpeed = 0.07F;
            this.btEdit.AnimationSpeed = 0.03F;
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btEdit.BorderColor = System.Drawing.Color.Black;
            this.btEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = global::MilkTeaHouseProject.Properties.Resources.pencil_24px;
            this.btEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btEdit.Location = new System.Drawing.Point(1550, 28);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEdit.Name = "btEdit";
            this.btEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btEdit.OnHoverImage = null;
            this.btEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btEdit.Radius = 10;
            this.btEdit.Size = new System.Drawing.Size(60, 38);
            this.btEdit.TabIndex = 15;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.AnimationHoverSpeed = 0.07F;
            this.btDel.AnimationSpeed = 0.03F;
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btDel.BorderColor = System.Drawing.Color.Black;
            this.btDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDel.FocusedColor = System.Drawing.Color.Empty;
            this.btDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = global::MilkTeaHouseProject.Properties.Resources.delete_bin_32px;
            this.btDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btDel.ImageSize = new System.Drawing.Size(20, 20);
            this.btDel.Location = new System.Drawing.Point(1618, 28);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDel.Name = "btDel";
            this.btDel.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btDel.OnHoverImage = null;
            this.btDel.OnPressedColor = System.Drawing.Color.Black;
            this.btDel.Radius = 10;
            this.btDel.Size = new System.Drawing.Size(60, 38);
            this.btDel.TabIndex = 16;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // picStaff
            // 
            this.picStaff.BaseColor = System.Drawing.Color.White;
            this.picStaff.Enabled = false;
            this.picStaff.Location = new System.Drawing.Point(19, 5);
            this.picStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(68, 61);
            this.picStaff.TabIndex = 17;
            this.picStaff.TabStop = false;
            // 
            // numericUpDownOverTime
            // 
            this.numericUpDownOverTime.BaseColor = System.Drawing.Color.White;
            this.numericUpDownOverTime.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDownOverTime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numericUpDownOverTime.ButtonForeColor = System.Drawing.Color.White;
            this.numericUpDownOverTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOverTime.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownOverTime.Location = new System.Drawing.Point(1147, 26);
            this.numericUpDownOverTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownOverTime.Maximum = ((long)(9999999));
            this.numericUpDownOverTime.Minimum = ((long)(0));
            this.numericUpDownOverTime.Name = "numericUpDownOverTime";
            this.numericUpDownOverTime.Size = new System.Drawing.Size(88, 30);
            this.numericUpDownOverTime.TabIndex = 18;
            this.numericUpDownOverTime.Text = "gunaNumeric1";
            this.numericUpDownOverTime.Value = ((long)(0));
            this.numericUpDownOverTime.ValueChanged += new System.EventHandler(this.numericUpDownOverTime_ValueChanged);
            // 
            // numericFault
            // 
            this.numericFault.BaseColor = System.Drawing.Color.White;
            this.numericFault.BorderColor = System.Drawing.Color.Silver;
            this.numericFault.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numericFault.ButtonForeColor = System.Drawing.Color.White;
            this.numericFault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFault.ForeColor = System.Drawing.Color.Black;
            this.numericFault.Location = new System.Drawing.Point(1272, 25);
            this.numericFault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericFault.Maximum = ((long)(9999999));
            this.numericFault.Minimum = ((long)(0));
            this.numericFault.Name = "numericFault";
            this.numericFault.Size = new System.Drawing.Size(88, 30);
            this.numericFault.TabIndex = 19;
            this.numericFault.Value = ((long)(0));
            this.numericFault.ValueChanged += new System.EventHandler(this.numericFault_ValueChanged);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaSeparator1.Location = new System.Drawing.Point(174, 89);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.CMND);
            this.panel1.Controls.Add(this.Sex);
            this.panel1.Controls.Add(this.CMNDShow);
            this.panel1.Controls.Add(this.SexShow);
            this.panel1.Controls.Add(this.PosShow);
            this.panel1.Controls.Add(this.NameShow);
            this.panel1.Controls.Add(this.BirthShow);
            this.panel1.Controls.Add(this.Pos);
            this.panel1.Controls.Add(this.PhoneShow);
            this.panel1.Controls.Add(this.Namelb);
            this.panel1.Controls.Add(this.AddressShow);
            this.panel1.Controls.Add(this.BirthDate);
            this.panel1.Location = new System.Drawing.Point(304, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 205);
            this.panel1.TabIndex = 21;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Phone.Location = new System.Drawing.Point(479, 111);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(57, 30);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "SĐT:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Address.Location = new System.Drawing.Point(479, 9);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(82, 30);
            this.Address.TabIndex = 12;
            this.Address.Text = "Địa chỉ:";
            // 
            // CMND
            // 
            this.CMND.AutoSize = true;
            this.CMND.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CMND.Location = new System.Drawing.Point(22, 166);
            this.CMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(83, 30);
            this.CMND.TabIndex = 13;
            this.CMND.Text = "CMND:";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Sex.Location = new System.Drawing.Point(22, 111);
            this.Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(98, 30);
            this.Sex.TabIndex = 14;
            this.Sex.Text = "Giới tính:";
            // 
            // CMNDShow
            // 
            this.CMNDShow.AutoSize = true;
            this.CMNDShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CMNDShow.Location = new System.Drawing.Point(179, 166);
            this.CMNDShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CMNDShow.Name = "CMNDShow";
            this.CMNDShow.Size = new System.Drawing.Size(113, 30);
            this.CMNDShow.TabIndex = 15;
            this.CMNDShow.Text = "Ngày sinh:";
            // 
            // SexShow
            // 
            this.SexShow.AutoSize = true;
            this.SexShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SexShow.Location = new System.Drawing.Point(179, 111);
            this.SexShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SexShow.Name = "SexShow";
            this.SexShow.Size = new System.Drawing.Size(113, 30);
            this.SexShow.TabIndex = 16;
            this.SexShow.Text = "Ngày sinh:";
            // 
            // PosShow
            // 
            this.PosShow.AutoSize = true;
            this.PosShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PosShow.Location = new System.Drawing.Point(609, 166);
            this.PosShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PosShow.Name = "PosShow";
            this.PosShow.Size = new System.Drawing.Size(113, 30);
            this.PosShow.TabIndex = 17;
            this.PosShow.Text = "Ngày sinh:";
            // 
            // NameShow
            // 
            this.NameShow.AutoSize = true;
            this.NameShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NameShow.Location = new System.Drawing.Point(179, 9);
            this.NameShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameShow.Name = "NameShow";
            this.NameShow.Size = new System.Drawing.Size(113, 30);
            this.NameShow.TabIndex = 18;
            this.NameShow.Text = "Ngày sinh:";
            // 
            // BirthShow
            // 
            this.BirthShow.AutoSize = true;
            this.BirthShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BirthShow.Location = new System.Drawing.Point(179, 61);
            this.BirthShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthShow.Name = "BirthShow";
            this.BirthShow.Size = new System.Drawing.Size(113, 30);
            this.BirthShow.TabIndex = 19;
            this.BirthShow.Text = "Ngày sinh:";
            // 
            // Pos
            // 
            this.Pos.AutoSize = true;
            this.Pos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Pos.Location = new System.Drawing.Point(479, 166);
            this.Pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(63, 30);
            this.Pos.TabIndex = 20;
            this.Pos.Text = "Vị trí:";
            // 
            // PhoneShow
            // 
            this.PhoneShow.AutoSize = true;
            this.PhoneShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PhoneShow.Location = new System.Drawing.Point(609, 111);
            this.PhoneShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneShow.Name = "PhoneShow";
            this.PhoneShow.Size = new System.Drawing.Size(113, 30);
            this.PhoneShow.TabIndex = 21;
            this.PhoneShow.Text = "Ngày sinh:";
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Namelb.Location = new System.Drawing.Point(22, 9);
            this.Namelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(84, 30);
            this.Namelb.TabIndex = 22;
            this.Namelb.Text = "Họ tên:";
            // 
            // AddressShow
            // 
            this.AddressShow.AllowDrop = true;
            this.AddressShow.AutoSize = true;
            this.AddressShow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddressShow.Location = new System.Drawing.Point(609, 9);
            this.AddressShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressShow.Name = "AddressShow";
            this.AddressShow.Size = new System.Drawing.Size(113, 30);
            this.AddressShow.TabIndex = 23;
            this.AddressShow.Text = "Ngày sinh:";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BirthDate.Location = new System.Drawing.Point(22, 61);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(113, 30);
            this.BirthDate.TabIndex = 24;
            this.BirthDate.Text = "Ngày sinh:";
            // 
            // StaffItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.numericFault);
            this.Controls.Add(this.numericUpDownOverTime);
            this.Controls.Add(this.picStaff);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StaffItem";
            this.Size = new System.Drawing.Size(1706, 402);
            this.Load += new System.EventHandler(this.StaffItem_Load);
            this.SizeChanged += new System.EventHandler(this.StaffItem_SizeChanged);
            this.Click += new System.EventHandler(this.StaffItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbID;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbPosition;
        private Guna.UI.WinForms.GunaLabel lbUserName;
        private Guna.UI.WinForms.GunaLabel lbSalary;
        private Guna.UI.WinForms.GunaButton btEdit;
        private Guna.UI.WinForms.GunaButton btDel;
        private Guna.UI.WinForms.GunaPictureBox picStaff;
        private Guna.UI.WinForms.GunaNumeric numericUpDownOverTime;
        private Guna.UI.WinForms.GunaNumeric numericFault;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel Phone;
        private Guna.UI.WinForms.GunaLabel Address;
        private Guna.UI.WinForms.GunaLabel CMND;
        private Guna.UI.WinForms.GunaLabel Sex;
        private Guna.UI.WinForms.GunaLabel CMNDShow;
        private Guna.UI.WinForms.GunaLabel SexShow;
        private Guna.UI.WinForms.GunaLabel PosShow;
        private Guna.UI.WinForms.GunaLabel NameShow;
        private Guna.UI.WinForms.GunaLabel BirthShow;
        private Guna.UI.WinForms.GunaLabel Pos;
        private Guna.UI.WinForms.GunaLabel PhoneShow;
        private Guna.UI.WinForms.GunaLabel Namelb;
        private Guna.UI.WinForms.GunaLabel AddressShow;
        private Guna.UI.WinForms.GunaLabel BirthDate;
    }
}
