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
            lettersCheck(firstName.Text, firstName.Uid, ref msg);
            lengthCheck(firstName.Text, firstName.Uid, ref msg);

            lettersCheck(lastName.Text, lastName.Uid, ref msg);
            lengthCheck(lastName.Text, lastName.Uid, ref msg);

            dateCheck(day.Text, month.Text, year.Text, ref msg);            

            if (!eMail.Text.Contains("@"))
            {
                msg.Append("EMail should contain @\n");
            }
            lengthCheck(eMail.Text, eMail.Uid, ref msg);

            numbersCheck(phoneNum.Text, phoneNum.Uid, ref msg);
            staticLengthCheck(phoneNum.Text, phoneNum.Uid, ref msg, 12);

            lengthCheck(addInfo.Text, addInfo.Uid, 2000, ref msg);

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
        static void lengthCheck(string text, string name, ref StringBuilder sb)
        {            
            if (text.Length > 255)
            {
                sb.Append(name + " is out of maximum length\n");
            }
        }
        static void lengthCheck(string text, string name, int length, ref StringBuilder sb)
        {
            if (text.Length > length)
            {
                sb.Append(name + " is out of maximum length\n");
            }
        }
        static void staticLengthCheck(string text, string name, ref StringBuilder sb, int staticLength = 255)
        {
            if (text.Length != staticLength)
            {
                sb.Append(name + " should have " + staticLength + " symbols\n");
            }
        }
        static void lettersCheck(string text, string name, ref StringBuilder sb)
        {
            if (!text.All(chr => char.IsLetter(chr)))
            {
                sb.Append(name + " must contains only letters\n");
            }
        }
        static void numbersCheck(string text, string name, ref StringBuilder sb)
        {
            if (!text.All(chr => char.IsDigit(chr)))
            {
                sb.Append(name + " must contains only digits\n");
            }
        }
        static bool tryNumbersCheck(string text, string name, ref StringBuilder sb)
        {
            bool check = true;
            if (!text.All(chr => char.IsDigit(chr)))
            {
                check = false;
                sb.Append(name + " must contains only digits\n");
            }
            return check;
        }
        static void dateCheck(string d, string m, string y, ref StringBuilder sb)
        {
            if (tryNumbersCheck(d, "day", ref sb))
            {
                int day = int.Parse(d);
                if (day < 1 || day > 31)
                {
                    sb.Append("Day should be from 1 to 31\n");
                }
            }
            if(tryNumbersCheck(m, "month",ref sb))
            {
                int month = int.Parse(m);
                if (month < 1 || month > 12)
                {
                    sb.Append("Month should be from 1 to 12\n");
                }
            }
            if (tryNumbersCheck(y, "year",ref sb))
            {
                int year = int.Parse(y);
                if (year < 1901 || year > DateTime.Now.Year)
                {
                    sb.Append("Year should be from 1901 to now\n");
                }
            }           
        }
    }
}
