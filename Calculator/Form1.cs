using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
        

        private void Zero_Click(object sender, EventArgs e) // вывод нуля
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void zapyataya_Click(object sender, EventArgs e) // вывод запятой
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void One_Click(object sender, EventArgs e) // вывод 1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Two_Click(object sender, EventArgs e) // вывод 2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_Click(object sender, EventArgs e) // вывод 3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void chetire_Click(object sender, EventArgs e) // вывод 4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e) // вывод 5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e) // вывод 6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e) // вывод 7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void vosem_Click(object sender, EventArgs e) // вывод 8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void devyat_Click(object sender, EventArgs e) // вывод 9
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

        private void plus_Click(object sender, EventArgs e) // плюсик
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;

        }

        private void minus_Click(object sender, EventArgs e) // минусик
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void umnojenie_Click(object sender, EventArgs e) // умножение
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void delenie_Click(object sender, EventArgs e) // деление
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void sin_Click(object sender, EventArgs e) // синусы        
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "Sin";
        }

        private void cos_Click(object sender, EventArgs e) // косинусы
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = a.ToString() + "Cos";
        }

        private void tg_Click(object sender, EventArgs e) // тангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = a.ToString() + "Tan";
        }

        private void ctg_Click(object sender, EventArgs e) // котангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label1.Text = a.ToString() + "Ctg";
        }

        private void koren_Click(object sender, EventArgs e) // квадратный корень
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label1.Text = a.ToString() + "Sqrt";
        }

        private void kvadrat_Click(object sender, EventArgs e) // возведение в квадрат
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label1.Text = a.ToString() + "Squaring";
        }


        private void Ravno_Click(object sender, EventArgs e) // кнопка "равно"
        {
            calculate();
            label1.Text = "";
        }


        private void steret_Click(object sender, EventArgs e) // стереть всё
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e) // область для введённого
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // конвертирование в двоичную
        {
            if (radioButton1.Checked == true)
            {
                int i = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(i, 2);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // конвертирование в восьмеричную
        {
            if (radioButton2.Checked == true)
            {
                int i = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(i, 8);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // конвертирование в шеснадцатиричную
        {
            if (radioButton3.Checked == true)
            {
                int i = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(i, 16);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // подсчёт длины строк
        {
            if (radioButton4.Checked == true)
            {
                int s = richTextBox1.TextLength;
                string bukovki = Convert.ToString(s);
                richTextBox1.Text = Convert.ToString(bukovki);
            }
                    
        }

        public void radioButton5_CheckedChanged(object sender, EventArgs e) // преобразование всех букв в заглавные
        {
            if (radioButton5.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) // преобразование всех букв в прописные 
        {
            if (radioButton6.Checked == true)
            {
                richTextBox1.Text = richTextBox1.Text.ToLower();
            }
        }


        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // текстбокс калькулятора
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // текстбокс ввода переменной для конвертации 
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // текстбокс для вывода результата конвертации
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // текстбокс для вывода результатов в строковом калькуляторе
        {

        }

        private void CalcPage1_Click(object sender, EventArgs e) // область кнопок/текстбокса калькулятора
        {

        }

        private void PerevodSSPage2_Click(object sender, EventArgs e) // область радиокнопок/текстбокса переводчика в сс
        {

        }

        private void StrockovCalcPage3_Click(object sender, EventArgs e) // область радиокнопок/текстбоксов в строковом калькуляторе
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // РИЧ текстбокс, судя по описанию отличается от обычного возможностью редактирования введённого
        {

        }


        private void Form1_Load(object sender, EventArgs e) // окно программы
        {

        }
        

    }  

}
