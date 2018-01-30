using System;
using System.Windows;

namespace QuessMonster
{
    public partial class MainWindow 
    {
        int _loseCount;
        int _winNumber;

        public MainWindow()
        {
            InitializeComponent();
            _winNumber = StartGame();
        }
        
        private void GoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userNumber = int.Parse(NumberText.Text);

                if (userNumber > 10 || userNumber < 1)
                {
                    throw new ValueExeption();
                }

                if (userNumber != _winNumber)
                {
                    _loseCount++;

                    switch (_loseCount)
                    {
                        case (1):
                            TextLabel.Content = "That`s wrong.\n You have 2 more tries";
                            break;
                        case (2):
                            TextLabel.Content = "That`s wrong.\n You have 1 more try";
                            break;
                        case (3):
                            MessageBox.Show("You`ve lost");
                            _winNumber = StartGame();
                            TextLabel.Content = "New game started";
                            break;
                    }
                }
                else
                {                    
                    MessageBox.Show("Great! You won!\n Lest try more!");
                    _winNumber = StartGame();
                    TextLabel.Content = "New game started";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                NumberText.Clear();                
            }
            catch (ValueExeption ex)
            {
                MessageBox.Show(ex.Message);
                NumberText.Clear();                
            }
        }
        
        private int StartGame()
        {
            _loseCount = 0;
            NumberText.Clear();

            Random rnd = new Random();
            var goalNumber = rnd.Next(1, 10);

            return goalNumber;
        }                
    }
}

