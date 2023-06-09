﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string action = null;
        double double1 = 0;
        bool isReadyToNextValue = false;


        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < 500)
            {
                History.Visibility = Visibility.Collapsed;
            }
            else
            {
                History.Visibility = Visibility.Visible;
            }

            //History.Visibility = (e.NewSize.Width < 500) ? Visibility.Collapsed : Visibility.Visible;
        }


        private void onButton_ClickVlad(object sender, RoutedEventArgs e)
        {
            /*if (sender.Equals(btnEqual)) 
            {
            }
            else if (sender.Equals(btnPlus)) 
            {
            }
            else if (sender.Equals(btnDivide))
            {
            }
            else if (sender.Equals(btnMulti))
            {
            }
            else if (sender.Equals(btnMinus))
            {
            }
            else if (sender.Equals(btnDel))
            {
                Console.WriteLine("Del");
            }
            /*
            else if (sender.Equals(btn0))
            {
            }
            else if (sender.Equals(btn1))
            {
            }
            else if (sender.Equals(btn2))
            {
            }
            else if (sender.Equals(btn3))
            {
            }
            else if (sender.Equals(btn4))
            {
            }
            else if (sender.Equals(btn5))
            {
            }
            else if (sender.Equals(btn6))
            {
            }
            else if (sender.Equals(btn7))
            {
            }
            else if (sender.Equals(btn8))
            {
            }
            else if (sender.Equals(btn9))
            {
            }*/
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            double secondArgument = Convert.ToDouble(Label.Text);
            switch (action)
            {
                case "+":
                     result = double1 + secondArgument;
                    break;
                case "-":
                    result = double1 - secondArgument;
                    break;
                case "*":
                    result = double1 * secondArgument;
                    break;
                case "/":
                    result = double1 / secondArgument;
                    break;


            }
            Label.Text = Convert.ToString(result);




        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("click");
        }

        void onAction(string value)
        {
            action = value;
            isReadyToNextValue = true;
            double1 = Convert.ToDouble(Label.Text);
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            onAction(button.Content as string);
            
        }

        private void onNumericButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string value = btn.Content as string;
            if (isReadyToNextValue)
            {
                Label.Text = value;
            }
            else
            {
                if (Label.Text == "0")
                {
                    Label.Text = value.ToString();
                }
                else
                {
                    Label.Text += value;
                }
            }
            isReadyToNextValue = false;
        }

        private void btnDel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("MouseDoubleClick");
        }
    }
}
