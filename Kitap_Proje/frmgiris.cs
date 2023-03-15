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
using Kitap_Proje.entity;

namespace Kitap_Proje
{
    public partial class frmgiris : Form
    {
        kitapEntities db = new kitapEntities();
        public frmgiris()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void gunaPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            var admin = db.kullanici.Where(x => x.kullanici_adi == gunaTextBox1.Text && x.sifre == gunaTextBox2.Text).FirstOrDefault();
            if (admin != null)
            {
                user.Name = gunaTextBox1.Text;
                frmloading fr = new frmloading();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            frmkayit fr = new frmkayit();
            fr.Show();
        }
    }
}
