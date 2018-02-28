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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Convert.ToString(cos(Convert.ToDouble(textBox3.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Convert.ToString(sqrt1(Convert.ToDouble(textBox3.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Convert.ToString(sin(Convert.ToDouble(textBox3.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                label1.Text = Convert.ToString(mulriply(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
                string s1 = textBox1.Text;
                string s2 = textBox2.Text;

            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Convert.ToString(subsctarct(Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text)));
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Произошло деление на ноль. ");
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            Console.ReadLine();
        }
        public static double sum(double a, double b)
        {


            return a + b;

        }

        public static double devide(double a, double b)
        {

            return a / b;


        }
        public static double subsctarct(double a, double b)
        {

            return a - b;
        }
        public static double mulriply(double a, double b)
        {
            return a * b;
        }

        public static double cos(double c)
        {
            return Math.Cos(c);
        }

        public static double sin(double c)
        {
            return Math.Sin(c);
        }

        public static double sqrt1(double c)
        {
            return Math.Sqrt(c);
        }

        public double save(double c)
        {
            double result = c;
            return result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(save(Convert.ToDouble( label1.Text)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(save(Convert.ToDouble(label2.Text)));
        }
    }
}
