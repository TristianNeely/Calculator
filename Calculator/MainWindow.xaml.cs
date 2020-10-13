using System;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }





        void setNumber(string num)
        {
            if ((string)result.Content == "0")
                result.Content = num;
            else
            {
                result.Content = result.Content + num;
            }
        }

        void setoperator (string op)
        {
            string c = (string)result.Content;
            if (c.Substring(c.Length - 1, 1) == ".")
                result.Content = result.Content + "0 " + op + " ";
            else
            {
                if (c.EndsWith(" "))
                    result.Content = c.Substring(0, c.IndexOf(" ")) + " " + op + " ";

                else
                {
                    if (c.Contains("+") || c.Contains("*") || c.Contains("-") || c.Contains("/"))
                        Calculator();

                    result.Content = result.Content + " " + op + " ";
                }
            }




            




        }

        void Calculator()
        {
            string c = (string)result.Content;
            string[] tokens = c.Split(' ');
            float a = float.Parse(tokens[0]);
            float b = float.Parse(tokens[2]);
            float res = 0;

            if (tokens[1] == "+")
                res = a + b;
            else if (tokens[1] == "-")
                res = a = b;
            else if (tokens[1] == "*")
                res = a / b;
            else if (tokens[1] == "/")
                res = a / b;
            result.Content = res.ToString();
        }







        private void number1_Click(object sender, RoutedEventArgs e)
        {
            setNumber("1");
        }

        private void number2_Click(object sender, RoutedEventArgs e)
        {
            setNumber("2");
        }

        private void number3_Click(object sender, RoutedEventArgs e)
        {
            setNumber("3");
        }

        private void number4_Click(object sender, RoutedEventArgs e)
        {
            setNumber("4");
        }

        private void number5_Click(object sender, RoutedEventArgs e)
        {
            setNumber("5");
        }

        private void number6_Click(object sender, RoutedEventArgs e)
        {
            setNumber("6");
        }

        private void number7_Copy_Click(object sender, RoutedEventArgs e)
        {
            setNumber("7");
        }

        private void number8_Click(object sender, RoutedEventArgs e)
        {
            setNumber("8");
        }

        private void number9_Click(object sender, RoutedEventArgs e)
        {
            setNumber("9");
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            setoperator("+");
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            setoperator("-");
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            setoperator("*");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            setoperator("/");
        }

        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            string c = (string)result.Content;
            if (c.EndsWith("."))
            {
                c = c + "0";
            }
            if(c.Contains(" "))
            {
                string ch = c.Substring(c.LastIndexOf(" ", c.Length - 1));
                float f = float.Parse(ch);
                f = f / 100;
                result.Content = c.Substring(0, c.LastIndexOf(" ") + 1) + f.ToString();
            }
            else
            {
                float f = float.Parse(c);
                f = f / 100;
                result.Content = f.ToString();
            }
        }

        private void Plus_Minus_Click(object sender, RoutedEventArgs e)
        {
            string c = (string)result.Content;
            if (c.StartsWith("-"))
                result.Content = c.Substring(1, c.Length - 1);
            else
                result.Content = "-" + result.Content;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            result.Content = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            string c = (string)result.Content;
            if (c.EndsWith(" "))
            {
                if (c.Contains("%"))
                {
                    float f = float.Parse(c.Substring(0, c.IndexOf(" "))) / 100;
                    result.Content = f.ToString();
                }
                else
                    result.Content = c.Substring(0, c.IndexOf(""));

            }
            else
            {
                Calculator();
            


            }
        }
        
        


        private void result_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _decimal_Click(object sender, RoutedEventArgs e)
        {
            string c = (string)result.Content;
            if (!(c.EndsWith(".")))
            {
                if (c.EndsWith(" "))
                    result.Content = result.Content + "0.";
                else
                    result.Content = result.Content + " .";
            }
        }
    }

   

}
