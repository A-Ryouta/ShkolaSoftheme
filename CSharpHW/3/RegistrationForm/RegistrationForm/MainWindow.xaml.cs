using System;
using System.Linq;
using System.Windows;

namespace RegistrationForm
{
    public partial class MainWindow
    {        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var error = LetterCheck(FirstName.Text, FirstName.Uid) + LengthCheck(FirstName.Text, FirstName.Uid) 
                        + LetterCheck(LastName.Text, LastName.Uid) + LengthCheck(LastName.Text, LastName.Uid)
                        + DateCheck(Day.Text, Month.Text, Year.Text)
                        + LengthCheck(EMail.Text, EMail.Uid) + EMailCheck(EMail.Text, EMail.Uid)
                        + NumberCheck(PhoneNum.Text, PhoneNum.Uid) + ConstantLengthCheck(PhoneNum.Text, PhoneNum.Uid, 12)
                        + LengthCheck(AddInfo.Text, AddInfo.Uid, 2000);

            MessageBox.Show(error == string.Empty ? "Data successfully recorded" : error);
        }
        string LengthCheck(string text, string name, int length = 255)
        {
            return text.Length > length ? name + " is out of maximum length\n": string.Empty;
        }
        string ConstantLengthCheck(string text, string name, int length)
        {
            return text.Length != length ? name + " should have " + length + " symbols\n" : string.Empty;
        }
        string LetterCheck(string text, string name)
        {
            return !text.All(char.IsLetter) ? name + " must contains only letters\n" : string.Empty;
        }
        string NumberCheck(string text, string name)
        {
            return !text.All(char.IsDigit) ? name + " must contains only digits\n" : string.Empty;
        }        
        string EMailCheck(string text, string name)
        {
            return !text.Contains("@") ? name + " must contain @\n" : string.Empty;
        }
        string DateCheck(string d, string m, string y)
        {
            string message = string.Empty;
            if (NumberCheck(d, "day") == string.Empty && d != string.Empty)
            {
                int day = int.Parse(d);
                if (day < 1 || day > 31)
                {
                    message += "Day should be from 1 to 31\n";
                }
            }
            if(NumberCheck(m, "month") == string.Empty && m != string.Empty)
            {
                int month = int.Parse(m);
                if (month < 1 || month > 12)
                {
                    message += "Month should be from 1 to 12\n";
                }
            }
            if (NumberCheck(y, "year") == string.Empty && y != string.Empty)
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
