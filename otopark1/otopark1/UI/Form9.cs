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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var a = HelperArac.GetArac(index);
                HelperArac helperArac = new HelperArac();
                bool m = helperArac.CUD(a, System.Data.Entity.EntityState.Deleted);
                MessageBox.Show(m == true ? "Araç silindi." : "Araç silinemedi...");
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Form9_Load(object sender, EventArgs e)
        {
            gridshow();
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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
