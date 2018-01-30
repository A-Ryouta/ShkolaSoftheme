using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Zodiac
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();                        
        }        

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatePicker.SelectedDate != null)
            {
                var day = DatePicker.SelectedDate.Value.Day;
                var month = DatePicker.SelectedDate.Value.Month;

                if(month == 12 && day > 21 || month == 1 && day <= 20)
                {
                    DisplaySign("Capricorn", "Resources/capricorn.jpg");
                }
                else if(month == 1 && day > 20 || month == 2 && day <= 18)
                {
                    DisplaySign("Aquarius", "Resources/aquarius.jpg");
                }
                else if (month == 2 && day > 18 || month == 3 && day <= 20)
                {
                    DisplaySign("Pisces", "Resources/pisces.jpg");
                }
                else if (month == 3 && day > 20 || month == 4 && day <= 19)
                {
                    DisplaySign("Aries", "Resources/aries.jpg");
                }
                else if (month == 4 && day > 19 || month == 5 && day <= 20)
                {
                    DisplaySign("Taurus", "Resources/taurus.jpg");
                }
                else if (month == 5 && day > 20 || month == 6 && day <= 20)
                {
                    DisplaySign("Gemini", "Resources/gemini.jpg");
                }
                else if (month == 6 && day > 20 || month == 7 && day <= 22)
                {
                    DisplaySign("Cancer", "Resources/cancer.jpg");
                }
                else if (month == 7 && day > 22 || month == 8 && day <= 22)
                {
                    DisplaySign("Leo", "Resources/leo.jpg");
                }
                else if (month == 8 && day > 22 || month == 9 && day <= 22)
                {
                    DisplaySign("Virgo", "Resources/virgo.jpg");
                }
                else if (month == 9 && day > 22 || month == 10 && day <= 22)
                {
                    DisplaySign("Libra", "Resources/libra.jpg");
                }
                else if (month == 10 && day > 22 || month == 11 && day <= 21)
                {
                    DisplaySign("Scorpio", "Resources/scorpio.jpg");
                }
                else if (month == 11 && day > 21 || month == 12 && day <= 21)
                {
                    DisplaySign("Sagittarius", "Resources/sagittarius.jpg");
                }
            }
        }

        void DisplaySign(string sign, string filename)
        {
            NameText.Text = "Your sign is " + sign;
            SignImg.Source = new BitmapImage(new Uri(filename, UriKind.Relative));
        }
    }    
}
