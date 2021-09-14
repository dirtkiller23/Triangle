using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            if (a == null || a == 0)
                MessageBox.Show("Не задано значение А"); // выводится только если значение заданное = 0,но не если пустое,при пустом выдает ошибку


                if (a < b + c && b < a + c && c < a + b)
                MessageBox.Show("треугольник есть");
            else
                MessageBox.Show("Треугольник не существует");

            {
                
              
                {
                    if (a == b && b == c)
                        MessageBox.Show("Треугольник равносторонний");
                    else
                        MessageBox.Show("Треугольник не равносторонний");
                 
                }
                {
                    if (a == b || b == c || c == a)
                        MessageBox.Show("Треугольник равнобедренный");
                    else
                        MessageBox.Show("Треугольник не равнобедренный");
                }
                {
                    if ((a * a) == (b * b) + (c * c) || (b * b) == (a * a) + (c * c) || (c * c) == (b * b) + (a * a))
                        MessageBox.Show("Треугольник прямоугольный");
                    else
                        MessageBox.Show("Треугольник не прямоугольный");
                }
            }
        }
    }
}
