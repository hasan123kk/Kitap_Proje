using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitap_Proje.entity;

namespace Kitap_Proje.forms
{
    public partial class frmistatistik : Form
    {
        kitapEntities db = new kitapEntities();
        public frmistatistik()
        {
            InitializeComponent();
        }

        void listele()
        {
            var d1 = db.kayit.GroupBy(x => x.o_ad).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblogrenci.Text = db.ogrenciler.Where(x => x.ID == d1).Select(y => y.ogrenci_adi).FirstOrDefault().ToString();
            lblsinif.Text = db.siniflar.Where(x => x.ID == db.ogrenciler.Where(t => t.ID == d1).Select(z => z.sinifi).FirstOrDefault()).Select(y => y.sinif_adi).FirstOrDefault().ToString();
            var d2 = db.kayit.GroupBy(x => x.gorevli).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblogrtmen.Text = db.kullanici.Where(x => x.ID == d2).Select(y => y.kullanici_adi).FirstOrDefault().ToString();

            int Devam_eden = db.kayit.Where(x => x.durum == true).Count();
            int Teslim_edilmiş = db.kayit.Where(x => x.durum == false).Count();

            chartControl1.Series["okuma_oranı"].Points.AddPoint("Devam_eden", Devam_eden);
            chartControl1.Series["okuma_oranı"].Points.AddPoint("Teslim_edilmiş", Teslim_edilmiş);
        }
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
