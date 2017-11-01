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

namespace RegistrationForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder msg = new StringBuilder("");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            lettersCheck(FirstName, ref msg);
            lengthCheck(FirstName, ref msg);

            lettersCheck(LastName, ref msg);
            lengthCheck(LastName, ref msg);

            //dateCheck(ref msg);
            if (tryNumbersCheck(day, ref msg))
            {
                int d = int.Parse(day.Text);
                if (d < 1 || d > 31)
                {
                    msg.Append("Day should be from 1 to 31\n");
                }
            }
            if (tryNumbersCheck(month, ref msg))
            {
                int m = int.Parse(month.Text);
                if (m < 1 || m > 12)
                {
                    msg.Append("Day should be from 1 to 12\n");
                }
            }
            if (tryNumbersCheck(year, ref msg))
            {
                int y = int.Parse(year.Text);
                if (y < 1901 || y > DateTime.Now.Year)
                {
                    msg.Append("Day should be from 1901 to now\n");
                }
            }

            if (!EMail.Text.Contains("@"))
            {
                msg.Append("EMail should contain @\n");
            }
            lengthCheck(EMail, ref msg);

            numbersCheck(PhoneNumber, ref msg);
            staticLengthCheck(PhoneNumber, ref msg, 12);

            lengthCheck(AdditionalInformation, ref msg, 2000);

            if (msg.Length == 0)
            {
                MessageBox.Show("Data successfully recorded");
            }
            else
            {
                MessageBox.Show(msg.ToString());
            }
            msg.Clear();
        }
        static void lengthCheck(TextBox t, ref StringBuilder s)
        {            
            if (t.Text.Length > 255)
            {
                s.Append(t.Name + " is out of maximum length\n");
            }
        }
        static void lengthCheck(TextBox t, ref StringBuilder s, int length)
        {
            if (t.Text.Length > length)
            {
                s.Append(t.Name + " is out of maximum length\n");
            }
        }
        static void staticLengthCheck(TextBox t, ref StringBuilder s, int staticLength = 255)
        {
            if (t.Text.Length != staticLength)
            {
                s.Append(t.Name + " should have " + staticLength + " symbols\n");
            }
        }
        static void lettersCheck(TextBox t, ref StringBuilder s)
        {
            if (!t.Text.All(chr => char.IsLetter(chr)))
            {
                s.Append(t.Name + " must contains only letters\n");
            }
        }
        static void numbersCheck(TextBox t, ref StringBuilder s)
        {
            if (!t.Text.All(chr => char.IsDigit(chr)))
            {
                s.Append(t.Name + " must contains only digits\n");
            }
        }
        static bool tryNumbersCheck(TextBox t, ref StringBuilder s)
        {
            bool check = true;
            if (!t.Text.All(chr => char.IsDigit(chr)))
            {
                check = false;
                s.Append(t.Name + " must contains only digits\n");
            }
            return check;
        }
        static void dateCheck(ref StringBuilder msg)
        {
            MainWindow mainWin = new MainWindow();

            if(tryNumbersCheck(mainWin.day, ref msg))
            {
                int d = int.Parse(mainWin.day.Text);
                if (d < 1 || d > 31)
                {
                    msg.Append("Day should be from 1 to 31\n");
                }
            }
            if(tryNumbersCheck(mainWin.month, ref msg))
            {
                int m = int.Parse(mainWin.month.Text);
                if (m < 1 || m > 12)
                {
                    msg.Append("Day should be from 1 to 12\n");
                }
            }
            if (tryNumbersCheck(mainWin.year, ref msg))
            {
                int y = int.Parse(mainWin.year.Text);
                if (y < 1901 || y > DateTime.Now.Year)
                {
                    msg.Append("Day should be from 1901 to now\n");
                }
            }           
        }
    }
}
