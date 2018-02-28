using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Globalization;
using System;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public float value = 0;
        public float memValue;
        public string lastOp = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            this.InputBox.Text += (sender as Button).Content.ToString();
        }
        
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.InputBox.Text = "";
            value = 0;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if(this.InputBox.Text != "")
            {
                try
                {
                    value += float.Parse(this.InputBox.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Enter some numbers, you prick!");
                }
            }   
            this.InputBox.Text = "";
            lastOp = "+";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.InputBox.Text != "")
                {
                    value = float.Parse(this.InputBox.Text);
                }
                else
                {
                    value -= float.Parse(this.InputBox.Text);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
            this.InputBox.Text = "";
            lastOp = "-";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.InputBox.Text != "")
                {
                    value = float.Parse(this.InputBox.Text);

                }
                else
                {
                    value *= float.Parse(this.InputBox.Text);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
            this.InputBox.Text = "";
            lastOp = "*";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.InputBox.Text != "")
                {
                    value = float.Parse(this.InputBox.Text);
                }
                else
                {
                    value /= float.Parse(this.InputBox.Text);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
            this.InputBox.Text = "";
            lastOp = "/";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (lastOp)
                {
                    case "+": value += float.Parse(this.InputBox.Text); this.InputBox.Text = value.ToString(); break;
                    case "-": value -= float.Parse(this.InputBox.Text); this.InputBox.Text = value.ToString(); break;
                    case "*": value *= float.Parse(this.InputBox.Text); this.InputBox.Text = value.ToString(); break;
                    case "/": value /= float.Parse(this.InputBox.Text); this.InputBox.Text = value.ToString(); break;
                    case "": break;
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
    
        }

        private void Sqare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.InputBox.Text = Math.Sqrt(float.Parse(this.InputBox.Text)).ToString();
            } 

            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
        }
    
        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.InputBox.Text = Math.Sin(float.Parse(this.InputBox.Text)).ToString();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
        }

        private void Cos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.InputBox.Text = Math.Cos(float.Parse(this.InputBox.Text)).ToString();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Enter some numbers, you prick!");
            }
        }

        private void Memory_Add(object sender, RoutedEventArgs e)
        {
            if(this.InputBox.Text != "")
            {
                try
                {
                    memValue = float.Parse(this.InputBox.Text);
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Check your input");
                }
            }
        }

        private void Memory_Insert(object sender, RoutedEventArgs e)
        {
            this.InputBox.Text = memValue.ToString();
        }

        private void Memory_Reset(object sender, RoutedEventArgs e)
        {
            memValue = 0;
        }
    }
}