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

namespace QuessMonster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int loseCount = 0;
        Random rnd = new Random();
        int guessNum;
        int userNum;
        public MainWindow()
        {
            InitializeComponent();
            guessNum = rnd.Next(1, 10);
        }        
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userNum = int.Parse(numberText.Text);
                if (userNum > 10 || userNum < 1)
                {
                    throw new ValueExeption();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You need to input a number!");
                numberText.Clear();
                return;
            }
            catch (ValueExeption)
            {
                MessageBox.Show("Number must be from 1 to 10");
                numberText.Clear();
                return;
            }            
            if (userNum != guessNum)
            {                
                loseCount++;

                switch (loseCount)
                {                    
                    case (1):
                        textLabel.Content = "That`s wrong.\n You have 2 more tries";
                        break;
                    case (2):                        
                        textLabel.Content = "That`s wrong.\n You have 1 more try";                        
                        break;
                    case (3):
                        loseCount = 0;
                        guessNum = rnd.Next(1, 10);
                        numberText.Clear();
                        MessageBox.Show("You`ve lost");
                        textLabel.Content = "New game started";
                        break;
                }                
            }
            else
            {
                loseCount = 0;
                guessNum = rnd.Next(1, 10);
                numberText.Clear();
                MessageBox.Show("Great! You won!\n Lest try more!");
                textLabel.Content = "New game started";
            }            
        }        
    }
    public class ValueExeption : Exception
    {
    }
}

