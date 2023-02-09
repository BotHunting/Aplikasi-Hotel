using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;


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
            string a, b, c, d, combo1, combo2;
            int harga = 0, total, lama;
            double ppn;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            lama = Convert.ToInt16(combo2);
            d = dateTimePicker1.Text;

            if (combo1.Equals("VIP"))
            {
                textBox4.Text = "Kamar Mewah, Tv dan WIFI";
                harga = 300000;
            }
            else if (combo1.Equals("STANDART"))
            {
                textBox4.Text = "Kamar Mewah dan Tv";
                harga = 150000;
            }
            else if (combo1.Equals("HEMAT"))
            {
                textBox4.Text = "Kamar Mewah";
                harga = 100000;
            }

            if (harga == 0)
            {
                MessageBox.Show("Tipe kamar belum dipilih.");
                return;
            }

            total = (harga * lama);
            ppn = total * 0.1;
            total += (int)ppn;
            label15.Text = a;
            label16.Text = b;
            label17.Text = c;
            label18.Text = d;
            textBox5.Text = harga.ToString();
            textBox6.Text = ppn.ToString();
            textBox7.Text = total.ToString();
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
            label18.Text = "";
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
            label18.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();/*untuk membuka form1*/
            this.Close();/*untuk mengklos form2*/
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tolong = new Form3();
            tolong.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string namaFile = label15.Text + ".txt";
            using (StreamWriter file = new StreamWriter(namaFile, true))
            {
                file.WriteLine("Nama: " + label15.Text);
                file.WriteLine("Alamat: " + label16.Text);
                file.WriteLine("No. Telepon: " + label17.Text);
                file.WriteLine("Tanggal: " + label18.Text);
                file.WriteLine("Kelas: " + comboBox1.Text);
                file.WriteLine("Lama Menginap: " + comboBox2.Text + " Hari");
                file.WriteLine("Harga Kamar: Rp. " + textBox5.Text);
                file.WriteLine("PPN 10%: Rp. " + textBox6.Text);
                file.WriteLine("Total Harga: Rp. " + textBox7.Text);
                file.WriteLine("");
            }
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString("Nama: " + label15.Text, font, new SolidBrush(Color.Black), startX, startY);
            graphics.DrawString("Alamat: " + label16.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString("No. Telepon: " + label17.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 2);
            graphics.DrawString("Check In: " + label18.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 3);
            graphics.DrawString("Jenis Kamar: " + comboBox1.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 4);
            graphics.DrawString("Fasilitas: " + textBox4.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 5);
            graphics.DrawString("Lama Inap: " + comboBox2.Text + " Hari", font, new SolidBrush(Color.Black), startX, startY + offset * 6);
            graphics.DrawString("Harga: Rp. " + textBox5.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 7);
            graphics.DrawString("PPN 10%: Rp. " + textBox6.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 8);
            graphics.DrawString("Total Harga: Rp. " + textBox7.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 9);
            graphics.DrawString(" ", font, new SolidBrush(Color.Black), startX, startY + offset * 10);
            graphics.DrawString("Resepsionis", font, new SolidBrush(Color.Black), startX, startY + offset * 11);
            graphics.DrawString(" ", font, new SolidBrush(Color.Black), startX, startY + offset * 12);
            graphics.DrawString(" ", font, new SolidBrush(Color.Black), startX, startY + offset * 13);
            graphics.DrawString(" ", font, new SolidBrush(Color.Black), startX, startY + offset * 14);
            graphics.DrawString("..................", font, new SolidBrush(Color.Black), startX, startY + offset * 15);
        }
    }
}
