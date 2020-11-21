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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkItem));
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.btnChoose = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.picFood = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Name = "lbName";
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.lbPrice.Name = "lbPrice";
            // 
            // btnChoose
            // 
            this.btnChoose.AnimationHoverSpeed = 0.07F;
            this.btnChoose.AnimationSpeed = 0.03F;
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnChoose.BorderColor = System.Drawing.Color.Black;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChoose.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = null;
            this.btnChoose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.btnChoose.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.btnChoose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoose.OnHoverImage = null;
            this.btnChoose.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            this.btnChoose.MouseLeave += new System.EventHandler(this.btnChoose_MouseLeave);
            this.btnChoose.MouseHover += new System.EventHandler(this.btnChoose_MouseHover);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // picFood
            // 
            resources.ApplyResources(this.picFood, "picFood");
            this.picFood.BackColor = System.Drawing.Color.LightGray;
            this.picFood.BaseColor = System.Drawing.Color.White;
            this.picFood.Image = global::MilkTeaHouseProject.Properties.Resources.drinkitem1;
            this.picFood.Name = "picFood";
            this.picFood.TabStop = false;
            // 
            // DrinkItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnChoose);
            this.Name = "DrinkItem";
            this.SizeChanged += new System.EventHandler(this.DrinkItem_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaGradientButton btnChoose;
        private Guna.UI.WinForms.GunaPictureBox picFood;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
