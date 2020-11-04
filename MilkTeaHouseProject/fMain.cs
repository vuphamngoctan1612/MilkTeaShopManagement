using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkteaHouse.bin.Debug.image;
using Guna.UI.WinForms;


namespace MilkTeaHouseProject
{
    public partial class fMain : Form
    {
        private GunaAdvenceButton currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Panel leftCurrentButton;

        public fMain()
        {
            InitializeComponent();
            random = new Random();
            leftCurrentButton = new Panel();
            leftCurrentButton.Size = new Size(10,53);
            panelControl.Controls.Add(leftCurrentButton);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(themeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(themeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = themeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (GunaAdvenceButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (GunaAdvenceButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTool.BackColor=btnExit.BackColor=btnMinimize.BackColor=btnZoom.BackColor = themeColor.ChangeColorBrightness(color, +0.3);
                    lbButtonSelected.ForeColor = Color.White;
                    leftCurrentButton.Location = new Point(0, currentButton.Location.Y+82);
                    leftCurrentButton.BackColor = color;
                    leftCurrentButton.Visible = true;
                    leftCurrentButton.BringToFront();
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in fpnControl.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaAdvenceButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.FromArgb(160, 160, 160);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDesktop.Controls.Add(childForm);
            this.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbButtonSelected.Text = childForm.Text;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Reset()
        {
            DisableButton();
            lbButtonSelected.Text = "HOME";
            lbButtonSelected.ForeColor = Color.White;
            currentButton = null;
            leftCurrentButton.Visible = false;
            pnTool.BackColor = btnExit.BackColor = btnMinimize.BackColor = btnZoom.BackColor = Color.White;
            lbButtonSelected.ForeColor = Color.Black;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fMenu(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOrder(), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fStaff(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fBill(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAccount);
            fAccount f = new fAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
