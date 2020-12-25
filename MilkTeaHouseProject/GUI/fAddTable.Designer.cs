
namespace MilkTeaHouseProject
{
    partial class fAddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddTable));
            this.pn = new System.Windows.Forms.Panel();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbGroup = new System.Windows.Forms.Label();
            this.cbbGroup = new Guna.UI.WinForms.GunaComboBox();
            this.btnAddGroup = new Guna.UI.WinForms.GunaButton();
            this.errorShow = new Guna.UI.WinForms.GunaLabel();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtGroup = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtName = new Guna.UI.WinForms.GunaLineTextBox();
            this.pn.SuspendLayout();
            this.SuspendLayout();
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
            this.pn.Size = new System.Drawing.Size(455, 33);
            this.pn.TabIndex = 5;
            this.pn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_MouseDown);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(17, 7);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(97, 25);
            this.lbNameForm.TabIndex = 2;
            this.lbNameForm.Text = "Thêm bàn";
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
            this.btnExit.Location = new System.Drawing.Point(413, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(42, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(87, 230);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(77, 23);
            this.lbName.TabIndex = 47;
            this.lbName.Text = "Tên bàn:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbId.Location = new System.Drawing.Point(87, 68);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 23);
            this.lbId.TabIndex = 48;
            this.lbId.Text = "ID:";
            // 
            // btnReturn
            // 
            this.btnReturn.AnimationHoverSpeed = 0.07F;
            this.btnReturn.AnimationSpeed = 0.03F;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.btnReturn.Location = new System.Drawing.Point(251, 334);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(118, 33);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(90, 334);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(118, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGroup.Location = new System.Drawing.Point(87, 149);
            this.lbGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(64, 23);
            this.lbGroup.TabIndex = 47;
            this.lbGroup.Text = "Nhóm:";
            // 
            // cbbGroup
            // 
            this.cbbGroup.BackColor = System.Drawing.Color.Transparent;
            this.cbbGroup.BaseColor = System.Drawing.Color.White;
            this.cbbGroup.BorderColor = System.Drawing.Color.Silver;
            this.cbbGroup.BorderSize = 1;
            this.cbbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroup.ForeColor = System.Drawing.Color.Black;
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(90, 175);
            this.cbbGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbGroup.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbGroup.Size = new System.Drawing.Size(281, 35);
            this.cbbGroup.TabIndex = 0;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AnimationHoverSpeed = 0.07F;
            this.btnAddGroup.AnimationSpeed = 0.03F;
            this.btnAddGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGroup.BaseColor = System.Drawing.Color.White;
            this.btnAddGroup.BorderColor = System.Drawing.Color.Black;
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Image = global::MilkTeaHouseProject.Properties.Resources.add_32px;
            this.btnAddGroup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddGroup.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddGroup.Location = new System.Drawing.Point(383, 178);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddGroup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddGroup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddGroup.OnHoverImage = null;
            this.btnAddGroup.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddGroup.Radius = 10;
            this.btnAddGroup.Size = new System.Drawing.Size(35, 32);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // errorShow
            // 
            this.errorShow.AutoSize = true;
            this.errorShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorShow.ForeColor = System.Drawing.Color.Red;
            this.errorShow.Location = new System.Drawing.Point(182, 47);
            this.errorShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorShow.Name = "errorShow";
            this.errorShow.Size = new System.Drawing.Size(86, 20);
            this.errorShow.TabIndex = 58;
            this.errorShow.Text = "gunaLabel2";
            this.errorShow.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.LineColor = System.Drawing.Color.Gainsboro;
            this.txtID.LineSize = 2;
            this.txtID.Location = new System.Drawing.Point(90, 94);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(279, 42);
            this.txtID.TabIndex = 59;
            // 
            // txtGroup
            // 
            this.txtGroup.BackColor = System.Drawing.Color.White;
            this.txtGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroup.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGroup.LineSize = 2;
            this.txtGroup.Location = new System.Drawing.Point(90, 168);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.PasswordChar = '\0';
            this.txtGroup.SelectedText = "";
            this.txtGroup.Size = new System.Drawing.Size(279, 42);
            this.txtGroup.TabIndex = 0;
            this.txtGroup.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.LineColor = System.Drawing.Color.Gainsboro;
            this.txtName.LineSize = 2;
            this.txtName.Location = new System.Drawing.Point(90, 248);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(279, 42);
            this.txtName.TabIndex = 2;
            // 
            // fAddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(455, 415);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.errorShow);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.cbbGroup);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddTable";
            this.Load += new System.EventHandler(this.fAddTable_Load);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbNameForm;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private System.Windows.Forms.Label lbGroup;
        private Guna.UI.WinForms.GunaComboBox cbbGroup;
        private Guna.UI.WinForms.GunaButton btnAddGroup;
        private Guna.UI.WinForms.GunaLabel errorShow;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private Guna.UI.WinForms.GunaLineTextBox txtGroup;
        private Guna.UI.WinForms.GunaLineTextBox txtName;
    }
}