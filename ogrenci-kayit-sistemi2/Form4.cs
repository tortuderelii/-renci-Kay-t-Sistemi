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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-3OR4605;Initial Catalog=OgrenciVerileri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //Row indexi tutmak için bu alana int verildi.
        int indexRow;
        public object[] arr = new object[200];
        public class Person
        {
            public string Name { get; set; }
            public string Number { get; set; }
            public string dogum { get; set; }
            public string bolum { get; set; }
            
            public Person(string name, string schoolNumber,string birth,string depart)
            {
                Name = name;
                Number = schoolNumber ;
                dogum = birth;
                bolum = depart;
            }
            
        }
        public void showInfos(string infos)
        {
            SqlDataAdapter Da = new SqlDataAdapter(infos, connect);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            dataGridView1.DataSource = Ds.Tables[0];

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hücre içindeki veriye tıklandığında dahi textbox içine tekrar yazılacak.
            indexRow = e.RowIndex;
            int alan = dataGridView1.SelectedCells[0].RowIndex;
            string name = dataGridView1.Rows[alan].Cells[0].Value.ToString();
            string surname = dataGridView1.Rows[alan].Cells[1].Value.ToString();
            string bday = dataGridView1.Rows[alan].Cells[2].Value.ToString();
            string bplace = dataGridView1.Rows[alan].Cells[3].Value.ToString();
            string department = dataGridView1.Rows[alan].Cells[4].Value.ToString();
            string email = dataGridView1.Rows[alan].Cells[5].Value.ToString();
            string cellphone = dataGridView1.Rows[alan].Cells[6].Value.ToString();


            textBox1.Text = name;
            textBox2.Text = surname;
            textBox3.Text = bday;
            textBox4.Text = bplace;
            textBox5.Text = department;
            textBox6.Text = email;
            textBox7.Text = cellphone;








        }

        private void button1_Click(object sender, EventArgs e)
        {
           




        }

        private void Form4_Load(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Kaydet butonu aksiyonu
            //Try-catch ile hata yakalayalım.
            try
            {
                connect.Open();
                SqlCommand takeCom = new SqlCommand("insert into Ogrenciler (ogrenciad,ogrencisoyad,ogrdate,ogrplace,department,ogrnum,ogrtel) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect);
                takeCom.Parameters.AddWithValue("@p1", textBox1.Text);
                takeCom.Parameters.AddWithValue("@p2", textBox2.Text);
                takeCom.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                takeCom.Parameters.AddWithValue("@p4", textBox4.Text);
                takeCom.Parameters.AddWithValue("@p5", textBox5.Text);
                takeCom.Parameters.AddWithValue("@p6", textBox6.Text);
                takeCom.Parameters.AddWithValue("@p7", textBox7.Text);
                //Sorgular üzerindeki değişiklikleri kaydediyor.
                takeCom.ExecuteNonQuery();
                connect.Close();
                showInfos("Select ogrnum as 'Öğrenci Numarası' , ogrenciad as Adı, ogrencisoyad as Soyadı, ogrdate as 'Doğum Tarihi' , ogrplace as 'Doğum Yeri' , department as Bölümü , ogrtel as Telefon from Ogrenciler");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu. Tekrar Deneyin.");
            }
            




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Bütün öğrenci listesini getirdi.
            showInfos("Select ogrnum as 'Öğrenci Numarası' , ogrenciad as Adı, ogrencisoyad as Soyadı, ogrdate as 'Doğum Tarihi' , ogrplace as 'Doğum Yeri' , department as Bölümü , ogrtel as Telefon from Ogrenciler");
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //İNCELENDİ.
            // Sql veritabanından veri silme işlemi TakeCom özel seçilen bir Emirleyici.
            try
            {
                connect.Open();
                SqlCommand takeCom = new SqlCommand("delete from Ogrenciler where ogrnum=@num", connect);
                takeCom.Parameters.AddWithValue("@num", textBox10.Text);
                //Değişiklik onaylanıyor.
                takeCom.ExecuteNonQuery();
                showInfos("Select ogrnum as 'Öğrenci Numarası' , ogrenciad as Adı, ogrencisoyad as Soyadı, ogrdate as 'Doğum Tarihi' , ogrplace as 'Doğum Yeri' , department as Bölümü , ogrtel as Telefon from Ogrenciler");
                connect.Close();
                textBox10.Clear();

            }
            catch (Exception)
            {

                MessageBox.Show("Veri silinmesinde hata oluştu.");
            }
          


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand takeCom = new SqlCommand("Update ogrenciler set ogrenciad='" + textBox1.Text + "',ogrencisoyad='" + textBox2.Text + "',ogrplace='" + textBox4.Text + "',department='" + textBox5.Text + "',ogrnum='" + textBox6.Text + "',ogrtel='" + textBox7.Text + "'where ogrnum='"+textBox6.Text+"'",connect);
            takeCom.ExecuteNonQuery();
            showInfos("Select ogrnum as 'Öğrenci Numarası' , ogrenciad as Adı, ogrencisoyad as Soyadı, ogrdate as 'Doğum Tarihi' , ogrplace as 'Doğum Yeri' , department as Bölümü , ogrtel as Telefon from Ogrenciler");
            connect.Close();
            textBox10.Clear();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;


            int alan = dataGridView1.SelectedCells[0].RowIndex;
            bool tut = dataGridView1.SelectedCells[0].Value == null;

            if (tut)
            {
                MessageBox.Show("Seçtiğiniz veri boş , işlem yapılamaz.");

            }

            else
            {
                string studentno = dataGridView1.Rows[alan].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[alan].Cells[1].Value.ToString();
                string surname = dataGridView1.Rows[alan].Cells[2].Value.ToString();
                string bday = dataGridView1.Rows[alan].Cells[3].Value.ToString();
                string bplace = dataGridView1.Rows[alan].Cells[4].Value.ToString();
                string department = dataGridView1.Rows[alan].Cells[5].Value.ToString();
                string cellphone = dataGridView1.Rows[alan].Cells[6].Value.ToString();


                textBox1.Text = name;
                textBox2.Text = surname;
                dateTimePicker1.Text = bday;
                textBox4.Text = bplace;
                textBox5.Text = department;
                textBox6.Text = studentno;
                textBox7.Text = cellphone;


            }



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("Select * from Ogrenciler where ogrnum like '%" + textBox10.Text + "%'",connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }
    }
}
