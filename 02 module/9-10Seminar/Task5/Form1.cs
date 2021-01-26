using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        string[] lines = new string[]
        { "один", "два", "три", "четыре", "пять", "шесть", "семь" };

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
            button2.Visible = true;     // показать button2  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
                str += " " + listBox1.Items[i];
            MessageBox.Show(str);
        }
    }
}
