using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_hotel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, combo1, combo2;
            int harga, ppn, total, lama;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            lama = Convert.ToInt16(combo2);
            if (combo1.Equals("VIP"))
            {
                textBox4.Text = "Kamar Mewah, Tv dan WIFI";
                harga = 700000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if (combo1.Equals("STANDART"))
            {
                textBox4.Text = "Kamar Mewah dan Tv";
                harga = 500000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if (combo1.Equals("HEMAT"))
            {
                textBox4.Text = "Kamar Mewah";
                harga = 300000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Close();/*untuk mengklos form1*/
            this.Close();/*untuk mengklos form hotelcs*/
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tolong = new Form3();
            tolong.Show();
        }
    }
}
