using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        string[] lines = new string[]
        { "один", "два", "три", "четыре", "пять", "шесть", "семь" };
        string[] newLines = null;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            listBox1.Visible = false;
            button2.Visible = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;    // показать listBox1
            listBox1.Items.Clear();     // очистить поле listBox1
            listBox1.Items.AddRange(lines); // поместить все строки
            newLines = lines;   // запомнить список
            button2.Visible = true;     // показать button2  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удалить выбранный элемент:
            int n = listBox1.SelectedIndex; // номер выделенной строки
            if (n == -1)
            { // Выделенная строка отсутствует
              // Диалоговое окно, захватывающее фокус: 
                MessageBox.Show("Список пуст или \nнет выделенного элемента!");
                return;
            }   //.. ничего не выбрано		
            string[] tempLines = new string[newLines.Length - 1];
            for (int k = 0, i = 0; i < newLines.Length; i++)
                if (i != n) tempLines[k++] = newLines[i];
            newLines = tempLines;
            listBox1.Items.Clear(); // очистить список
            listBox1.Items.AddRange(newLines);  // поместить строки в список

        }
    }
}
