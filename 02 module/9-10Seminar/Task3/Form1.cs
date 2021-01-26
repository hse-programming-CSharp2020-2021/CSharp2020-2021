using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        static int p1 = 0;
        static int p2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int now = p1 + 2 * p2;
            p1 = p2; p2 = now;
            label2.Text = now.ToString();
            if (p2 < 0)
            {
                MessageBox.Show("Переполнение!" +
                " \n Ряд начнем с начала!");
                p1 = 0;
                p2 = 1;
                label2.Text = "1";
            }
        }
    }
}
