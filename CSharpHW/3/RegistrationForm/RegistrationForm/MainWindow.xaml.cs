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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            var error = string.Empty;

            error = LetterCheck(firstName.Text, firstName.Uid) + LengthCheck(firstName.Text, firstName.Uid) // First Name
                + LetterCheck(lastName.Text, lastName.Uid) + LengthCheck(lastName.Text, lastName.Uid)       // Last Name
                + DateCheck(day.Text, month.Text, year.Text)                                                // Date
                + LengthCheck(eMail.Text, eMail.Uid) + EMailCheck(eMail.Text, eMail.Uid)                    // EMail
                + NumberCheck(phoneNum.Text, phoneNum.Uid) + ConstantLengthCheck(phoneNum.Text, phoneNum.Uid, 12)   // Phone
                + LengthCheck(addInfo.Text, addInfo.Uid, 2000);                                             // Additional info

            MessageBox.Show((error == string.Empty) ? "Data successfully recorded" : error);   
        }
        string LengthCheck(string text, string name, int length = 255)
        {
            string message = string.Empty;
            if (text.Length > length)
            {
                message = name + " is out of maximum length\n";
            }
            return message;
        }
        string ConstantLengthCheck(string text, string name, int constantLength = 255)
        {
            string message = string.Empty;
            if (text.Length != constantLength)
            {
                 message = name + " should have " + constantLength + " symbols\n";
            }
            return message;
        }
        string LetterCheck(string text, string name)
        {
            string message = string.Empty;
            if (!text.All(chr => char.IsLetter(chr)))
            {
                message = name + " must contains only letters\n";
            }
            return message;
        }
        string NumberCheck(string text, string name)
        {
            string message = string.Empty;
            if (!text.All(chr => char.IsDigit(chr)))
            {
                message = name + " must contains only digits\n";
            }
            return message;
        }        
        string EMailCheck(string text, string name)
        {
            string message = string.Empty;
            if (!eMail.Text.Contains("@"))
            {
                message = "EMail should contain @\n";
            }
            return message;
        }
        string DateCheck(string d, string m, string y)
        {
            string message = string.Empty;
            if (NumberCheck(d, "day") == string.Empty)
            {
                int day = int.Parse(d);
                if (day < 1 || day > 31)
                {
                    message += "Day should be from 1 to 31\n";
                }
            }
            if(NumberCheck(m, "month") == string.Empty)
            {
                int month = int.Parse(m);
                if (month < 1 || month > 12)
                {
                    message += "Month should be from 1 to 12\n";
                }
            }
            if (NumberCheck(y, "year") == string.Empty)
            {
                int year = int.Parse(y);
                if (year < 1901 || year > DateTime.Now.Year)
                {
                    message += "Year should be from 1901 to now\n";
                }
            }
            return message;
        }
    }
}
