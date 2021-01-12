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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string Yeni;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            if (textBox1.Text == frm1.password)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    frm1.password = textBox2.Text;
                    frm1.Show();
                    this.Hide();
                }

            }
            else
                MessageBox.Show("Yanlış Şifre");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            textBox1.UseSystemPasswordChar = frm1.passwordHold(textBox1.UseSystemPasswordChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            textBox2.UseSystemPasswordChar = frm1.passwordHold(textBox2.UseSystemPasswordChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            textBox3.UseSystemPasswordChar = frm1.passwordHold(textBox3.UseSystemPasswordChar);
        }
    }
}
