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
using otopark1.UI;
using otopark1.BL;

namespace otopark1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string kulaniciad = textBox1.Text;
                string kulanicisifre = textBox2.Text;
                var a = HelperAdmin.GetAdmin(kulaniciad, kulanicisifre);
                if (a != null)
                {
                    Form2 frm = new Form2();
                    formclass.adminname = kulaniciad;
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("giriş başarısız");
            }
            else
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
