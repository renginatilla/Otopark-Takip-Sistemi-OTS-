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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            gridshow();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                HelperMusteri hh = new HelperMusteri();
                bool m = hh.CUD(HelperMusteri.GetMusteri(index), System.Data.Entity.EntityState.Deleted);
                gridshow();
                MessageBox.Show(m == true ? "Müşteri Silindi." : "Müşteri Silinemedi...");
                         
        }

        public void gridshow()
        {
            dataGridView1.Rows.Clear();
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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
