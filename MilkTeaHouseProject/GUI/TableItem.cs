using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject.DTO
{
    public partial class TableItem : UserControl
    {
        private int id;
        private string nameTable;
        private bool status;
        private string nameGroup;
        private bool flag;
        private Color backColor;

        public int ID { get => id; set => id = value; }
        public string NameTable { get => nameTable; set => nameTable = value; }
        public bool Status { get => status; set => status = value; }
        public string NameGroup { get => nameGroup; set => nameGroup = value; }
        public bool FLAG { get => flag; set => flag = value; }

        public TableItem(int id, string name, bool status, string namegroup, Color Color)
        {
            InitializeComponent();
            lbName.Text = name;
            lbID.Text = id.ToString();

            ID = id;
            NameTable = name;
            Status = status;
            this.BackColor = backColor = Color;
            nameGroup = namegroup;
        }

        public void LoadBackColor(Color color)
        {
            backColor = color;
        }

        private void TableItem_Load(object sender, EventArgs e)
        {
            this.btnChoose.Size = this.Size;
            this.lbName.Location = new Point((this.Width - lbName.Width) / 2, lbName.Location.Y);
            this.lbName.ForeColor = Color.Black;

            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }

        public void ChangeBackcolor()
        {
            this.BackColor = Color.FromArgb(0, 144, 218);
            this.PicTable2.BringToFront();
            this.lbName.ForeColor = Color.White;
        }

        public void ResetBackcolor()
        {
            this.BackColor = backColor;
            this.picTable1.BringToFront();
            this.lbName.ForeColor = Color.Black;
        }

        public event EventHandler onChoose = null;
        public bool Selected = false;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (onChoose != null)
            {
                onChoose.Invoke(this, new EventArgs());
            }
        }

        private void btnChoose_MouseHover(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(112, 195, 235);

            if (Selected == false)
                this.BackColor = color;
        }

        private void btnChoose_MouseLeave(object sender, EventArgs e)
        {
            Color color = backColor;

            if (Selected == false)
                this.BackColor = color;
        }

        private void TableItem_BackColorChanged(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(255, 255, 255) || this.BackColor == Color.FromArgb(250, 204, 206))
            {
                this.picTable1.BringToFront();
                this.lbName.ForeColor = Color.Black;
            }
            else
            {
                this.PicTable2.BringToFront();
                this.lbName.ForeColor = Color.White;
            }
        }
    }
}
