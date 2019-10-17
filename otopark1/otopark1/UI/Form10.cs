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
using otopark1.Model;

namespace otopark1.UI
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           var a= HelperArac.AracModelList();
            int sayac = 0;
            foreach (var item in a)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sayac].Cells[0].Value = item.AracID;
                dataGridView1.Rows[sayac].Cells[1].Value = item.AracPlaka;
                dataGridView1.Rows[sayac].Cells[2].Value = item.AracMarka;
                dataGridView1.Rows[sayac].Cells[3].Value = item.AracModel1;
                dataGridView1.Rows[sayac].Cells[4].Value = item.musteri.MusteriAd;
                dataGridView1.Rows[sayac].Cells[5].Value = item.musteri.MusteriSoyad;
                dataGridView1.Rows[sayac].Cells[6].Value = item.tarife.Tip;
                sayac++;
            }
        }
    }
}
