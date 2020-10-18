﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();            
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnScreen.Controls.Clear();
            fMenu f1 = new fMenu();
            f1.TopLevel = false;
            pnScreen.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnScreen.Controls.Clear();
            fListStaff frm = new fListStaff();
            frm.TopLevel = false;
            pnScreen.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void bảngLươngThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnScreen.Controls.Clear();
            fSalary frm = new fSalary();
            frm.TopLevel = false;
            pnScreen.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
                System.Windows.Forms.Application.Exit();
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnScreen.Controls.Clear();
            fListBill frm = new fListBill();
            frm.TopLevel = false;
            pnScreen.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSignUp fSignUp = new fSignUp();
            this.Hide();
            fSignUp.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword frm = new fChangePassword();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            this.menuToolStripMenuItem1_Click(sender, e);   
        }
    }
}