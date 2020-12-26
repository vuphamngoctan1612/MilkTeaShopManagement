
namespace MilkTeaHouseProject.GUI
{
    partial class fRoomTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoomTable));
            this.pnBtn = new System.Windows.Forms.Panel();
            this.lbIDTable = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnDelTable = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelRoom = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSwapTable = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddTable = new Guna.UI.WinForms.GunaAdvenceButton();
            this.flowLayoutPanelGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBtn.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBtn
            // 
            this.pnBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnBtn.Controls.Add(this.lbIDTable);
            this.pnBtn.Controls.Add(this.pnSearch);
            this.pnBtn.Controls.Add(this.btnDelTable);
            this.pnBtn.Controls.Add(this.btnDelRoom);
            this.pnBtn.Controls.Add(this.btnSwapTable);
            this.pnBtn.Controls.Add(this.btnAddTable);
            this.pnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBtn.Location = new System.Drawing.Point(0, 0);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(1326, 79);
            this.pnBtn.TabIndex = 3;
            // 
            // lbIDTable
            // 
            this.lbIDTable.AutoSize = true;
            this.lbIDTable.Location = new System.Drawing.Point(900, 40);
            this.lbIDTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDTable.Name = "lbIDTable";
            this.lbIDTable.Size = new System.Drawing.Size(51, 20);
            this.lbIDTable.TabIndex = 12;
            this.lbIDTable.Text = "label1";
            this.lbIDTable.Visible = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSearch.Location = new System.Drawing.Point(962, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(364, 79);
            this.pnSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::MilkTeaHouseProject.Properties.Resources.searchlue;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(278, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(36, 32);
            this.btnSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.AllowDrop = true;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(278, 50);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelTable.AnimationHoverSpeed = 0.07F;
            this.btnDelTable.AnimationSpeed = 0.03F;
            this.btnDelTable.BackColor = System.Drawing.Color.Transparent;
            this.btnDelTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnDelTable.BorderColor = System.Drawing.Color.Black;
            this.btnDelTable.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelTable.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelTable.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelTable.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelTable.CheckedImage")));
            this.btnDelTable.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelTable.ForeColor = System.Drawing.Color.White;
            this.btnDelTable.Image = null;
            this.btnDelTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelTable.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelTable.Location = new System.Drawing.Point(666, 19);
            this.btnDelTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDelTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelTable.OnHoverImage = null;
            this.btnDelTable.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelTable.Radius = 10;
            this.btnDelTable.Size = new System.Drawing.Size(173, 42);
            this.btnDelTable.TabIndex = 2;
            this.btnDelTable.Text = "Xóa bàn";
            this.btnDelTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelTable.Visible = false;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelRoom.AnimationHoverSpeed = 0.07F;
            this.btnDelRoom.AnimationSpeed = 0.03F;
            this.btnDelRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnDelRoom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnDelRoom.BorderColor = System.Drawing.Color.Black;
            this.btnDelRoom.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelRoom.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelRoom.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelRoom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelRoom.CheckedImage")));
            this.btnDelRoom.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelRoom.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelRoom.ForeColor = System.Drawing.Color.White;
            this.btnDelRoom.Image = null;
            this.btnDelRoom.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelRoom.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelRoom.Location = new System.Drawing.Point(250, 19);
            this.btnDelRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDelRoom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelRoom.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelRoom.OnHoverImage = null;
            this.btnDelRoom.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelRoom.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelRoom.Radius = 10;
            this.btnDelRoom.Size = new System.Drawing.Size(173, 42);
            this.btnDelRoom.TabIndex = 2;
            this.btnDelRoom.Text = "Xóa phòng";
            this.btnDelRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSwapTable.AnimationHoverSpeed = 0.07F;
            this.btnSwapTable.AnimationSpeed = 0.03F;
            this.btnSwapTable.BackColor = System.Drawing.Color.Transparent;
            this.btnSwapTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnSwapTable.BorderColor = System.Drawing.Color.Black;
            this.btnSwapTable.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSwapTable.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSwapTable.CheckedForeColor = System.Drawing.Color.White;
            this.btnSwapTable.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSwapTable.CheckedImage")));
            this.btnSwapTable.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSwapTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwapTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwapTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwapTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSwapTable.ForeColor = System.Drawing.Color.White;
            this.btnSwapTable.Image = null;
            this.btnSwapTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSwapTable.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwapTable.Location = new System.Drawing.Point(455, 19);
            this.btnSwapTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnSwapTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSwapTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSwapTable.OnHoverImage = null;
            this.btnSwapTable.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSwapTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnSwapTable.Radius = 10;
            this.btnSwapTable.Size = new System.Drawing.Size(173, 42);
            this.btnSwapTable.TabIndex = 1;
            this.btnSwapTable.Text = "Chuyển bàn";
            this.btnSwapTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSwapTable.Visible = false;
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddTable.AnimationHoverSpeed = 0.07F;
            this.btnAddTable.AnimationSpeed = 0.03F;
            this.btnAddTable.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnAddTable.BorderColor = System.Drawing.Color.Black;
            this.btnAddTable.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddTable.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddTable.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddTable.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddTable.CheckedImage")));
            this.btnAddTable.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Image = null;
            this.btnAddTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddTable.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddTable.Location = new System.Drawing.Point(41, 19);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnAddTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddTable.OnHoverImage = null;
            this.btnAddTable.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddTable.Radius = 10;
            this.btnAddTable.Size = new System.Drawing.Size(173, 42);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Thêm bàn";
            this.btnAddTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // flowLayoutPanelGroup
            // 
            this.flowLayoutPanelGroup.AutoScroll = true;
            this.flowLayoutPanelGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.flowLayoutPanelGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelGroup.Location = new System.Drawing.Point(0, 79);
            this.flowLayoutPanelGroup.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelGroup.Name = "flowLayoutPanelGroup";
            this.flowLayoutPanelGroup.Padding = new System.Windows.Forms.Padding(10, 4, 10, 2);
            this.flowLayoutPanelGroup.Size = new System.Drawing.Size(1326, 42);
            this.flowLayoutPanelGroup.TabIndex = 4;
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.AutoScroll = true;
            this.flowLayoutPanelTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(0, 121);
            this.flowLayoutPanelTable.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(1326, 732);
            this.flowLayoutPanelTable.TabIndex = 6;
            // 
            // fRoomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1326, 853);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.flowLayoutPanelGroup);
            this.Controls.Add(this.pnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fRoomTable";
            this.Text = "Phòng bàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnBtn.ResumeLayout(false);
            this.pnBtn.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBtn;
        private System.Windows.Forms.Label lbIDTable;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelTable;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelRoom;
        private Guna.UI.WinForms.GunaAdvenceButton btnSwapTable;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
    }
}