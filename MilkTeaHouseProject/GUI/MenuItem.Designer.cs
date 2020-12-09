
namespace MilkTeaHouseProject
{
    partial class MenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItem));
            this.btnDelete = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientButton();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.picFood = new Guna.UI.WinForms.GunaPictureBox();
            this.lbId = new Guna.UI.WinForms.GunaLabel();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbCategory = new Guna.UI.WinForms.GunaLabel();
            this.lbOriginPrice = new Guna.UI.WinForms.GunaLabel();
            this.lbCount = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnDelete.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MilkTeaHouseProject.Properties.Resources.delete_bin_32px;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(1387, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.btnDelete.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(60, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnEdit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(173)))), ((int)(((byte)(82)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::MilkTeaHouseProject.Properties.Resources.pencil_24px;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(1173, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(203)))), ((int)(((byte)(63)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(60, 39);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrice.Location = new System.Drawing.Point(838, 35);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(60, 30);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price";
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.LightGray;
            this.picFood.BaseColor = System.Drawing.Color.White;
            this.picFood.Image = global::MilkTeaHouseProject.Properties.Resources.Toffee_nut_crunch_latte;
            this.picFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFood.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFood.InitialImage")));
            this.picFood.Location = new System.Drawing.Point(27, 3);
            this.picFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(60, 60);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 11;
            this.picFood.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbId.Location = new System.Drawing.Point(239, 20);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(34, 30);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbName.Location = new System.Drawing.Point(398, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(114, 30);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Drink Item";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCategory.Location = new System.Drawing.Point(620, 35);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(102, 30);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Category";
            // 
            // lbOriginPrice
            // 
            this.lbOriginPrice.AutoSize = true;
            this.lbOriginPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbOriginPrice.Location = new System.Drawing.Point(946, 35);
            this.lbOriginPrice.Name = "lbOriginPrice";
            this.lbOriginPrice.Size = new System.Drawing.Size(60, 30);
            this.lbOriginPrice.TabIndex = 12;
            this.lbOriginPrice.Text = "Price";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCount.Location = new System.Drawing.Point(1049, 32);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(60, 30);
            this.lbCount.TabIndex = 12;
            this.lbCount.Text = "Price";
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbOriginPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(1528, 67);
            this.SizeChanged += new System.EventHandler(this.MenuItem_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnDelete;
        private Guna.UI.WinForms.GunaGradientButton btnEdit;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaPictureBox picFood;
        private Guna.UI.WinForms.GunaLabel lbId;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbCategory;
        private Guna.UI.WinForms.GunaLabel lbOriginPrice;
        private Guna.UI.WinForms.GunaLabel lbCount;
    }
}
