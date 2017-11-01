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

namespace DoubleOperations
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            double left = double.Parse(firstOperand.Text);
            double right = double.Parse(secondOperand.Text);
            double result = left + right;

            resultText.Text = result.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            double left = double.Parse(firstOperand.Text);
            double right = double.Parse(secondOperand.Text);
            double result = left - right;

            resultText.Text = result.ToString();
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            double left = double.Parse(firstOperand.Text);
            double right = double.Parse(secondOperand.Text);
            double result = left * right;

            resultText.Text = result.ToString();
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            double left = double.Parse(firstOperand.Text);
            double right = double.Parse(secondOperand.Text);

            if (right != 0)
            {
                double result = left / right;

                resultText.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Error! Zero division!");
            }
        }
    }
}
