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
        int winNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
            winNumber = StartGame();
        }        
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {            
            int userNumber;         
            
            try
            {
                userNumber = int.Parse(numberText.Text);
                if (userNumber > 10 || userNumber < 1)
                {
                    throw new ValueExeption();
                }
                else if (userNumber != winNumber)
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
                            MessageBox.Show("You`ve lost");
                            StartGame();
                            textLabel.Content = "New game started";
                            break;
                    }
                }
                else
                {                    
                    MessageBox.Show("Great! You won!\n Lest try more!");
                    textLabel.Content = "New game started";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                numberText.Clear();                
            }
            catch (ValueExeption ex)
            {
                MessageBox.Show(ex.Message);
                numberText.Clear();                
            }
        }
        
        int StartGame()
        {
            Random rnd = new Random();
            var goalNumber = rnd.Next(1, 10);
            loseCount = 0;
            numberText.Clear();            
            return goalNumber;
        }                
    }
    public class ValueExeption : Exception
    {     
        public string Message { get; } = "Number must be from 1 to 10";
    }
}

