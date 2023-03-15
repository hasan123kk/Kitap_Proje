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
    public partial class frmsiniflar : Form
    {
        kitapEntities db = new kitapEntities();
        public frmsiniflar()
        {
            InitializeComponent();
        }
        void listele()
        {
            //sınıf listesi
            dataGridView1.DataSource = (from x in db.siniflar
                                        select new
                                        {
                                            x.ID,
                                            x.sinif_adi
                                        }).ToList();
            //öğrenci listesi
            dataGridView2.DataSource = (from x in db.ogrenciler
                                        select new
                                        {
                                            x.ID,
                                            x.ogrenci_adi,
                                            x.ogrenci_no,
                                            x.sinifi
                                        }).ToList();
        }
        void deger()
        {
            var d1 = (from x in db.siniflar
                            select new
                            {     
                                x.ID,
                                x.sinif_adi
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "sinif_adi";
            lookUpEdit1.Properties.DataSource = d1;
        }

        private void frmsiniflar_Load(object sender, EventArgs e)
        {
            listele();
            deger();
            dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            
        }

        // sınıf ekle
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsinifadi.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                siniflar t = new siniflar();
                t.sinif_adi = txtsinifadi.Text;
                db.siniflar.Add(t);
                db.SaveChanges();
                MessageBox.Show("Sınıf başarılı bir şekilde kaydedilmiştir.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listele();
        }

        // öğrenci ekle
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ogrenciler t = new ogrenciler();
                t.ogrenci_adi = textBox3.Text;
                t.ogrenci_no = textBox2.Text;
                t.sinifi = int.Parse(lookUpEdit1.EditValue.ToString());
                db.ogrenciler.Add(t);
                db.SaveChanges();
                MessageBox.Show("öğrenci başarılı bir şekilde kaydedilmiştir.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
