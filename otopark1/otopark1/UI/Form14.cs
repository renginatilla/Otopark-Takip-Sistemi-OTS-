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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
       DataTable table;
        private void Form14_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Items.Add("Müşteri");
            comboBox1.Items.Add("Araç");
            comboBox1.Items.Add("Otopark");
            comboBox1.Items.Add("Ödeme");
            

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex==0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ad");
                comboBox2.Items.Add("Soyad");
               
                table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Ad", typeof(string));
                table.Columns.Add("Soyad", typeof(string));
                table.Columns.Add("Tel", typeof(string));
                table.Columns.Add("Kayıt Tarihi", typeof(DateTime));
                table.Columns.Add("mail", typeof(string));

                var list = HelperMusteri.GetMusteriList();
                foreach (var item in list)
                {                   
                    table.Rows.Add(item.MusteriID, item.MusteriAd, item.MusteriSoyad, item.MusteriTel, item.MusteriKayitTarihi, item.MusteriMail);                 
                }
                dataGridView1.DataSource = table;
                dataGridView1.Visible = true;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                //dataGridView1.Rows.Clear();
                //dataGridView1.Columns.Clear();
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Plaka");
                comboBox2.Items.Add("Marka");

              
                table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Plaka", typeof(string));
                table.Columns.Add("Marka", typeof(string));
                table.Columns.Add("Model", typeof(string));
                table.Columns.Add("Renk", typeof(string));
                table.Columns.Add("Müşteri", typeof(int));
                table.Columns.Add("AraçTip", typeof(int));

                var a = HelperArac.GetAracList();

                foreach (var item in a)
                {              
                    table.Rows.Add(item.AracID, item.AracPlaka, item.AracMarka, item.AracModel, item.AracRenk,item.MusteriID, item.AracTipi);
                }
                dataGridView1.DataSource = table;
                dataGridView1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Otopark Katlarındaki Araçlar");

                table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Giriş Tarihi", typeof(DateTime));
                table.Columns.Add("Çıkış Tarihi", typeof(DateTime));
                table.Columns.Add("OtoparkID", typeof(int));
                table.Columns.Add("AraçID", typeof(int));
                table.Columns.Add("Araç Plaka", typeof(string));


                var a = HelperOtoparkArac.otoparkmodellistbyotoparkid();
                
                foreach (var item in a)
                {
                    table.Rows.Add(item.AracOtoparkID, item.GirisSaati, item.CikisSaati, item.otopark.OtoparkID, item.arac.AracID, item.arac.AracPlaka);
                }
                dataGridView1.Visible = true;
                dataGridView1.DataSource = table;

            }
            else if(comboBox1.SelectedIndex==3)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Toplam Kazanç");
                comboBox2.Items.Add("Ödeme Sınrı");

                table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Araç Otopark ID", typeof(int));
                table.Columns.Add("Ödeme", typeof(int));
                table.Columns.Add("Tarih", typeof(DateTime));

                var a = OdemeHelper.odemelist();

                foreach (var item in a)
                {
                    table.Rows.Add(item.OdemeID, item.OtoparkID, item.Odeme1, item.Tarih);
                }
             
          
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = table;
                    
               
                //else
                //{
                //    textBox1.Clear();
                //    dataGridView1.Visible = false;
                //    label4.Visible = true;
                //    label5.Visible = true;
                //    label4.Text = "Toplam:";
                //    label5.Text = OdemeHelper.toplamkazanc().ToString();
                //}               
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            if (comboBox1.SelectedIndex==0)
            {
                if (comboBox2.SelectedIndex==0)
                {
                    dv.RowFilter = "Ad LIKE '" + textBox1.Text + "%'";
                }
                else
                    dv.RowFilter = "Soyad LIKE '" + textBox1.Text + "%'";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex==0)
                {
                    dv.RowFilter = "Plaka LIKE '" + textBox1.Text + "%'";
                }
                else
                    dv.RowFilter = "Marka LIKE '" + textBox1.Text + "%'";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dv.RowFilter = $"OtoparkID =  {Convert.ToInt32(textBox1.Text)}" ;
            }
            else
            {
                if (comboBox2.SelectedIndex==1)
                {
                dv.RowFilter = $"Ödeme >= {Convert.ToInt32(textBox1.Text)}" ;
                }
                else
                    textBox1.Text= OdemeHelper.toplamkazanc().ToString();

            }

            dataGridView1.DataSource = dv;
        }
    }
}
