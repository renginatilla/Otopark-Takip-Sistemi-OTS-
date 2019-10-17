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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
    }
}
