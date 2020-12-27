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
using MilkTeaHouseProject.GUI;
using MilkTeaHouseProject.DTO;
using System.IO;
using System.Data.SqlClient;

namespace MilkTeaHouseProject
{
    public partial class fMain : Form
    {
        private GunaAdvenceButton currentButton;
        private Form activeForm;
        private fMenu frmMenu;
        private fStaff frmStaff;
        private fBill frmBill;
        private fOrder frmOrder;
        private fRoomTable frmRoom;
        private bool flag = true;

        public fMain(string username)
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.lbDisplay.Text = "Hello, " + StaffDAL.Instance.GetNamebyUsername(username);
            this.lbDisplay.Location = new Point((this.pnContainName.Width - lbDisplay.Width) / 2, this.lbDisplay.Location.Y);
            this.lbUserName.Text = username;

            frmMenu = new fMenu(lbUserName.Text);
            frmStaff = new fStaff(lbUserName.Text);
            frmOrder = new fOrder(lbUserName.Text);
            frmBill = new fBill(lbUserName.Text);
            frmRoom = new fRoomTable(frmOrder);
            frmOrder.LoadFormRoom(frmRoom);
            frmOrder.LoadFormMenu(frmMenu);
            frmMenu.LoadFormOrder(frmOrder);

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
                this.btnMenu.Visible = false;
                this.btnStaff.Visible = false;
                this.btnBill.Visible = false;
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
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
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
            frmMenu.SendToBack();
            frmOrder.SendToBack();
            frmBill.SendToBack();
            frmStaff.SendToBack();
            frmRoom.SendToBack();
            DisableButton();
            lbButtonSelected.Text = "HOME";
            lbButtonSelected.ForeColor = Color.White;
            currentButton = null;
        }

        public void LoadAvatar(string username)
        {
            int id = StaffDAL.Instance.GetStaffIDbyUsername(username);
            Staff staff = StaffDAL.Instance.GetStaffById(id);

            byte[] image = staff.Image;
            if (image != null)
            {
                MemoryStream mstream = new MemoryStream(image);
                Bitmap bitmap = new Bitmap(mstream);
                avtToolStripMenuItem.Image = bitmap;
            }
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
            if (activeForm != frmMenu)
                OpenChildForm(frmMenu, sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (activeForm != frmOrder)
                OpenChildForm(frmOrder, sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (activeForm != frmStaff)
                OpenChildForm(frmStaff, sender);
        }

        private void btnRoomTable_Click(object sender, EventArgs e)
        {
            if (activeForm != frmRoom)
                OpenChildForm(frmRoom, sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (activeForm != frmBill)
                OpenChildForm(frmBill, sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(this.lbUserName.Text);
            f.ShowDialog();
            this.Show();
        }
        private void lbName_Click(object sender, EventArgs e)
        {
            activeForm = null;
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewPro5_Click(object sender, EventArgs e)
        {
            DataRow dr = StaffDAL.Instance.GetStaff(this.lbUserName.Text);
            if (dr.Table.Rows.Count > 0)
            {
                DTO.Staff staff = new DTO.Staff(dr);
                fViewProfile frm = new fViewProfile(staff.ID, staff.Name, staff.BirthDate, staff.Position, staff.PhoneNumber, staff.Image);
                frm.ShowDialog();
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadAvatar(lbUserName.Text);
        }

        private void fMain_Shown(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnViewPro5_Click(sender, e);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAccount_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                gunaLabel4.Text = BillDAL.Instance.CountBillSellinginDay().ToString();
                lbCountbill.Text = BillDAL.Instance.CountBillSoldinDay().ToString();
                gunaLabel2.Text = "Hôm qua: " + BillDAL.Instance.CountBillSoldinYesrerday().ToString();
            }
            catch (SqlException)
            {
                if (flag == true)
                {
                    flag = false;
                    string message = "Ngắt kết nối, bạn có muốn tắt thoát chương trình!";
                    string title = "Close Window";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    //else
                    //{
                    //    flag = true;

                    //}
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer1.Dispose();

                    //MessageBox.Show("Ngắt kết nối");
                    return;
                }
            }
        }
        #endregion
    }
}
