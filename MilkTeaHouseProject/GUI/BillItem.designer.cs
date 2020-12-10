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
            this.components = new System.ComponentModel.Container();
            this.lbFoodName = new Guna.UI.WinForms.GunaLabel();
            this.count = new Guna.UI.WinForms.GunaNumeric();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.lbTotal = new Guna.UI.WinForms.GunaLabel();
            this.lbDrinkID = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnDel = new Guna.UI.WinForms.GunaCircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbFoodName.Location = new System.Drawing.Point(50, 21);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(113, 30);
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
            this.count.Location = new System.Drawing.Point(220, 12);
            this.count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.count.Maximum = ((long)(9999999));
            this.count.Minimum = ((long)(0));
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(72, 30);
            this.count.TabIndex = 1;
            this.count.Text = "gunaNumeric1";
            this.count.Value = ((long)(1));
            this.count.ValueChanged += new System.EventHandler(this.count_ValueChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPrice.Location = new System.Drawing.Point(340, 21);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPrice.Size = new System.Drawing.Size(60, 30);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbTotal.Location = new System.Drawing.Point(450, 21);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotal.Size = new System.Drawing.Size(59, 30);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total";
            // 
            // lbDrinkID
            // 
            this.lbDrinkID.AutoSize = true;
            this.lbDrinkID.Enabled = false;
            this.lbDrinkID.Location = new System.Drawing.Point(38, 1);
            this.lbDrinkID.Name = "lbDrinkID";
            this.lbDrinkID.Size = new System.Drawing.Size(0, 20);
            this.lbDrinkID.TabIndex = 3;
            this.lbDrinkID.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnDel
            // 
            this.btnDel.AnimationHoverSpeed = 0.07F;
            this.btnDel.AnimationSpeed = 0.03F;
            this.btnDel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.btnDel.BorderColor = System.Drawing.Color.Black;
            this.btnDel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDel.FocusedColor = System.Drawing.Color.Empty;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::MilkTeaHouseProject.Properties.Resources.Delete2;
            this.btnDel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDel.Location = new System.Drawing.Point(563, 12);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDel.OnHoverImage = null;
            this.btnDel.OnPressedColor = System.Drawing.Color.Black;
            this.btnDel.Size = new System.Drawing.Size(40, 40);
            this.btnDel.TabIndex = 4;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 3);
            this.panel1.TabIndex = 6;
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbDrinkID);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.count);
            this.Controls.Add(this.lbFoodName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(635, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbFoodName;
        private Guna.UI.WinForms.GunaNumeric count;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaLabel lbTotal;
        private System.Windows.Forms.Label lbDrinkID;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleButton btnDel;
        private System.Windows.Forms.Panel panel1;
    }
}
