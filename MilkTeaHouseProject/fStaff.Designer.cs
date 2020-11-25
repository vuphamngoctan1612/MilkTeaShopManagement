namespace MilkTeaHouseProject
{
    partial class fStaff
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
            this.pnStaff = new System.Windows.Forms.Panel();
            this.flowLayoutPanelStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBirthDate = new Guna.UI.WinForms.GunaLabel();
            this.lbPosition = new Guna.UI.WinForms.GunaLabel();
            this.lbUserName = new Guna.UI.WinForms.GunaLabel();
            this.lbOverTime = new Guna.UI.WinForms.GunaLabel();
            this.lbSalary = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbID = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new Guna.UI.WinForms.GunaButton();
            this.btSetSalary = new Guna.UI.WinForms.GunaButton();
            this.pnStaff.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStaff
            // 
            this.pnStaff.Controls.Add(this.flowLayoutPanelStaff);
            this.pnStaff.Controls.Add(this.panel1);
            this.pnStaff.Controls.Add(this.panel2);
            this.pnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaff.Location = new System.Drawing.Point(0, 0);
            this.pnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnStaff.Name = "pnStaff";
            this.pnStaff.Size = new System.Drawing.Size(1213, 715);
            this.pnStaff.TabIndex = 0;
            // 
            // flowLayoutPanelStaff
            // 
            this.flowLayoutPanelStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStaff.Location = new System.Drawing.Point(0, 83);
            this.flowLayoutPanelStaff.Name = "flowLayoutPanelStaff";
            this.flowLayoutPanelStaff.Size = new System.Drawing.Size(1213, 632);
            this.flowLayoutPanelStaff.TabIndex = 15;
            this.flowLayoutPanelStaff.SizeChanged += new System.EventHandler(this.flowLayoutPanelStaff_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.lbBirthDate);
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbOverTime);
            this.panel1.Controls.Add(this.lbSalary);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 32);
            this.panel1.TabIndex = 14;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(225, -1);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(78, 20);
            this.lbBirthDate.TabIndex = 22;
            this.lbBirthDate.Text = "Ngày sinh";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(462, 6);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(42, 20);
            this.lbPosition.TabIndex = 21;
            this.lbPosition.Text = "Vị trí";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(581, -1);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(111, 20);
            this.lbUserName.TabIndex = 20;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbOverTime
            // 
            this.lbOverTime.AutoSize = true;
            this.lbOverTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverTime.Location = new System.Drawing.Point(888, 3);
            this.lbOverTime.Name = "lbOverTime";
            this.lbOverTime.Size = new System.Drawing.Size(100, 20);
            this.lbOverTime.TabIndex = 19;
            this.lbOverTime.Text = "Giờ làm thêm";
            this.lbOverTime.Visible = false;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(804, -1);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 20);
            this.lbSalary.TabIndex = 18;
            this.lbSalary.Text = "Lương";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(91, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(105, 20);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Tên nhân viên";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(26, 3);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(103, 20);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btSetSalary);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 51);
            this.panel2.TabIndex = 13;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAdd.AnimationHoverSpeed = 0.07F;
            this.btAdd.AnimationSpeed = 0.03F;
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = null;
            this.btAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btAdd.Location = new System.Drawing.Point(1042, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.btAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btAdd.OnHoverImage = null;
            this.btAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btAdd.Radius = 10;
            this.btAdd.Size = new System.Drawing.Size(141, 27);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "Thêm nhân viên";
            this.btAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSetSalary
            // 
            this.btSetSalary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSetSalary.AnimationHoverSpeed = 0.07F;
            this.btSetSalary.AnimationSpeed = 0.03F;
            this.btSetSalary.BackColor = System.Drawing.Color.Transparent;
            this.btSetSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btSetSalary.BorderColor = System.Drawing.Color.White;
            this.btSetSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSetSalary.FocusedColor = System.Drawing.Color.Empty;
            this.btSetSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btSetSalary.ForeColor = System.Drawing.Color.White;
            this.btSetSalary.Image = null;
            this.btSetSalary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btSetSalary.ImageSize = new System.Drawing.Size(20, 20);
            this.btSetSalary.Location = new System.Drawing.Point(892, 12);
            this.btSetSalary.Name = "btSetSalary";
            this.btSetSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(54)))));
            this.btSetSalary.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSetSalary.OnHoverForeColor = System.Drawing.Color.White;
            this.btSetSalary.OnHoverImage = null;
            this.btSetSalary.OnPressedColor = System.Drawing.Color.Black;
            this.btSetSalary.Radius = 10;
            this.btSetSalary.Size = new System.Drawing.Size(141, 27);
            this.btSetSalary.TabIndex = 24;
            this.btSetSalary.Text = "Thiết lập lương";
            this.btSetSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btSetSalary.Click += new System.EventHandler(this.btSetSalary_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 715);
            this.Controls.Add(this.pnStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fStaff";
            this.Text = "NHÂN VIÊN";
            this.pnStaff.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStaff;
        private Guna.UI.WinForms.GunaLabel lbBirthDate;
        private Guna.UI.WinForms.GunaLabel lbSalary;
        private Guna.UI.WinForms.GunaLabel lbOverTime;
        private Guna.UI.WinForms.GunaLabel lbUserName;
        private Guna.UI.WinForms.GunaLabel lbPosition;
        private Guna.UI.WinForms.GunaButton btAdd;
        private Guna.UI.WinForms.GunaButton btSetSalary;
    }
}