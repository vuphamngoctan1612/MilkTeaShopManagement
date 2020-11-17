using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace MilkTeaHouseProject
{
    public partial class fEditDrink : Form
    {
        public fEditDrink(int drink)
        {
            InitializeComponent();
            lbShowId.Text = drink.ToString();
            LoadingInfo();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-EV76EB0\\SQLEXPRESS;Initial Catalog=MilkteaManagement;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;
        byte[] img = null;

        private void ptbImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbImg.ImageLocation = imgLocation;
                ptbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadingInfo()
        {
            connect.Open();
            string sqlQuery = "SELECT * FROM Drink WHERE ID='" + lbShowId.Text + "'";
            cmd = new SqlCommand(sqlQuery, connect);
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                lbShowId.Text = dataReader[0].ToString();
                txtNameDrink.Text = dataReader[1].ToString();
                txtPrice.Text = dataReader[2].ToString();
                if (!Convert.IsDBNull(dataReader[3]))
                    img = (byte[])dataReader[3];
                if (img == null)
                {
                    ptbImg.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(img);
                    Bitmap bitmap = new Bitmap(mstream);
                    ptbImg.Image = bitmap;
                    ptbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            connect.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (ptbImg.Image == null)
                {
                    if (imgLocation == "")
                    {
                        LoadImage();
                    }
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bnr = new BinaryReader(stream);
                    img = bnr.ReadBytes((int)stream.Length);
                }
                else
                {
                    if (imgLocation != "")
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader bnr = new BinaryReader(stream);
                        img = bnr.ReadBytes((int)stream.Length);
                    }
                }
                if (txtNameDrink.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên món");
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá");
                }
                else
                {
                    connect.Open();
                    string sqlQuery = "UPDATE Drink SET Name = '" + txtNameDrink.Text + "', Price = " + txtPrice.Text + ", Image = @img WHERE ID = '" + lbShowId.Text + "'";
                    cmd = new SqlCommand(sqlQuery, connect);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Cập nhật thành công");
                }
        }
        private void LoadImage()
        {
            imgLocation = "./images/kawaii_coffee_64px.png";
        }
    }
}
