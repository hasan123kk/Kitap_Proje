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
    public partial class frmkitaplar : Form
    {

        kitapEntities db = new kitapEntities(); 

        public frmkitaplar()
        {
            InitializeComponent();
        }

        void degerler()
        {
            dataGridView1.DataSource = (from x in db.kitaplar
                                        select new
                                        {
                                            x.ID,
                                            x.kitap_Adi,
                                            x.kitap_sayisi,
                                            x.yazar
                                        }).ToList();
        }

        private void frmkitaplar_Load(object sender, EventArgs e)
        {
            degerler();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            degerler();
        }

        // EKLE
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" && txtsayi.Text == "" && txtyazar.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kitaplar t = new kitaplar();
                t.kitap_Adi = txtad.Text;
                t.kitap_sayisi = txtsayi.Text;
                t.yazar = txtyazar.Text;
                db.kitaplar.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kitap başarılı bir şekilde kaydedilmiştir.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
