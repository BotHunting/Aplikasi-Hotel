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
            string a = pss.Text;
            if (a.Equals("hotel"))
            {
                MessageBox.Show("Login Sukses");
                Form2 h = new Form2();/*instatiasi hotel atau mendefenisikan sebuah kelas baru*/
                h.Show();/*perintah unruk menampilkan hotel.cs*/
                this.Hide();// untuk menyembunyikan form1
            }
            else
            {
                MessageBox.Show("maaf password salah");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            pss.Text = "";
        }
    }
}
