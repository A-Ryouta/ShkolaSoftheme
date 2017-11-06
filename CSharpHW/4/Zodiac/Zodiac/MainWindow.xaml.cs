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

namespace Zodiac
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
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {            
            var day = datePicker.SelectedDate.Value.Day;
            var month = datePicker.SelectedDate.Value.Month;

            if(month == 12 && day > 21 || month == 1 && day <= 20)
            {
                DisplaySign("Capricorn", "Resources/capricorn.jpg");
            }
            else if(month == 1 && day > 20 || month == 2 && day <= 18)
            {
                DisplaySign("Aquarius", "aquarius.jpg");
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
        void DisplaySign(string sign, string filename)
        {
            nameText.Text = "Your sign is " + sign;
            signImg.Source = new BitmapImage(new Uri(filename, UriKind.Relative));
        }
    }    
}
