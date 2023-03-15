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
    public partial class frmanasayfa : Form
    {
        kitapEntities db = new kitapEntities();
        public frmanasayfa()
        {
            InitializeComponent();
        }
       
        void listele()
        {
            var d1 =(from x in db.ogrenciler
                     select new
                     {
                         x.ID,
                         x.ogrenci_adi
                     }).ToList();
            lookUpEdit3.Properties.ValueMember = "ID";
            lookUpEdit3.Properties.DisplayMember = "ogrenci_adi";
            lookUpEdit3.Properties.DataSource = d1;


            var d2 = (from y in db.kullanici
                      select new
                      {
                          y.ID,
                          y.kullanici_adi
                      }).ToList();
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "kullanici_adi";
            lookUpEdit2.Properties.DataSource = d2;

            var d3 = (from z in db.kitaplar
                      select new
                      {
                          z.ID,
                          z.kitap_Adi
                      }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "kitap_Adi";
            lookUpEdit1.Properties.DataSource = d3;


           
        }
        void liste()
        {
            dataGridView1.DataSource = (from p in db.kayit
                                        select new
                                        {
                                            p.ID,
                                            p.o_ad,
                                            p.gorevli,
                                            p.kitap,
                                            p.tarih
                                        }).ToList();
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            liste();
            listele();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }

        // kitap ver
        private void button5_Click(object sender, EventArgs e)
        {
            if (lookUpEdit3.Text == "" && lookUpEdit2.Text == "" && lookUpEdit1.Text == "" && txttarih.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kayit t = new kayit();
                t.o_ad = int.Parse(lookUpEdit3.EditValue.ToString());
                t.gorevli = int.Parse(lookUpEdit2.EditValue.ToString());
                t.kitap = int.Parse(lookUpEdit1.EditValue.ToString());
                t.tarih = Convert.ToDateTime(txttarih.Text);
                db.kayit.Add(t);
                db.SaveChanges();
                MessageBox.Show("kitap başarılı bir şekilde kaydedilmiştir.", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liste();
        }
    }
}
