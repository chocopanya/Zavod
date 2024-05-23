using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int verstak = Int32.Parse(text);
            int tumbdoor = 350;
            int samorez = 1005;
            int bigdoor = 350;
            int polka = 800;
            int a = samorez / 20;
            int b = bigdoor / 2;
            int c = polka / 5;
            if (a >= verstak && b >= verstak && c >= verstak)
            {
                int samorez1 = samorez - (20 * verstak);
                int bigdoor1 = bigdoor - (2 * verstak);
                int polka1 = polka - (5 * verstak);
                string res = "Осталось:\", samorez1, \"саморезов,\", tumbdoor1, \"больших дверей,\", polka1, \"полок и\", bigdoor, \"дверей тумбочек.";
                MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Материалов не хватило", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int samorez = 1005;
            int bigdoor = 350;
            int polka = 800;
            int a = samorez / 20;
            int b = bigdoor / 2;
            int c = polka / 5;
            if (a < b)
            {
                if (a < c)
                {
                    string res = "Можно сделать\", a, \"архивных шкафов";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (c < a)
                {
                    string res = "Можно сделать\", c, \"архивных шкафов";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (b < a)
            {
                if (b < c)
                {
                    string res = "Можно сделать\", b, \"архивных шкафов";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (b > c)
                {
                    string res = "Можно сделать\", c, \"архивных шкафов";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Недостаточно ресурсов", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
    
}
