namespace MilkTeaHouseProject
{
    partial class DrinkItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkItem));
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.btnChoose = new Guna.UI.WinForms.GunaGradientButton();
            this.picFood = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Name = "lbPrice";
            // 
            // btnChoose
            // 
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.AnimationHoverSpeed = 0.07F;
            this.btnChoose.AnimationSpeed = 0.03F;
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnChoose.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnChoose.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnChoose.BorderColor = System.Drawing.Color.Black;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChoose.FocusedColor = System.Drawing.Color.Empty;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnChoose.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnChoose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoose.OnHoverImage = null;
            this.btnChoose.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // picFood
            // 
            resources.ApplyResources(this.picFood, "picFood");
            this.picFood.BackColor = System.Drawing.Color.LightGray;
            this.picFood.BaseColor = System.Drawing.Color.White;
            this.picFood.Image = global::MilkTeaHouseProject.Properties.Resources.Toffee_nut_crunch_latte;
            this.picFood.Name = "picFood";
            this.picFood.TabStop = false;
            // 
            // DrinkItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lbName);
            this.Name = "DrinkItem";
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaGradientButton btnChoose;
        private Guna.UI.WinForms.GunaPictureBox picFood;
    }
}
