using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrenci_kayit_sistemi2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string Yeni;
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-3OR4605;Initial Catalog=OgrenciVerileri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("Update girisbilgisi Set sifre=@news Where kullaniciadi='" + textBox1.Text + "'", connect);
            cmd.Parameters.AddWithValue("@news", textBox2.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Şifre değiştirildi");
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
        }
    }
}
