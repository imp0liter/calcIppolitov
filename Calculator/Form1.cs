using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        int count;
        bool znak = true;

        private void button17_Click(object sender, EventArgs e) // вывод нуля
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e) // вывод запятой
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e) // вывод 1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e) // вывод 2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e) // вывод 3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e) // вывод 4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e) // вывод 5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e) // вывод 6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e) // вывод 7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e) // вывод 8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e) // вывод 9
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void calculate() // метод калькулятор
        {
            switch (count) // оператор, выбирающий метод решения из "кандидатов" ниже
            {
                case 1:
                    b = a + double.Parse(textBox1.Text); // сложение
                    textBox1.Text = b.ToString();
                    break;

                case 2:
                    b = a - double.Parse(textBox1.Text); // вычитание
                    textBox1.Text = b.ToString();
                    break;

                case 3:
                    b = a * double.Parse(textBox1.Text); // умножение
                    textBox1.Text = b.ToString();
                    break;

                case 4:
                    b = a / double.Parse(textBox1.Text); // деление
                    textBox1.Text = b.ToString();
                    break;

                case 5:
                    b = Math.Sin(a); // синус
                    textBox1.Text = b.ToString();
                    break;

                case 6:
                    b = Math.Cos(a); // косинус
                    textBox1.Text = b.ToString();
                    break;

                case 7:
                    b = Math.Tan(a); // тангенс
                    textBox1.Text = b.ToString();
                    break;

                case 8:
                    b = 1 / Math.Tan(a); // котангенс
                    textBox1.Text = b.ToString();
                    break;

                case 9:
                    b = Math.Sqrt(a); // квадратный корень
                    textBox1.Text = b.ToString();
                    break;

                case 10:
                    b = Math.Pow(a, 2); // возведение в квадрат
                    textBox1.Text = b.ToString();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e) // плюсик
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;

        }

        private void button8_Click(object sender, EventArgs e) // минусик
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e) // умножение
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e) // деление
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button1_Click(object sender, EventArgs e) // синусы        
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "Sin";
        }

        private void button2_Click(object sender, EventArgs e) // косинусы
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = a.ToString() + "Cos";
        }

        private void button20_Click(object sender, EventArgs e) // тангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = a.ToString() + "Tan";
        }

        private void button21_Click(object sender, EventArgs e) // котангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label1.Text = a.ToString() + "Ctg";
        }

        private void button22_Click(object sender, EventArgs e) // квадратный корень
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label1.Text = a.ToString() + "Sqrt";
        }

        private void button23_Click(object sender, EventArgs e) // возведение в квадрат
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label1.Text = a.ToString() + "Squaring";
        }


        private void button19_Click(object sender, EventArgs e) // кнопка "равно"
        {
            calculate();
            label1.Text = "";
        }


        private void button3_Click(object sender, EventArgs e) // стереть всё
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e) // область для введённого
        {

        }


        private void Form1_Load(object sender, EventArgs e) // окно
        {

        }
        
    }   

}
