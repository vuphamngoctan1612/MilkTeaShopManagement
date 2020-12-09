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
using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject
{
    public partial class fMain : Form
    {
        private GunaAdvenceButton currentButton;
        private Form activeForm;
        private Panel leftCurrentButton;

        public fMain(string username)
        {
            InitializeComponent();

            leftCurrentButton = new Panel();
            leftCurrentButton.Size = new Size(10, 52);
            panelControl.Controls.Add(leftCurrentButton);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.lbDisplay.Text = "Hello, " + StaffDAL.Instance.GetNamebyUsername(username);
            this.lbDisplay.Location = new Point((this.pnContainName.Width - lbDisplay.Width) / 2, this.lbDisplay.Location.Y);
            this.lbUserName.Text = username;
            Enable();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Methods

        private void Enable()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(string.Format("select * from Account where username = '{0}'", lbUserName.Text));

            DataRow dr = dt.Rows[0];

            DTO.Account acc = new DTO.Account(dr);

            bool status = acc.Type;

            if (status == true)
            {
                this.btnMenu.Enabled = false;
                this.btnStaff.Enabled = false;
                this.btnBill.Enabled = false;
            }    
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (GunaAdvenceButton)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(255, 255, 255);
                    currentButton = (GunaAdvenceButton)btnSender;
                    currentButton.BaseColor = Color.FromArgb(0, 144, 218);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    leftCurrentButton.Location = new Point(0, currentButton.Location.Y + 177);
                    leftCurrentButton.BackColor = color;
                    leftCurrentButton.Visible = true;
                    leftCurrentButton.BringToFront();
                }
            }
        }
        private void DisableButton()
        {
            foreach (GunaAdvenceButton previousBtn in fpnControl.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaAdvenceButton))
                {
                    previousBtn.BaseColor = Color.FromArgb(28, 29, 38);
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
        private void Reset()
        {
            DisableButton();
            lbButtonSelected.Text = "HOME";
            lbButtonSelected.ForeColor = Color.White;
            currentButton = null;
            leftCurrentButton.Visible = false;
            
        }
        #endregion

        #region Events
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

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fMenu(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOrder(this.lbUserName.Text), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fStaff(lbUserName.Text), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fBill(lbUserName.Text), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(this.lbUserName.Text);
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
            Application.Exit();
        }

        private void pnHomePage_SizeChanged(object sender, EventArgs e)
        {

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPro5_Click(object sender, EventArgs e)
        {
            DTO.Staff staff = StaffDAL.Instance.GetStaff(this.lbUserName.Text);
            fViewProfile frm = new fViewProfile(staff.ID, staff.Name, staff.BirthDate, staff.Position, staff.PhoneNumber, staff.Image);
            frm.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }
        private void fMain_Shown(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
