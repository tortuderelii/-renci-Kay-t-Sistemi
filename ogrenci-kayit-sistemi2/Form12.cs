using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_kayit_sistemi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string userName = "Volkan";
        public string password = "12345";

       public bool passwordHold(bool a){
            
            
            if (a == true)
            {
                a = false;
                
            }

            else
            {
                a = true;
                
            }
            
            return a;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == userName && textBox2.Text == password)
            {
                Form4 giris = new Form4();
                giris.Show();
                this.Hide();

            }
            else
                MessageBox.Show("HATALI GİRİŞ");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = passwordHold(textBox2.UseSystemPasswordChar);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 sifre = new Form5();
            sifre.Show(this);
            this.Hide();
        }
    }
}
