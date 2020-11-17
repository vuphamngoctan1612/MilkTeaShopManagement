
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItem));
            this.btnEdit = new Guna.UI.WinForms.GunaGradientButton();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.picFood = new Guna.UI.WinForms.GunaPictureBox();
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.lbId = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnEdit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(218)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(1025, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(130)))), ((int)(((byte)(137)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(92, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrice.Location = new System.Drawing.Point(727, 27);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(54, 25);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Price";
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.LightGray;
            this.picFood.BaseColor = System.Drawing.Color.White;
            this.picFood.Image = global::MilkTeaHouseProject.Properties.Resources.Toffee_nut_crunch_latte;
            this.picFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFood.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFood.InitialImage")));
            this.picFood.Location = new System.Drawing.Point(15, 10);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(68, 57);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 6;
            this.picFood.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbName.Location = new System.Drawing.Point(428, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 25);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Drink Item";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbId.Location = new System.Drawing.Point(212, 27);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(32, 25);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnDelete.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(1215, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnDelete.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(1358, 79);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnEdit;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaPictureBox picFood;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaLabel lbId;
        private Guna.UI.WinForms.GunaGradientButton btnDelete;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
