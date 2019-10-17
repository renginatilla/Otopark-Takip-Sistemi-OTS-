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
using otopark1.BL;
using otopark1.Model;

namespace otopark1.UI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(aractip.motor);
            comboBox1.Items.Add(aractip.otomobil);
            comboBox1.Items.Add(aractip.minibüs);
            comboBox1.Items.Add(aractip.otobüs);
           
            var list = HelperMusteri.GetMusteriList();
            int sayac = 0;
            foreach (var item in list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sayac].Cells[0].Value = item.MusteriID;
                dataGridView1.Rows[sayac].Cells[1].Value = item.MusteriAd;
                dataGridView1.Rows[sayac].Cells[2].Value = item.MusteriSoyad;

                sayac++;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" )
            {
                Arac arac = new Arac()
                {
                    AracPlaka = textBox1.Text,
                    AracMarka = textBox2.Text,
                    AracModel = textBox3.Text,
                    AracRenk = textBox4.Text,
                    AracTipi = (int)(comboBox1.SelectedIndex) + 1,
                    MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                };
                HelperArac h = new HelperArac();
                bool m = h.CUD(arac, System.Data.Entity.EntityState.Added);
                MessageBox.Show(m == true ? "Araç Eklendi" : "Araç Eklenemedi");
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
