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
        string yourNameOutput;
        double number1;
        double number2;
        double MathAnswer;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            yourNameOutput = YourName.Text;
            ChangeMe.Text = yourNameOutput;

            number1 = double.Parse(number1.Text);
            number2 = double.Parse(number2.Text);
            MathAnswer = number1 + number2;

            MathAnswer.Text = Convert.ToString(MathAnswer);


        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeMe.Text = "";
            YourName.Text = "";
            number1.Text = "";
            number2.Text = "";
            MathAnswer.Text = "";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();

            Environment.Exit(0);
        }
    }
}
