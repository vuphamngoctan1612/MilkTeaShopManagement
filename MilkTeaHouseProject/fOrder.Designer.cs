namespace MilkTeaHouseProject
{
    partial class fOrder
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
            this.flowLayoutPanelDrinks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDrinks
            // 
            this.flowLayoutPanelDrinks.AutoScroll = true;
            this.flowLayoutPanelDrinks.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelDrinks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDrinks.Name = "flowLayoutPanelDrinks";
            this.flowLayoutPanelDrinks.Size = new System.Drawing.Size(854, 695);
            this.flowLayoutPanelDrinks.TabIndex = 0;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 695);
            this.Controls.Add(this.flowLayoutPanelDrinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fOrder";
            this.Text = "ĐẶT HÀNG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDrinks;
    }
}