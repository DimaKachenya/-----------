using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double a, b;
        string number1,number2;
        char znak = '.';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            if(znak=='.')
                number1 += "1";
            else
                number2 += "1";

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            znak = '=';
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            znak = '/' ;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            znak = '-';
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
            a = Convert.ToDouble(number1);
            b = Convert.ToDouble(number2);
            
            if (znak == '+')
                textBox1.Text += a + b;
            else if(znak=='*')
                textBox1.Text += a * b;
            else if(znak=='-')
                textBox1.Text += a - b;
            else if(znak=='/')
                textBox1.Text += a / b;
            else if(znak== '√')
                textBox1.Text += a * b;
            else if(znak=='^')
                textBox1.Text += Math.Pow(a , b);
            else if(znak== '√')
                textBox1.Text += Math.Sqrt(b);
            number1 = "";
            number2 = "";


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            if (znak == '.')
                number1 += "2";
            else
                number2 += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (znak == '.')
                number1 += "3";
            else
                number2 += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (znak == '.')
                number1 += "4";
            else
                number2 += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            if (znak == '.')
                number1 += "5";
            else
                number2 += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (znak == '.')
                number1 += "6";
            else
                number2 += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (znak == '.')
                number1 += "7";
            else
                number2 += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (znak == '.')
                number1 += "8";
            else
                number2 += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (znak == '.')
                number1 += "9";
            else
                number2 += "9";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            if (znak == '.')
                number1 += "0";
            else
                number2 += "0";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            znak = '+';

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
            number1 = "1";
            znak = '√';
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            znak = '^';
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
