
namespace MilkTeaHouseProject
{
    partial class fSetSalary
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
            this.pn = new System.Windows.Forms.Panel();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelSetSalary = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMinusSalary = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSalary = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtOverTime = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lbSalary = new Guna.UI.WinForms.GunaLabel();
            this.cbbStaff = new Guna.UI.WinForms.GunaComboBox();
            this.lbPos = new Guna.UI.WinForms.GunaLabel();
            this.pn.SuspendLayout();
            this.panelSetSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.pn.Controls.Add(this.lbNameForm);
            this.pn.Controls.Add(this.btnExit);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(660, 42);
            this.pn.TabIndex = 5;
            this.pn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_MouseDown);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(20, 9);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(165, 30);
            this.lbNameForm.TabIndex = 2;
            this.lbNameForm.Text = "Thiết lập lương";
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
            this.btnExit.CheckedImage = null;
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
            this.btnExit.Location = new System.Drawing.Point(610, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(50, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btSave
            // 
            this.btSave.AnimationHoverSpeed = 0.07F;
            this.btSave.AnimationSpeed = 0.03F;
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btSave.BorderColor = System.Drawing.Color.Black;
            this.btSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btSave.CheckedForeColor = System.Drawing.Color.White;
            this.btSave.CheckedImage = null;
            this.btSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSave.FocusedColor = System.Drawing.Color.Empty;
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Image = null;
            this.btSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btSave.Location = new System.Drawing.Point(133, 521);
            this.btSave.Name = "btSave";
            this.btSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btSave.OnHoverImage = null;
            this.btSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btSave.OnPressedColor = System.Drawing.Color.Black;
            this.btSave.Radius = 10;
            this.btSave.Size = new System.Drawing.Size(165, 42);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Lưu";
            this.btSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.Location = new System.Drawing.Point(351, 521);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(165, 42);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panelSetSalary
            // 
            this.panelSetSalary.Controls.Add(this.gunaLabel2);
            this.panelSetSalary.Controls.Add(this.txtMinusSalary);
            this.panelSetSalary.Controls.Add(this.gunaLabel1);
            this.panelSetSalary.Controls.Add(this.txtSalary);
            this.panelSetSalary.Controls.Add(this.gunaLabel4);
            this.panelSetSalary.Controls.Add(this.txtOverTime);
            this.panelSetSalary.Controls.Add(this.gunaLabel3);
            this.panelSetSalary.Controls.Add(this.lbSalary);
            this.panelSetSalary.Controls.Add(this.cbbStaff);
            this.panelSetSalary.Controls.Add(this.lbPos);
            this.panelSetSalary.Controls.Add(this.btnReturn);
            this.panelSetSalary.Controls.Add(this.btSave);
            this.panelSetSalary.Location = new System.Drawing.Point(0, 45);
            this.panelSetSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSetSalary.Name = "panelSetSalary";
            this.panelSetSalary.Size = new System.Drawing.Size(660, 654);
            this.panelSetSalary.TabIndex = 24;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel2.Location = new System.Drawing.Point(490, 406);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(95, 30);
            this.gunaLabel2.TabIndex = 38;
            this.gunaLabel2.Text = "VNĐ/Lỗi";
            // 
            // txtMinusSalary
            // 
            this.txtMinusSalary.BackColor = System.Drawing.Color.White;
            this.txtMinusSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinusSalary.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMinusSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinusSalary.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMinusSalary.Location = new System.Drawing.Point(301, 406);
            this.txtMinusSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinusSalary.Name = "txtMinusSalary";
            this.txtMinusSalary.PasswordChar = '\0';
            this.txtMinusSalary.SelectedText = "";
            this.txtMinusSalary.Size = new System.Drawing.Size(174, 40);
            this.txtMinusSalary.TabIndex = 37;
            this.txtMinusSalary.TextChanged += new System.EventHandler(this.txtMinusSalary_TextChanged);
            this.txtMinusSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinusSalary_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel1.Location = new System.Drawing.Point(83, 406);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(47, 30);
            this.gunaLabel1.TabIndex = 36;
            this.gunaLabel1.Text = "Lỗi ";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.White;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSalary.Location = new System.Drawing.Point(301, 185);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(294, 40);
            this.txtSalary.TabIndex = 35;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel4.Location = new System.Drawing.Point(490, 302);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(100, 30);
            this.gunaLabel4.TabIndex = 32;
            this.gunaLabel4.Text = "VNĐ/Giờ";
            // 
            // txtOverTime
            // 
            this.txtOverTime.BackColor = System.Drawing.Color.White;
            this.txtOverTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOverTime.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOverTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverTime.LineColor = System.Drawing.Color.Gainsboro;
            this.txtOverTime.Location = new System.Drawing.Point(301, 302);
            this.txtOverTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.PasswordChar = '\0';
            this.txtOverTime.SelectedText = "";
            this.txtOverTime.Size = new System.Drawing.Size(174, 40);
            this.txtOverTime.TabIndex = 30;
            this.txtOverTime.TextChanged += new System.EventHandler(this.txtOverTime_TextChanged);
            this.txtOverTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverTime_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel3.Location = new System.Drawing.Point(83, 305);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(122, 30);
            this.gunaLabel3.TabIndex = 26;
            this.gunaLabel3.Text = "Giờ tăng ca";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSalary.Location = new System.Drawing.Point(83, 185);
            this.lbSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(118, 30);
            this.lbSalary.TabIndex = 24;
            this.lbSalary.Text = "Mức lương";
            // 
            // cbbStaff
            // 
            this.cbbStaff.BackColor = System.Drawing.Color.Transparent;
            this.cbbStaff.BaseColor = System.Drawing.Color.White;
            this.cbbStaff.BorderColor = System.Drawing.Color.Silver;
            this.cbbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaff.FocusedColor = System.Drawing.Color.Empty;
            this.cbbStaff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStaff.ForeColor = System.Drawing.Color.Black;
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Items.AddRange(new object[] {
            "Thu Ngân",
            "Pha Chế",
            "Phục vụ",
            "Bảo Vệ"});
            this.cbbStaff.Location = new System.Drawing.Point(301, 56);
            this.cbbStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbStaff.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbStaff.Size = new System.Drawing.Size(294, 38);
            this.cbbStaff.TabIndex = 23;
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPos.Location = new System.Drawing.Point(83, 64);
            this.lbPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(58, 30);
            this.lbPos.TabIndex = 22;
            this.lbPos.Text = "Vị trí";
            // 
            // fSetSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panelSetSalary);
            this.Controls.Add(this.pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fSetSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSetSalary";
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.panelSetSalary.ResumeLayout(false);
            this.panelSetSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbNameForm;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaAdvenceButton btSave;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private System.Windows.Forms.Panel panelSetSalary;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtMinusSalary;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtSalary;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox txtOverTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lbSalary;
        private Guna.UI.WinForms.GunaComboBox cbbStaff;
        private Guna.UI.WinForms.GunaLabel lbPos;
    }
}