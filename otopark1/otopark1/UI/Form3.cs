using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otopark1.DAL;
using otopark1.Interface;

namespace otopark1.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text!="" && textBox3.Text!="" && maskedTextBox1.Text!="")
            {
                string ad = textBox1.Text;
                string soyad = textBox2.Text;
                string tel = maskedTextBox1.Text;
                string mail = textBox3.Text;
                Musteri musteri = new Musteri();
                musteri.MusteriAd = ad;
                musteri.MusteriSoyad = soyad;
                musteri.MusteriTel = tel;
                musteri.MusteriMail = mail;
                musteri.MusteriKayitTarihi = DateTime.Now.Date;
                HelperMusteri hh = new HelperMusteri();
                bool m = hh.CUD(musteri, System.Data.Entity.EntityState.Added);
                MessageBox.Show(m == true ? "Müşteri Eklendi." : "Müşteri Eklenemedi...");
                
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                



        }
    }
}
