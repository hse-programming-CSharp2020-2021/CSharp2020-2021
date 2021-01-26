using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        static string sample = "0123456789";
        static char[] temp = sample.ToCharArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOfAny(temp) == -1)
            {
                // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Не введены цифры!");
                textBox1.Focus();   // установить фокус ввода
                return;
            }
            string number = textBox1.Text;
            number.Trim();  // убираем пробелы 
            int t = 0;  // вспомогательная переменная
            foreach (char ch in number)
                t = Math.Min(sample.IndexOf(ch), t);
            if (t == -1)
            {
                // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Это не натуральное число!");
                textBox1.Focus();   // установить фокус ввода
                return;
            }
            char[] arNumb = number.ToCharArray();   // массив из строки
            Array.Sort(arNumb);                   // сортировка по возрастанию
            Array.Reverse(arNumb);          // реверсирование
            textBox1.Text = new string(arNumb);	// из массива в строку
        }
    }
}
