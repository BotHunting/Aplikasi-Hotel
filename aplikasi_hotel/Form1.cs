using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nama.Text;
            string password = pss.Text;
            using (StreamReader sr = new StreamReader("userdb.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] userData = line.Split(',');
                    if (username == userData[0] && password == userData[1])
                    {
                        MessageBox.Show("Login Sukses");
                        Form2 h = new Form2(); /*instantiasi hotel atau mendefinisikan sebuah kelas baru*/
                        h.Show(); /*perintah untuk menampilkan hotel.cs*/
                        this.Hide(); // untuk menyembunyikan form1
                        return;
                    }
                }
                MessageBox.Show("Maaf, username atau password salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); /* untuk mengakhiri aplikasi secara keseluruhan */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
