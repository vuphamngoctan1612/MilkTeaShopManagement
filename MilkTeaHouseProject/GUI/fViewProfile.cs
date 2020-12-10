using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace MilkTeaHouseProject
{
    public partial class fViewProfile : Form
    {
        public fViewProfile(int ID, string name, DateTime BirthDate, string pos, string phone, byte[] img)
        {
            InitializeComponent();

            txtID.Text = ID.ToString();
            txtName.Text = name;
            txtBirth.Text = BirthDate.ToString("dd/M/yyyy");
            txtPos.Text = pos;
            txtPhone.Text = phone;
            if (img == null)
            {
                this.ptbImage.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(img);
                ptbImage.Image = Image.FromStream(mstream);
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
