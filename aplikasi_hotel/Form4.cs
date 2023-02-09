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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nama.Text;
            string password = pss.Text;
            using (StreamWriter sw = new StreamWriter("userdb.txt", true))
            {
                sw.WriteLine(username + "," + password);
            }
            MessageBox.Show("Registasi Berhasil");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();/*untuk membuka form1*/
            this.Close();/*untuk mengklos form2*/
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
