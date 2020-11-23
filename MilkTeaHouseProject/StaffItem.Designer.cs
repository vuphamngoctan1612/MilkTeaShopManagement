
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
            this.components = new System.ComponentModel.Container();
            this.lbID = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbBirthDate = new Guna.UI.WinForms.GunaLabel();
            this.lbPosition = new Guna.UI.WinForms.GunaLabel();
            this.lbUserName = new Guna.UI.WinForms.GunaLabel();
            this.lbSalary = new Guna.UI.WinForms.GunaLabel();
            this.btEdit = new Guna.UI.WinForms.GunaButton();
            this.btDel = new Guna.UI.WinForms.GunaButton();
            this.lbOverTime = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.picStaff = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(3, 16);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(127, 25);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Mã nhân viên";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(135, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(129, 25);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tên nhân viên";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(344, 24);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(96, 25);
            this.lbBirthDate.TabIndex = 10;
            this.lbBirthDate.Text = "Ngày sinh";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(590, 24);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(52, 25);
            this.lbPosition.TabIndex = 11;
            this.lbPosition.Text = "Vị trí";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(696, 24);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(137, 25);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(901, 24);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(65, 25);
            this.lbSalary.TabIndex = 14;
            this.lbSalary.Text = "Lương";
            // 
            // btEdit
            // 
            this.btEdit.AnimationHoverSpeed = 0.07F;
            this.btEdit.AnimationSpeed = 0.03F;
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btEdit.BorderColor = System.Drawing.Color.Black;
            this.btEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = global::MilkTeaHouseProject.Properties.Resources.pencil_24px;
            this.btEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btEdit.Location = new System.Drawing.Point(1025, 17);
            this.btEdit.Name = "btEdit";
            this.btEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btEdit.OnHoverImage = null;
            this.btEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btEdit.Radius = 10;
            this.btEdit.Size = new System.Drawing.Size(40, 25);
            this.btEdit.TabIndex = 15;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.AnimationHoverSpeed = 0.07F;
            this.btDel.AnimationSpeed = 0.03F;
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btDel.BorderColor = System.Drawing.Color.Black;
            this.btDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDel.FocusedColor = System.Drawing.Color.Empty;
            this.btDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = global::MilkTeaHouseProject.Properties.Resources.delete_bin_32px;
            this.btDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btDel.ImageSize = new System.Drawing.Size(20, 20);
            this.btDel.Location = new System.Drawing.Point(1097, 16);
            this.btDel.Name = "btDel";
            this.btDel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btDel.OnHoverImage = null;
            this.btDel.OnPressedColor = System.Drawing.Color.Black;
            this.btDel.Radius = 10;
            this.btDel.Size = new System.Drawing.Size(40, 25);
            this.btDel.TabIndex = 16;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lbOverTime
            // 
            this.lbOverTime.AutoSize = true;
            this.lbOverTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverTime.Location = new System.Drawing.Point(802, 24);
            this.lbOverTime.Name = "lbOverTime";
            this.lbOverTime.Size = new System.Drawing.Size(93, 25);
            this.lbOverTime.TabIndex = 13;
            this.lbOverTime.Text = "OverTime";
            this.lbOverTime.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // picStaff
            // 
            this.picStaff.BaseColor = System.Drawing.Color.White;
            this.picStaff.Location = new System.Drawing.Point(275, 16);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(120, 120);
            this.picStaff.TabIndex = 17;
            this.picStaff.TabStop = false;
            // 
            // StaffItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.picStaff);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbOverTime);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Name = "StaffItem";
            this.Size = new System.Drawing.Size(1213, 60);
            this.SizeChanged += new System.EventHandler(this.StaffItem_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbID;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbBirthDate;
        private Guna.UI.WinForms.GunaLabel lbPosition;
        private Guna.UI.WinForms.GunaLabel lbUserName;
        private Guna.UI.WinForms.GunaLabel lbSalary;
        private Guna.UI.WinForms.GunaButton btEdit;
        private Guna.UI.WinForms.GunaButton btDel;
        private Guna.UI.WinForms.GunaLabel lbOverTime;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox picStaff;
    }
}
