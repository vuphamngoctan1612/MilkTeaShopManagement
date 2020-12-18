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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.picFood = new Guna.UI.WinForms.GunaPictureBox();
            this.btnChoose = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.lbPrice);
            this.gunaShadowPanel1.Controls.Add(this.lbName);
            this.gunaShadowPanel1.Controls.Add(this.picFood);
            this.gunaShadowPanel1.Controls.Add(this.btnChoose);
            resources.ApplyResources(this.gunaShadowPanel1, "gunaShadowPanel1");
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 6;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.gunaShadowPanel1.ShadowDepth = 80;
            this.gunaShadowPanel1.ShadowShift = 3;
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Click += new System.EventHandler(this.btnChoose_Click);
            this.lbPrice.MouseLeave += new System.EventHandler(this.btnChoose_MouseLeave);
            this.lbPrice.MouseHover += new System.EventHandler(this.btnChoose_MouseHover);
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Name = "lbName";
            this.lbName.Click += new System.EventHandler(this.btnChoose_Click);
            this.lbName.MouseLeave += new System.EventHandler(this.btnChoose_MouseLeave);
            this.lbName.MouseHover += new System.EventHandler(this.btnChoose_MouseHover);
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
            // btnChoose
            // 
            this.btnChoose.AnimationHoverSpeed = 0.07F;
            this.btnChoose.AnimationSpeed = 0.03F;
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnChoose.BorderColor = System.Drawing.Color.Transparent;
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
            this.btnChoose.OnPressedDepth = 0;
            this.btnChoose.Size = this.Size;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            this.btnChoose.MouseLeave += new System.EventHandler(this.btnChoose_MouseLeave);
            this.btnChoose.MouseHover += new System.EventHandler(this.btnChoose_MouseHover);
            // 
            // DrinkItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "DrinkItem";
            this.SizeChanged += new System.EventHandler(this.DrinkItem_SizeChanged);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaPictureBox picFood;
        private Guna.UI.WinForms.GunaGradientButton btnChoose;
    }
}
