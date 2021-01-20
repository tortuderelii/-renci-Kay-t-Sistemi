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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Veritabanına ulaşmamızı sağlayan komutlar
        
        SqlCommand command;
        SqlDataReader read;


       //Şifre görme ve kapama.
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
       SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3OR4605;Initial Catalog=OgrenciVerileri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

            conn.Open();
            command = new SqlCommand();
            
            command.Connection = conn;
            command.CommandText = "Select * from girisbilgisi where kullaniciadi='" + textBox1.Text + "'and sifre ='" + textBox2.Text + "'";
            //Okuyucu açıyoruz.
            read = command.ExecuteReader();
            //Şifre kontrolü sağlanıyor.
            if (read.Read())
            {
                MessageBox.Show("Giriş Onaylandı.");
                Form4 mainform = new Form4();
                mainform.Show(this);
                this.Hide();
            }
                
            else
                MessageBox.Show("Yanlış Şifre");
            conn.Close();
            

            
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
