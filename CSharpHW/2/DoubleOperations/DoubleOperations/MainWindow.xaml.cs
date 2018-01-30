using System.Globalization;
using System.Windows;

namespace DoubleOperations
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            var result = double.TryParse(FirstOperand.Text, out var left)
                         && double.TryParse(SecondOperand.Text, out var right) 
                         ? (left + right).ToString(CultureInfo.CurrentCulture) : "Wrong\n input\n data";

            ResultText.Text = result;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            var result = double.TryParse(FirstOperand.Text, out var left)
                         && double.TryParse(SecondOperand.Text, out var right)
                ? (left - right).ToString(CultureInfo.CurrentCulture) : "Wrong\n input\n data";

            ResultText.Text = result;
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            var result = double.TryParse(FirstOperand.Text, out var left)
                         && double.TryParse(SecondOperand.Text, out var right)
                ? (left * right).ToString(CultureInfo.CurrentCulture) : "Wrong\n input\n data";

            ResultText.Text = result;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            var result = double.TryParse(FirstOperand.Text, out var left)
                         && double.TryParse(SecondOperand.Text, out var right)
                         && right != 0.0
                ? (left / right).ToString(CultureInfo.CurrentCulture) : "Wrong\n input\n data";

            ResultText.Text = result;
        }
    }
}
