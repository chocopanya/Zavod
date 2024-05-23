using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            int samorez = Int32.Parse(Text); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox2.Text;
            int bigdoor = Int32.Parse(Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox3.Text;
            int tumbdoor = Int32.Parse(Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox4.Text;
            int polka = Int32.Parse(Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                string Samorez = textBox1.Text;
                string BigDoor = textBox2.Text;
                string TumbDoor = textBox3.Text;
                string Polka = textBox4.Text;



                using (var connection = new SqliteConnection($"Data Source=zavod.db;Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "INSERT INTO clients (Samorez, BigDoor, TumbDoor, Polka) VALUES (@Samorez, @BigDoor, @TumbDoor, @Polka)";
                    using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                    {
                        // Добавьте параметры
                        command.Parameters.AddWithValue("@Samorez", Samorez);
                        command.Parameters.AddWithValue("@BigDoor", BigDoor);
                        command.Parameters.AddWithValue("@TumbDoor", TumbDoor);
                        command.Parameters.AddWithValue("@Polka", Polka);

                        // Выполните запрос
                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Данные внесены", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
            }
            this.Close();
        }
    }
}
