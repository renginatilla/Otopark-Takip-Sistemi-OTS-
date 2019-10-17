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
using otopark1.BL;

namespace otopark1.UI
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            gridshow();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                HelperOtoparkArac helper = new HelperOtoparkArac();
                var a = HelperOtoparkArac.GetAracOtopark(id);
                a.CikisSaati = DateTime.Now;

                bool m = helper.CUD(a, System.Data.Entity.EntityState.Modified);
                gridshow();
                label2.Visible = true;
                label2.Text = a.AracID.ToString();
                label3.Text = a.CikisSaati.ToString();
                label4.Text = a.GirisSaati.ToString();
                var x = (a.CikisSaati - a.GirisSaati).Value.Hours;
                label5.Text = x.ToString();
                int id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                var model = HelperArac.GetAracModel(id2);
                if (radioButton1.Checked ==true)
                {
                    label6.Text = (x * model.tarife.Fiyat).ToString();
                }
                else if (radioButton1.Checked == false)
                {                 
                    switch (model.tarife.AracTipi)
                    {
                        case (int)aractip.minibüs:
                            {
                                label6.Text = 400.ToString();
                                break;
                            }
                        case (int)aractip.otobüs:
                            {
                                label6.Text = 500.ToString();
                                break;
                            }
                        case (int)aractip.otomobil:
                            {
                                label6.Text = 300.ToString();
                                break;
                            }
                        case (int)aractip.motor:
                            {
                                label6.Text = 250.ToString();
                                break;
                            }
                        default:
                            break;
                    }

                }
                else
                    MessageBox.Show("geçersiz tarife");
                Odeme odeme = new Odeme();
                OdemeHelper helper1 = new OdemeHelper();
                odeme.OtoparkID = id;
                odeme.Odeme1 = Convert.ToInt32(label6.Text);
                odeme.Tarih = DateTime.Now;
                helper1.CUD(odeme, System.Data.Entity.EntityState.Added);

                if (radioButton1.Checked==true)
                {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;

                }
                else
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                }
                

            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }
        public void gridshow()
        {
            var list = HelperOtoparkArac.otoparkmodellist();
            int sayac = 0;
            foreach (var item in list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sayac].Cells[0].Value = item.AracOtoparkID;
                dataGridView1.Rows[sayac].Cells[1].Value = item.arac.AracID;
                dataGridView1.Rows[sayac].Cells[2].Value = item.arac.AracPlaka;
                dataGridView1.Rows[sayac].Cells[3].Value = item.GirisSaati;
                dataGridView1.Rows[sayac].Cells[4].Value = item.CikisSaati;
                dataGridView1.Rows[sayac].Cells[5].Value = item.musteri.MusteriID;
                dataGridView1.Rows[sayac].Cells[6].Value = item.musteri.MusteriAd;
                dataGridView1.Rows[sayac].Cells[7].Value = item.musteri.MusteriSoyad;
                dataGridView1.Rows[sayac].Cells[8].Value = item.otopark.OtoparkID;
                sayac++;
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            label8.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

        }
    }
}
