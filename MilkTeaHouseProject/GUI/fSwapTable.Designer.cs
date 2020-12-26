
namespace MilkTeaHouseProject.GUI
{
    partial class fSwapTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSwapTable));
            this.pn = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.errorShow = new Guna.UI.WinForms.GunaLabel();
            this.btnSwap = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbTableNameSelected = new System.Windows.Forms.Label();
            this.lbNameGroup = new System.Windows.Forms.Label();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbGroup = new Guna.UI.WinForms.GunaComboBox();
            this.cbID = new Guna.UI.WinForms.GunaComboBox();
            this.cbTable = new Guna.UI.WinForms.GunaComboBox();
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
            this.pn.Margin = new System.Windows.Forms.Padding(2);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(456, 42);
            this.pn.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(406, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(50, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(10, 6);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(83, 28);
            this.lbNameForm.TabIndex = 1;
            this.lbNameForm.Text = "Đổi bàn";
            // 
            // errorShow
            // 
            this.errorShow.AutoSize = true;
            this.errorShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorShow.ForeColor = System.Drawing.Color.Red;
            this.errorShow.Location = new System.Drawing.Point(56, 326);
            this.errorShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorShow.Name = "errorShow";
            this.errorShow.Size = new System.Drawing.Size(103, 25);
            this.errorShow.TabIndex = 68;
            this.errorShow.Text = "gunaLabel2";
            this.errorShow.Visible = false;
            // 
            // btnSwap
            // 
            this.btnSwap.AnimationHoverSpeed = 0.07F;
            this.btnSwap.AnimationSpeed = 0.03F;
            this.btnSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnSwap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnSwap.BorderColor = System.Drawing.Color.Black;
            this.btnSwap.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSwap.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSwap.CheckedForeColor = System.Drawing.Color.White;
            this.btnSwap.CheckedImage = null;
            this.btnSwap.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwap.FocusedColor = System.Drawing.Color.White;
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Image = null;
            this.btnSwap.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSwap.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwap.Location = new System.Drawing.Point(59, 368);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnSwap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSwap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSwap.OnHoverImage = null;
            this.btnSwap.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwap.OnPressedColor = System.Drawing.Color.Black;
            this.btnSwap.Radius = 10;
            this.btnSwap.Size = new System.Drawing.Size(142, 42);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "Lưu";
            this.btnSwap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lbTableNameSelected
            // 
            this.lbTableNameSelected.AutoSize = true;
            this.lbTableNameSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableNameSelected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTableNameSelected.Location = new System.Drawing.Point(54, 66);
            this.lbTableNameSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTableNameSelected.Name = "lbTableNameSelected";
            this.lbTableNameSelected.Size = new System.Drawing.Size(143, 32);
            this.lbTableNameSelected.TabIndex = 64;
            this.lbTableNameSelected.Text = "Tên phòng:";
            // 
            // lbNameGroup
            // 
            this.lbNameGroup.AutoSize = true;
            this.lbNameGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNameGroup.Location = new System.Drawing.Point(55, 108);
            this.lbNameGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameGroup.Name = "lbNameGroup";
            this.lbNameGroup.Size = new System.Drawing.Size(116, 28);
            this.lbNameGroup.TabIndex = 65;
            this.lbNameGroup.Text = "Tên phòng:";
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNameTable.Location = new System.Drawing.Point(55, 218);
            this.lbNameTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(91, 28);
            this.lbNameTable.TabIndex = 66;
            this.lbNameTable.Text = "Tên bàn:";
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
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.Location = new System.Drawing.Point(236, 368);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 10;
            this.btnReturn.Size = new System.Drawing.Size(144, 42);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.BackColor = System.Drawing.Color.Transparent;
            this.cbGroup.BaseColor = System.Drawing.Color.White;
            this.cbGroup.BorderColor = System.Drawing.Color.Silver;
            this.cbGroup.BorderSize = 1;
            this.cbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.ForeColor = System.Drawing.Color.Black;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(61, 152);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbGroup.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbGroup.Size = new System.Drawing.Size(320, 40);
            this.cbGroup.TabIndex = 0;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // cbID
            // 
            this.cbID.BackColor = System.Drawing.Color.Transparent;
            this.cbID.BaseColor = System.Drawing.Color.White;
            this.cbID.BorderColor = System.Drawing.Color.Silver;
            this.cbID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FocusedColor = System.Drawing.Color.Empty;
            this.cbID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbID.ForeColor = System.Drawing.Color.Black;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(619, 416);
            this.cbID.Margin = new System.Windows.Forms.Padding(2);
            this.cbID.Name = "cbID";
            this.cbID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbID.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbID.Size = new System.Drawing.Size(320, 46);
            this.cbID.TabIndex = 61;
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.Transparent;
            this.cbTable.BaseColor = System.Drawing.Color.White;
            this.cbTable.BorderColor = System.Drawing.Color.Silver;
            this.cbTable.BorderSize = 1;
            this.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.ForeColor = System.Drawing.Color.Black;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(61, 262);
            this.cbTable.Margin = new System.Windows.Forms.Padding(2);
            this.cbTable.Name = "cbTable";
            this.cbTable.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTable.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTable.Size = new System.Drawing.Size(320, 40);
            this.cbTable.TabIndex = 1;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // fSwapTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.errorShow);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lbTableNameSelected);
            this.Controls.Add(this.lbNameGroup);
            this.Controls.Add(this.lbNameTable);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.cbTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fSwapTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSwapTable";
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private System.Windows.Forms.Label lbNameForm;
        private Guna.UI.WinForms.GunaLabel errorShow;
        private Guna.UI.WinForms.GunaAdvenceButton btnSwap;
        private System.Windows.Forms.Label lbTableNameSelected;
        private System.Windows.Forms.Label lbNameGroup;
        private System.Windows.Forms.Label lbNameTable;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private Guna.UI.WinForms.GunaComboBox cbGroup;
        private Guna.UI.WinForms.GunaComboBox cbID;
        private Guna.UI.WinForms.GunaComboBox cbTable;
    }
}