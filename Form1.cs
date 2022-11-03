using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point p;
        string num1 = "";
        string num2 = "";
        bool num1_f = true;
        bool plus = false, minus = false,delenie = false,umnozhenie = false;
        public Form1()
        {
            InitializeComponent();
        }
        //my_funcs
        private void My_func()
        {
            if (textBox1.Text.Length < 1)
            {
                textBox1.Text = "0";
                num1 = "0";
                num1_f = false;
            }
            if (num1.Length > 0 && num2.Length > 0)
            {
                if (num2[0] == '-' && num2.Length > 1 || num2[0]!='-')
                {
                    if (delenie)
                    {
                        if (Convert.ToInt32(num2) != 0)
                            textBox1.Text = Convert.ToString(Convert.ToInt32(num1) / Convert.ToInt32(num2));
                        else
                        {
                            MessageBox.Show("Деление на 0.");
                        }
                    }
                    else if (umnozhenie)
                        textBox1.Text = Convert.ToString(Convert.ToInt32(num1) * Convert.ToInt32(num2));
                    else if (plus)
                        textBox1.Text = Convert.ToString(Convert.ToInt32(num1) + Convert.ToInt32(num2));
                    else if (minus)
                        textBox1.Text = Convert.ToString(Convert.ToInt32(num1) - Convert.ToInt32(num2));

                    num1 = textBox1.Text;
                    num2 = "";

                    plus = false;
                    minus = false;
                    umnozhenie = false;
                    delenie = false;
                }
            }        
        }
        //basic funcs
        private void Form1_Load(object sender, EventArgs e)
        {

        }       
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - p.X;
                this.Top += e.Y - p.Y;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }
        private void X_Button_MouseEnter(object sender, EventArgs e)
        {
            X_Button.BackColor = Color.DarkGray;
        }
        private void X_Button_MouseLeave(object sender, EventArgs e)
        {
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //buttons
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            if (num1_f)
                num1 += "1";
            else
                num2 += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            if (num1_f)
                num1 += "2";
            else
                num2 += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (num1_f)
                num1 += "3";
            else
                num2 += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (num1_f)
                num1 += "4";
            else
                num2 += "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            if (num1_f)
                num1 += "5";
            else
                num2 += "5";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (num1_f)
                num1 += "6";
            else
                num2 += "6";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (num1_f)
                num1 += "7";
            else
                num2 += "7";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (num1_f)
                num1 += "8";
            else
                num2 += "8";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (num1_f)
                num1 += "9";
            else
                num2 += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            if (num1_f)
                num1 += "0";
            else
                num2 += "0";
        }
        private void button_plus_Click(object sender, EventArgs e)
        {
            My_func();
            textBox1.Text += "+";
            num1_f = false;
            if (!plus && !minus && !umnozhenie && !delenie)
            {
                plus = true;
            }
        }
        private void button_minus_Click(object sender, EventArgs e)
        {
            My_func();
            textBox1.Text += "-";
            if(!num1_f)
                if(num2.Length < 1)
                    num2 += "-";
            num1_f = false;
            if (!plus && !minus && !umnozhenie && !delenie)
            {
                minus = true;
            }
            if(num2.Length > 0)
            {
                if (num2[0] == '-')
                    if(minus && !umnozhenie && !plus && !delenie)
                    {
                        minus = false;
                        plus = true;
                    }
            }
        }
        private void button_delenie_Click(object sender, EventArgs e)
        {
            My_func();
            textBox1.Text += "/";
            num1_f = false;
            if (!plus && !minus && !umnozhenie && !delenie)
            {
                delenie = true;
            }
        }
        private void button_ravno_Click(object sender, EventArgs e)
        {
            My_func();
        }
        private void button_umnozh_Click(object sender, EventArgs e)
        {
            My_func();
            textBox1.Text += "*";
            num1_f = false;
            if (!plus && !minus && !umnozhenie && !delenie)
            {
                umnozhenie = true;
            }
        }  
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = "";
            num2 = "";
            plus = false;
            minus = false;
            umnozhenie = false;
            delenie = false;
            num1_f = true;
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
            if (num2.Length > 0)
                num2 = num2.Remove(num2.Length - 1);
            else if(num2.Length < 0)
            {
                minus = false;
                plus = false;
                umnozhenie=false;
                delenie=false;
                if (num1.Length > 0)
                    num1 = num1.Remove(num1.Length - 1);
            }
        }        
    }
}