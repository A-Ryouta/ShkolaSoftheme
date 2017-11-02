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
            //signImg.Source = new BitmapImage(new Uri("Resources/Wheel.png", UriKind.Relative));
        }        
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDate = datePicker.SelectedDate;            

            switch(selectedDate.Value.Month)
            {
                case 1:
                    if(selectedDate.Value.Day <= 20)
                    {                        
                        nameText.Text = "Your sign is Capricorn";
                        signImg.Source = new BitmapImage(new Uri("Resources/сapricorn.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Aquarius";
                        signImg.Source = new BitmapImage(new Uri("Resources/aquarius.jpg", UriKind.Relative));
                    }
                    break;
                case 2:
                    if (selectedDate.Value.Day <= 18)
                    {
                        nameText.Text = "Your sign is Aquarius";
                        signImg.Source = new BitmapImage(new Uri("Resources/aquarius.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Pisces";
                        signImg.Source = new BitmapImage(new Uri("Resources/pisces.jpg", UriKind.Relative));
                    }
                    break;
                case 3:
                    if (selectedDate.Value.Day <= 20)
                    {
                        nameText.Text = "Your sign is Pisces";
                        signImg.Source = new BitmapImage(new Uri("Resources/pisces.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Aries";
                        signImg.Source = new BitmapImage(new Uri("Resources/aries.jpg", UriKind.Relative));
                    }
                    break;
                case 4:
                    if (selectedDate.Value.Day <= 19)
                    {
                        nameText.Text = "Your sign is Aries";
                        signImg.Source = new BitmapImage(new Uri("Resources/aries.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Taurus";
                        signImg.Source = new BitmapImage(new Uri("Resources/taurus.jpg", UriKind.Relative));
                    }
                    break;
                case 5:
                    if (selectedDate.Value.Day <= 20)
                    {
                        nameText.Text = "Your sign is Taurus";
                        signImg.Source = new BitmapImage(new Uri("Resources/taurus.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Gemini";
                        signImg.Source = new BitmapImage(new Uri("Resources/gemini.jpg", UriKind.Relative));
                    }
                    break;
                case 6:
                    if (selectedDate.Value.Day <= 20)
                    {
                        nameText.Text = "Your sign is Gemini";
                        signImg.Source = new BitmapImage(new Uri("Resources/gemini.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Cancer";
                        signImg.Source = new BitmapImage(new Uri("Resources/cancer.jpg", UriKind.Relative));
                    }
                    break;
                case 7:
                    if (selectedDate.Value.Day <= 22)
                    {
                        nameText.Text = "Your sign is Cancer";
                        signImg.Source = new BitmapImage(new Uri("Resources/cancer.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Leo";
                        signImg.Source = new BitmapImage(new Uri("Resources/leo.jpg", UriKind.Relative));
                    }
                    break;
                case 8:
                    if (selectedDate.Value.Day <= 22)
                    {
                        nameText.Text = "Your sign is Leo";
                        signImg.Source = new BitmapImage(new Uri("Resources/leo.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Virgo";
                        signImg.Source = new BitmapImage(new Uri("Resources/virgo.jpg", UriKind.Relative));
                    }
                    break;
                case 9:
                    if (selectedDate.Value.Day <= 22)
                    {
                        nameText.Text = "Your sign is Virgo";
                        signImg.Source = new BitmapImage(new Uri("Resources/virgo.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Libra";
                        signImg.Source = new BitmapImage(new Uri("Resources/libra.jpg", UriKind.Relative));
                    }
                    break;
                case 10:
                    if (selectedDate.Value.Day <= 22)
                    {
                        nameText.Text = "Your sign is Libra";
                        signImg.Source = new BitmapImage(new Uri("Resources/libra.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Scorpio";
                        signImg.Source = new BitmapImage(new Uri("Resources/scorpio.jpg", UriKind.Relative));
                    }
                    break;
                case 11:
                    if (selectedDate.Value.Day <= 21)
                    {
                        nameText.Text = "Your sign is Scorpio";
                        signImg.Source = new BitmapImage(new Uri("Resources/scorpio.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Sagittarius";
                        signImg.Source = new BitmapImage(new Uri("Resources/sagittarius.jpg", UriKind.Relative));
                    }
                    break;
                case 12:
                    if (selectedDate.Value.Day <= 21)
                    {
                        nameText.Text = "Your sign is Sagittarius";
                        signImg.Source = new BitmapImage(new Uri("Resources/sagittarius.jpg", UriKind.Relative));
                    }
                    else
                    {
                        nameText.Text = "Your sign is Capricorn";
                        signImg.Source = new BitmapImage(new Uri("Resources/capricorn.jpg", UriKind.Relative));
                    }
                    break;
            }
        }
    }    
}
