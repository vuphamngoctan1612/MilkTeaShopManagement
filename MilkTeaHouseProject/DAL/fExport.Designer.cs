
namespace MilkTeaHouseProject.DAL
{
    partial class fExport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn = new System.Windows.Forms.Panel();
            this.lbNameForm = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnExcel = new Guna.UI.WinForms.GunaPanel();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.btnExport = new Guna.UI.WinForms.GunaButton();
            this.dataExcel = new Guna.UI.WinForms.GunaDataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkteaManagementDataSet = new MilkTeaHouseProject.MilkteaManagementDataSet();
            this.staffTableAdapter = new MilkTeaHouseProject.MilkteaManagementDataSetTableAdapters.StaffTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oVERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn.SuspendLayout();
            this.pnExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkteaManagementDataSet)).BeginInit();
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
            this.pn.Size = new System.Drawing.Size(1258, 27);
            this.pn.TabIndex = 5;
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameForm.Location = new System.Drawing.Point(13, 6);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(119, 20);
            this.lbNameForm.TabIndex = 2;
            this.lbNameForm.Text = "Thêm nhân viên";
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
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MilkTeaHouseProject.Properties.Resources.Delete_32;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.Location = new System.Drawing.Point(1225, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(33, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnExcel
            // 
            this.pnExcel.Controls.Add(this.btnBack);
            this.pnExcel.Controls.Add(this.btnExport);
            this.pnExcel.Controls.Add(this.dataExcel);
            this.pnExcel.Location = new System.Drawing.Point(0, 29);
            this.pnExcel.Name = "pnExcel";
            this.pnExcel.Size = new System.Drawing.Size(1258, 668);
            this.pnExcel.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = null;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(1105, 628);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 10;
            this.btnBack.Size = new System.Drawing.Size(141, 27);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnExport.BorderColor = System.Drawing.Color.White;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(958, 628);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Radius = 10;
            this.btnExport.Size = new System.Drawing.Size(141, 27);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Xuất file";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataExcel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataExcel.AutoGenerateColumns = false;
            this.dataExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataExcel.BackgroundColor = System.Drawing.Color.White;
            this.dataExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataExcel.ColumnHeadersHeight = 21;
            this.dataExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.oVERTIMEDataGridViewTextBoxColumn,
            this.salaryReceivedDataGridViewTextBoxColumn,
            this.faultDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.sexDataGridViewCheckBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataExcel.DataSource = this.staffBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataExcel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataExcel.EnableHeadersVisualStyles = false;
            this.dataExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataExcel.Location = new System.Drawing.Point(0, 0);
            this.dataExcel.Name = "dataExcel";
            this.dataExcel.RowHeadersVisible = false;
            this.dataExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataExcel.Size = new System.Drawing.Size(1258, 604);
            this.dataExcel.TabIndex = 0;
            this.dataExcel.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataExcel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataExcel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataExcel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataExcel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataExcel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataExcel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataExcel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataExcel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataExcel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataExcel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataExcel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataExcel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataExcel.ThemeStyle.HeaderStyle.Height = 21;
            this.dataExcel.ThemeStyle.ReadOnly = false;
            this.dataExcel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataExcel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataExcel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataExcel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataExcel.ThemeStyle.RowsStyle.Height = 22;
            this.dataExcel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataExcel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.milkteaManagementDataSet;
            // 
            // milkteaManagementDataSet
            // 
            this.milkteaManagementDataSet.DataSetName = "MilkteaManagementDataSet";
            this.milkteaManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 46;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 71;
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.Width = 94;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 103;
            // 
            // oVERTIMEDataGridViewTextBoxColumn
            // 
            this.oVERTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oVERTIMEDataGridViewTextBoxColumn.DataPropertyName = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.HeaderText = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.Name = "oVERTIMEDataGridViewTextBoxColumn";
            this.oVERTIMEDataGridViewTextBoxColumn.Width = 97;
            // 
            // salaryReceivedDataGridViewTextBoxColumn
            // 
            this.salaryReceivedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryReceivedDataGridViewTextBoxColumn.DataPropertyName = "SalaryReceived";
            this.salaryReceivedDataGridViewTextBoxColumn.HeaderText = "SalaryReceived";
            this.salaryReceivedDataGridViewTextBoxColumn.Name = "salaryReceivedDataGridViewTextBoxColumn";
            this.salaryReceivedDataGridViewTextBoxColumn.Width = 121;
            // 
            // faultDataGridViewTextBoxColumn
            // 
            this.faultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.faultDataGridViewTextBoxColumn.DataPropertyName = "Fault";
            this.faultDataGridViewTextBoxColumn.HeaderText = "Fault";
            this.faultDataGridViewTextBoxColumn.Name = "faultDataGridViewTextBoxColumn";
            this.faultDataGridViewTextBoxColumn.Width = 62;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 121;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.Width = 74;
            // 
            // sexDataGridViewCheckBoxColumn
            // 
            this.sexDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexDataGridViewCheckBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewCheckBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewCheckBoxColumn.Name = "sexDataGridViewCheckBoxColumn";
            this.sexDataGridViewCheckBoxColumn.Width = 33;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 81;
            // 
            // fExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 696);
            this.ControlBox = false;
            this.Controls.Add(this.pnExcel);
            this.Controls.Add(this.pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fExport";
            this.Text = "fExport";
            this.Load += new System.EventHandler(this.fExport_Load);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.pnExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkteaManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbNameForm;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaPanel pnExcel;
        private Guna.UI.WinForms.GunaDataGridView dataExcel;
        private MilkteaManagementDataSet milkteaManagementDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private MilkteaManagementDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oVERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}