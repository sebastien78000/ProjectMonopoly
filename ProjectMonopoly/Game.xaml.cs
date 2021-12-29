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
using System.Windows.Shapes;
using System.Threading;

namespace ProjectMonopoly
{
    /// <summary>
    /// Logique d'interaction pour Game.xaml
    /// </summary>
    public partial class Game : Page
    {

        public List<Player> players;
        int i = 0;
        int[] dataCase = { 1, 1, 1, 1 };

        int[,] positionCases = new int[,] { { 0, 0, 0, 4 },
                                         { 0, 0, 0, 84 },
                                         { 0, 0, 0, 144 },
                                         { 0, 0, 0, 204 },
                                         { 0, 0, 0, 264 },
                                         { 0, 0, 0, 324 },
                                         { 0, 0, 0, 384 },
                                         { 0, 0, 0, 444 },
                                         { 0, 0, 0, 504 },
                                         { 0, 0, 0, 564 },
                                         { 0, 0, 0, 624 },
                                         { 84, 0, 0, 644 },
                                         { 144, 0, 0, 644 },
                                         { 204, 0, 0, 644 },
                                         { 264, 0, 0, 644 },
                                         { 324, 0, 0, 644 },
                                         { 384, 0, 0, 644 },
                                         { 444, 0, 0, 644 },
                                         { 504, 0, 0, 644 },
                                         { 564, 0, 0, 644 },
                                         { 624, 0, 0, 644 },
                                         { 644, 0, 0, 564 },
                                         { 644, 0, 0, 504 },
                                         { 644, 0, 0, 444 },
                                         { 644, 0, 0, 384 },
                                         { 644, 0, 0, 324 },
                                         { 644, 0, 0, 264 },
                                         { 644, 0, 0, 204 },
                                         { 644, 0, 0, 144 },
                                         { 644, 0, 0, 84 },
                                         { 644, 0, 0, 4 },
                                         { 564, 0, 0, 4 },
                                         { 504, 0, 0, 4 },
                                         { 444, 0, 0, 4 },
                                         { 384, 0, 0, 4 },
                                         { 324, 0, 0, 4 },
                                         { 264, 0, 0, 4 },
                                         { 204, 0, 0, 4 },
                                         { 144, 0, 0, 4 },
                                         { 84, 0, 0, 4 },
                                         };

        public Game(List<Player> players)
        {
            this.players = players;
            InitializeComponent();
            Board board = Board.GetInstance();
            UpdateBackground();
            UpdateName();
            InitPawns();
        }


        private void ButtonRoll_Click(object sender, RoutedEventArgs e)
        {
            player1Background2.Opacity = 1;
            players[i].Play();
            UpdateDice(1, Dice.Value[0]);
            UpdateDice(2, Dice.Value[1]);
            MoveOnSpecificCase(i + 1, players[i].Position);

            if (players[i].NbLap == 5)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).Main.NavigationService.Navigate(new End(players[i].Name));
            }

            if (players[i].ReRoll==false)
            {
                i++;
                if (i == players.Count()) i = 0;  
            }

            player1Background2.Opacity = 0;
            player2Background2.Opacity = 0;
            player3Background2.Opacity = 0;
            player4Background2.Opacity = 0;

            if (i == 0) player1Background2.Opacity = 1;
            else if (i == 1) player2Background2.Opacity = 1;
            else if (i == 2) player3Background2.Opacity = 1;
            else player4Background2.Opacity = 1;

        }
        
        private void UpdateBackground()
        {
            if (players.Count() > 2) {
                player3Background1.Opacity = 1;
                player3Background3.Opacity = 1;
            }
            if (players.Count() > 3)
            {
                player4Background1.Opacity = 1;
                player4Background3.Opacity = 1;
            }

        }



        private void UpdateName()
        {

            player1ID.Text = players[0].Name;
            player2ID.Text = players[1].Name;
            if (players.Count()>2) player3ID.Text = players[2].Name;
            if (players.Count() > 3) player4ID.Text = players[3].Name;
        }

        private void InitPawns()
        {
            if (players.Count() < 4)
            {
                player4.Opacity = 0;
            }
            if (players.Count() < 3)
            {
                player3.Opacity = 0;
            }
        }


        private void UpdateDice(int number, int value)
        {
            if (number == 1)
            {
                if (value == 1)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 0;
                    dice1x4.Opacity = 0;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 1;
                }
                if (value == 2)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 0;
                }
                if (value == 3)
                {
                    dice1x1.Opacity = 0;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 0;
                    dice1x7.Opacity = 1;
                }
                if (value == 4)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 0;
                }
                if (value == 5)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 0;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 0;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 1;
                }
                if (value == 6)
                {
                    dice1x1.Opacity = 1;
                    dice1x2.Opacity = 1;
                    dice1x3.Opacity = 1;
                    dice1x4.Opacity = 1;
                    dice1x5.Opacity = 1;
                    dice1x6.Opacity = 1;
                    dice1x7.Opacity = 0;
                }
            }
            if (number == 2)
            {
                if (value == 1)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 0;
                    dice2x4.Opacity = 0;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 1;
                }
                if (value == 2)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 0;
                }
                if (value == 3)
                {
                    dice2x1.Opacity = 0;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 0;
                    dice2x7.Opacity = 1;
                }
                if (value == 4)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 0;
                }
                if (value == 5)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 0;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 0;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 1;
                }
                if (value == 6)
                {
                    dice2x1.Opacity = 1;
                    dice2x2.Opacity = 1;
                    dice2x3.Opacity = 1;
                    dice2x4.Opacity = 1;
                    dice2x5.Opacity = 1;
                    dice2x6.Opacity = 1;
                    dice2x7.Opacity = 0;
                }
            }
        }

        private void MoveOnSpecificCase(int numPlayer, int targetedCase)
        {
            int m1 = positionCases[targetedCase, 0];
            int m2 = positionCases[targetedCase, 1];
            int m3 = positionCases[targetedCase, 2];
            int m4 = positionCases[targetedCase, 3];

            if (numPlayer == 2)
            {
                m4 += 28;
            }
            if (numPlayer == 3)
            {
                m1 += 30;
            }
            if (numPlayer == 4)
            {
                m1 += 30;
                m4 += 28;
            }

            switch (numPlayer)
            {
                case 1:
                    {
                        player1.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 2:
                    {
                        player2.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 3:
                    {
                        player3.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 4:
                    {
                        player4.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
            }
        }




        private void MoveOneCase(int numPlayer)
        {
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;

            int positionPlayer = dataCase[numPlayer - 1];


            dataCase[numPlayer - 1] = positionPlayer + 1;
            if (dataCase[numPlayer - 1] == 41)
            {
                positionPlayer = 0;
                dataCase[numPlayer - 1] = 1;
            }

            m1 = positionCases[positionPlayer, 0];
            m2 = positionCases[positionPlayer, 1];
            m3 = positionCases[positionPlayer, 2];
            m4 = positionCases[positionPlayer, 3];

            if (numPlayer == 2)
            {
                m4 += 28;
            }
            if (numPlayer == 3)
            {
                m1 += 30;
            }
            if (numPlayer == 4)
            {
                m1 += 30;
                m4 += 28;
            }

            switch (numPlayer)
            {
                case 1:
                    {
                        player1.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 2:
                    {
                        player2.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 3:
                    {
                        player3.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
                case 4:
                    {
                        player4.Margin = new Thickness(m1, m2, m3, m4);
                        break;
                    }
            }
        }

        private void ButtonRollHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFE63070"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFE8704"), 0));

            ButtonRoll.Background = new LinearGradientBrush(Grad, 0);
        }

        private void ButtonRollNotHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 0));

            ButtonRoll.Background = new LinearGradientBrush(Grad, 0);
        }

        private void MovePlayer(int player)
        {
        }
    }
}
