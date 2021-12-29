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

namespace ProjectMonopoly
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            Player player1 = new Player(BoxPlayer1.Text, "#33A4EB");
            Player player2 = new Player(BoxPlayer2.Text, "#E03266");
            Player player3 = new Player(BoxPlayer3.Text, "#18E85B");
            Player player4 = new Player(BoxPlayer4.Text, "#EAA1FA");

            List<Player> players = new List<Player>();
            
            if (player1.Name!="" & player1.Name !=null ) players.Add(player1);
            if (player2.Name != "" & player2.Name != null) players.Add(player2);
            if (player3.Name != "" & player3.Name != null) players.Add(player3);
            if (player4.Name != "" & player4.Name != null) players.Add(player4);

            if (players.Count() == 0) players.Add(new Player("Player 1", "#33A4EB"));
            if (players.Count() == 1) players.Add(new Player("Player 2", "#E03266"));

            NavigationService.Navigate(new Game(players));
        }


        private void ButtonPlayHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFE63070"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFE8704"), 0));

            ButtonPlay.Background = new LinearGradientBrush(Grad, 0);
        }

        private void ButtonPlayNotHovered(object sender, MouseEventArgs e)
        {
            GradientStopCollection Grad = new GradientStopCollection(2);
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 1));
            Grad.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#182454"), 0));

            ButtonPlay.Background = new LinearGradientBrush(Grad, 0);
        }
    }
}
