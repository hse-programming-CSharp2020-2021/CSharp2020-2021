using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        bool flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0 && flag)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            } else if (label1.Text.Length == 0 || this.Opacity < 1)
            {
                if (flag)
                {
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0)
                    {
                        label1.Text = "Кот уже ушел!";
                        flag = false;
                    }
                } else if (this.Opacity < 1)
                {
                    this.Opacity += 0.1;
                }
            }
        }
    }
}
