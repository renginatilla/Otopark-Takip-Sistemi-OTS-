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


namespace otopark1.UI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.Text != "")
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var a = HelperMusteri.GetMusteri(index);
                a.MusteriAd = textBox1.Text;
                a.MusteriSoyad = textBox2.Text;
                a.MusteriTel = maskedTextBox1.Text;
                a.MusteriMail = textBox3.Text;
                HelperMusteri hm = new HelperMusteri();
                bool m = hm.CUD(a, System.Data.Entity.EntityState.Modified);
                gridshow();
                MessageBox.Show(m == true ? "Müşteri bilgileri güncellendi." : "Müşteri Bilgileri güncellenemedi.");
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            gridshow();
        }       
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
        }
        public void gridshow()
        {
            var list = HelperMusteri.GetMusteriList();
            int sayac = 0;
            foreach (var item in list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sayac].Cells[0].Value = item.MusteriID;
                dataGridView1.Rows[sayac].Cells[1].Value = item.MusteriAd;
                dataGridView1.Rows[sayac].Cells[2].Value = item.MusteriSoyad;
                dataGridView1.Rows[sayac].Cells[3].Value = item.MusteriTel;
                dataGridView1.Rows[sayac].Cells[4].Value = item.MusteriMail;
                dataGridView1.Rows[sayac].Cells[5].Value = item.MusteriKayitTarihi;
                sayac++;
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            clear();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
