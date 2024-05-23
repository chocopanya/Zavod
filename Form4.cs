using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text;
            int verstak = Int32.Parse(text);
            int bigdoor = 350;
            int samorez = 1005;
            int tumbdoor = 350;
            int polka = 800;
            int a = samorez / 10;
            int b = tumbdoor / 2;
            int c = polka / 2;
            if (a>=verstak && b>=verstak && c>=verstak)
            {
                int samorez1 = samorez - (10*verstak);
                int tumbdoor1 = tumbdoor - (2*verstak);
                int polka1 = polka - (2 * verstak);
                string res = "Осталось:\", samorez1, \"саморезов,\", tumbdoor1, \"дверей тумбочек,\", polka1, \"полок и\", bigdoor, \"больших дверей.";
                
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
            int tumbdoor = 350;
            int polka = 800;
            int a = samorez / 10;
            int b = tumbdoor / 2;
            int c = polka / 2;
            if (a < b)
            {
                if (a < c)
                {
                    string res = "Можно сделать\", a, \"верстаков";
                    
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (c < a)
                {
                    string res = "Можно сделать\", c, \"верстаков";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (b < a)
            {
                if (b < c)
                {
                    string res = "Можно сделать\", b, \"верстаков";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (b > c)
                {
                    string res = "Можно сделать\", c, \"верстаков";
                    MessageBox.Show($"{res}", "Успешно", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Недостаточно материалов", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }
    }
}
