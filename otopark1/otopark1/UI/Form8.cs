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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox5.Visible = false;

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

            gridshow();
        }
        //int id;
        public void gridshow()
        {
            var a=HelperArac.GetAracList();
            int sayac = 0;
            
            foreach (var item in a)
            {

                dataGridView2.Rows.Add();
                dataGridView2.Rows[sayac].Cells[0].Value = item.AracID;
                dataGridView2.Rows[sayac].Cells[1].Value = item.AracPlaka;
                dataGridView2.Rows[sayac].Cells[2].Value = item.AracMarka;
                dataGridView2.Rows[sayac].Cells[3].Value = item.AracModel;
                dataGridView2.Rows[sayac].Cells[4].Value = item.AracRenk;
                dataGridView2.Rows[sayac].Cells[5].Value = item.AracTipi;
                dataGridView2.Rows[sayac].Cells[6].Value = item.MusteriID;
                sayac++;
            }
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" )
            {
                int id = Convert.ToInt32(textBox5.Text);
                var a = HelperArac.GetArac(id);
                a.AracPlaka = textBox1.Text;
                a.AracMarka = textBox2.Text;
                a.AracModel = textBox3.Text;
                a.AracRenk = textBox4.Text;
                a.AracTipi = (int)(comboBox1.SelectedIndex) + 1;
                a.MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                HelperArac arac = new HelperArac();
                bool m = arac.CUD(a, System.Data.Entity.EntityState.Modified);
                gridshow();
                MessageBox.Show(m == true ? "Araç Bilgileri Güncellendi." : "Araç Bilgileri Güncellenemedi...");
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void DataGridView2_Click(object sender, EventArgs e)
        {
            clear();
            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
