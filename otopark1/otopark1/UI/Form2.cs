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


namespace otopark1.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Hoşgeldin "+formclass.adminname.ToUpper()+" ";
            //toolStripSplitButton1.Image = Image.FromFile(@"C:\Users\rengin atilla\Desktop\06.09\otopark1\otopark1\Image\musteriicon.png");
            //pictureBox1.Image = Image.FromFile(@"C:\Users\rengin atilla\Desktop\06.09\otopark1\otopark1\Image\Otopark.png");
            //toolStripSplitButton2.Image = Image.FromFile(@"C:\Users\rengin atilla\Desktop\06.09\otopark1\otopark1\Image\Car-2-icon.png");
        }

        private void MüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();           
        }

        private void MüşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void MüşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void AraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7= new Form7();
            form7.Show();
        }

        private void AraçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void AraçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void MüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }
    }
}
