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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        bool yervarmi = true;
        private void Form12_Load(object sender, EventArgs e)
        {
            gridshow();
            parkyeri(0,1);
            parkyeri(1,2);
            parkyeri(2,3);
 

        }
        public void gridshow()
        {
            dataGridView1.Rows.Clear();
            var a = HelperArac.GetAracList();
            int sayac = 0;
            foreach (var item in a)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sayac].Cells[0].Value = item.AracID;
                dataGridView1.Rows[sayac].Cells[1].Value = item.AracPlaka;
                dataGridView1.Rows[sayac].Cells[2].Value = item.AracMarka;
                dataGridView1.Rows[sayac].Cells[3].Value = item.AracModel;
                dataGridView1.Rows[sayac].Cells[4].Value = item.AracRenk;
                sayac++;
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                AracOtopark arac = new AracOtopark()
                {
                    AracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    OtoparkID = tabControl1.SelectedIndex + 1,
                    GirisSaati = DateTime.Now
                };
                HelperOtoparkArac helper = new HelperOtoparkArac();
                if (yervarmi)
                {
                    bool m = helper.CUD(arac, System.Data.Entity.EntityState.Added);
                    MessageBox.Show("Otoparka araç eklendi.");
                }
                else
                    MessageBox.Show("Otoparka araç eklenemedi.");
                parkyeri(0, 1);
                parkyeri(1, 2);
                parkyeri(2, 3);
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        public void parkyeri(int tab, int index)
        {
            int sayi = HelperOtoparkArac.GetAracOtoparkListbyotoparkid(index);

            int sayac = 1;
            var otopark = HelperOtopark.GetOtopark(index);
            foreach (Control item in tabControl1.TabPages[tab].Controls)
            {               
                    if (item is Button)
                    {
                        item.BackColor = Color.Green;
                        item.Height = 40;
                        item.Width = 60;
                        item.Text = "P-" + sayac;
                        item.Name = "P-" + sayac;
                        sayac++;
                    }
                    if (sayi > 0)
                    {                 
                        item.BackColor = Color.Red;
                        sayi--;
                    }
                
            }
            if (sayac>=otopark.Kapasite)
            {
                yervarmi = false;
            }
           
        }
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = (tabControl1.SelectedIndex+1).ToString();
        }
    }
}
