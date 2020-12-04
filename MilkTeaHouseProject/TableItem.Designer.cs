
namespace MilkTeaHouseProject.DTO
{
    partial class TableItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableItem));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lbName = new Guna.UI.WinForms.GunaLabel();
            this.picTable1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnChoose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PicTable2 = new Guna.UI.WinForms.GunaPictureBox();
            this.lbID = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Name = "lbName";
            this.lbName.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // picTable1
            // 
            this.picTable1.BackColor = System.Drawing.Color.Transparent;
            this.picTable1.BaseColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picTable1, "picTable1");
            this.picTable1.Image = global::MilkTeaHouseProject.Properties.Resources.Table;
            this.picTable1.Name = "picTable1";
            this.picTable1.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.AnimationHoverSpeed = 0.05F;
            this.btnChoose.AnimationSpeed = 1E-05F;
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor = System.Drawing.Color.Transparent;
            this.btnChoose.BorderColor = System.Drawing.Color.Black;
            this.btnChoose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChoose.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChoose.CheckedForeColor = System.Drawing.Color.White;
            this.btnChoose.CheckedImage = null;
            this.btnChoose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.None;
            resources.ApplyResources(this.btnChoose, "btnChoose");
            this.btnChoose.FocusedColor = System.Drawing.Color.Transparent;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = null;
            this.btnChoose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoose.LineColor = System.Drawing.Color.White;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnChoose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoose.OnHoverImage = null;
            this.btnChoose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChoose.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoose.OnPressedDepth = 0;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            this.btnChoose.MouseLeave += new System.EventHandler(this.btnChoose_MouseLeave);
            this.btnChoose.MouseHover += new System.EventHandler(this.btnChoose_MouseHover);
            // 
            // PicTable2
            // 
            this.PicTable2.BackColor = System.Drawing.Color.Transparent;
            this.PicTable2.BaseColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PicTable2, "PicTable2");
            this.PicTable2.Image = global::MilkTeaHouseProject.Properties.Resources.TableWhile;
            this.PicTable2.Name = "PicTable2";
            this.PicTable2.TabStop = false;
            // 
            // lbID
            // 
            resources.ApplyResources(this.lbID, "lbID");
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Name = "lbID";
            this.lbID.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // TableItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picTable1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.PicTable2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TableItem";
            this.Load += new System.EventHandler(this.TableItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel lbName;
        private Guna.UI.WinForms.GunaPictureBox picTable1;
        private Guna.UI.WinForms.GunaAdvenceButton btnChoose;
        private Guna.UI.WinForms.GunaPictureBox PicTable2;
        private Guna.UI.WinForms.GunaLabel lbID;
    }
}
