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
    public partial class frmkayit : Form
    {
        kitapEntities db = new kitapEntities();
        public frmkayit()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == gunaTextBox3.Text)
            {
                kullanici t = new kullanici();
                t.kullanici_adi = gunaTextBox1.Text;
                t.sifre = gunaTextBox2.Text;
                db.kullanici.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı sisteme başarılı bir şekilde kaydedilmiştir.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
