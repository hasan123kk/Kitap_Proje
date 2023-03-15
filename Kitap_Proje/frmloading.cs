using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_Proje
{
    public partial class frmloading : Form
    {
        public frmloading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            gunaProgressBar1.Value += 1;
            gunaProgressBar1.Text = gunaProgressBar1.Value.ToString();
            if (gunaProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Form1 fr = new Form1();
                fr.Show();
                Hide();

            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmloading_Load(object sender, EventArgs e)
        {
            gunaLabel3.Text = user.Name;
            this.Opacity -= 0.0;
            gunaProgressBar1.Value = 0;
            gunaProgressBar1.Minimum = 0;
            gunaProgressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
