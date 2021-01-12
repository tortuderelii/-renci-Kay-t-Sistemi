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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        //Row indexi tutmak için bu alana int verildi.
        int indexRow;

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
            //Kaydet butonu aksiyonu
            int i = dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = textBox6.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[3].Value = dateTimePicker1.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[5].Value = textBox5.Text;
            dataGridView1.Rows[i].Cells[6].Value = textBox7.Text;

            i++;





        }

        private void Form4_Load(object sender, EventArgs e)
        {

            //Form yüklendiğinde olacak

            textBox10.Visible = false;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "İsim";
            dataGridView1.Columns[1].Name = "Soyisim";
            dataGridView1.Columns[2].Name = "dogumtarihi";
            dataGridView1.Columns[3].Name = "dogumyeri";
            dataGridView1.Columns[4].Name = "bolum";
            dataGridView1.Columns[5].Name = "Okul numarasi";
            dataGridView1.Columns[6].Name = "telefon";
            dataGridView1.Columns[7].Name = "adres";













        }

        private void button2_Click(object sender, EventArgs e)
        {
            //İNCELENECEK

            if (dataGridView1.SelectedRows.Count > 0)

            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {

                MessageBox.Show("Silinecek veri seçilmedi.");
                MessageBox.Show("Lütfen satırbaşından tutturun.");

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = textBox6.Text;
            newDataRow.Cells[1].Value = textBox1.Text;
            newDataRow.Cells[2].Value = textBox2.Text;
            newDataRow.Cells[3].Value = dateTimePicker1.Text;
            newDataRow.Cells[4].Value = textBox4.Text;
            newDataRow.Cells[5].Value = textBox5.Text;
            newDataRow.Cells[6].Value = textBox6.Text;



        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //İNCELENECEK
            textBox10.Visible = true;
            string asera = textBox10.Text;

            while (dataGridView1.CurrentRow == null)
            {

                MessageBox.Show("selam");

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
