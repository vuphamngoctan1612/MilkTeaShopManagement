namespace MilkTeaHouseProject
{
    partial class BillItem
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
            this.lbFoodName = new Guna.UI.WinForms.GunaLabel();
            this.count = new Guna.UI.WinForms.GunaNumeric();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.lbTotal = new Guna.UI.WinForms.GunaLabel();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(3, 22);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(107, 30);
            this.lbFoodName.TabIndex = 0;
            this.lbFoodName.Text = "Food Item";
            // 
            // count
            // 
            this.count.BaseColor = System.Drawing.Color.White;
            this.count.BorderColor = System.Drawing.Color.Silver;
            this.count.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.count.ButtonForeColor = System.Drawing.Color.White;
            this.count.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.count.ForeColor = System.Drawing.Color.Black;
            this.count.Location = new System.Drawing.Point(154, 22);
            this.count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.count.Maximum = ((long)(9999999));
            this.count.Minimum = ((long)(0));
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(86, 30);
            this.count.TabIndex = 1;
            this.count.Text = "gunaNumeric1";
            this.count.Value = ((long)(1));
            this.count.ValueChanged += new System.EventHandler(this.count_ValueChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(310, 22);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 30);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(436, 22);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 30);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(38, 1);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 20);
            this.lbID.TabIndex = 3;
            this.lbID.Visible = false;
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.count);
            this.Controls.Add(this.lbFoodName);
            this.Margin = new System.Windows.Forms.Padding(22, 4, 3, 4);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(563, 71);
            this.Load += new System.EventHandler(this.BillItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbFoodName;
        private Guna.UI.WinForms.GunaNumeric count;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaLabel lbTotal;
        private System.Windows.Forms.Label lbID;
    }
}
