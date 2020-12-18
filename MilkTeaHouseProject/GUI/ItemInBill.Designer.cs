
namespace MilkTeaHouseProject
{
    partial class ItemInBill
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(21, 21);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(71, 30);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDate.Location = new System.Drawing.Point(141, 21);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(71, 30);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "label1";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbStaffID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStaffID.Location = new System.Drawing.Point(591, 21);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(71, 30);
            this.lbStaffID.TabIndex = 0;
            this.lbStaffID.Text = "label1";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbStaffName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStaffName.Location = new System.Drawing.Point(758, 21);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(71, 30);
            this.lbStaffName.TabIndex = 0;
            this.lbStaffName.Text = "label1";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbNote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNote.Location = new System.Drawing.Point(944, 21);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(71, 30);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "label1";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotal.Location = new System.Drawing.Point(1226, 21);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(71, 30);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "label1";
            // 
            // ItemInBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbStaffName);
            this.Controls.Add(this.lbStaffID);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemInBill";
            this.Size = new System.Drawing.Size(1381, 67);
            this.SizeChanged += new System.EventHandler(this.ItemInBill_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbNote;
    }
}
