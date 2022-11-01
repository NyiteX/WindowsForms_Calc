using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool xF = true, yF = false;
            bool plus = false, minus = false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '+')
                {
                    xF = false;
                    yF = false;
                }
                if (textBox1.Text[i] == '-')
                {
                    xF = false;
                    yF = false;
                }

                if (Char.IsDigit(textBox1.Text[i]))
                {
                    if (!yF)
                        x = x * 10 + (textBox1.Text[i] - 48);
                    if (yF)
                        y = y * 10 + (textBox1.Text[i] - 48);
                }
                if (!xF && !yF || i == textBox1.Text.Length - 1)
                {
                    if (plus)
                        x += y;
                    if (minus)
                        x -= y;
                    yF = true;
                    y = 0;
                }
                if (textBox1.Text[i] == '+')
                {
                    plus = true;
                    minus = false;
                }
                if (textBox1.Text [i] == '-')
                {
                    plus = false;
                    minus = true;
                }
            }
            textBox1.Text = textBox1.Text + "=" + x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }
        Point p;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - p.X;
                this.Top +=e.Y - p.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button_delenie_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button_umnozh_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }
    }
}
