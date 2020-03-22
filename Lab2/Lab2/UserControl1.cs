using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class UserControl1: UserControl
    {

        private double result = 0;
        private string operation = "";
        private bool clear = false;
        private double number = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result = 0;
            number = 0;
            operation = "";
            clear = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "0";
            clear = false;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "1";
            clear = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "2";
            clear = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "3";
            clear = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "4";
            clear = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "5";
            clear = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "6";
            clear = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "7";
            clear = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "8";
            clear = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "9";
            clear = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            number = -number;
            textBox1.Text = Convert.ToString(number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            number = number / 100;
            textBox1.Text = Convert.ToString(number);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                result = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "x")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "/")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }
            operation = "+";
            clear = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                result = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "x")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "/")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }
            operation = "-";
            clear = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                result = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "x")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "/")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }
            operation = "x";
            clear = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                result = Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "x")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "/")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }
            operation = "/";
            clear = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                result += Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "-")
            {
                result -= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "x")
            {
                result *= Convert.ToDouble(textBox1.Text);
            }
            else if (operation == "/")
            {
                result /= Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
