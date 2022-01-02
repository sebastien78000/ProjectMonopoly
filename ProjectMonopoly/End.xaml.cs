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
    /// Logique d'interaction pour End.xaml
    /// </summary>
    public partial class End : Page
    {
        /// <summary>
        /// Constructor of the window End
        /// Has the name of player who won the game as an entry
        /// </summary>
        /// <param name="player"></param>
        public End(string player)
        {
            InitializeComponent();
            UpdateMessage(player);
        }

        /// <summary>
        /// update the box EndMessage to indicate which player has won
        /// </summary>
        /// <param name="player"></param>
        public void UpdateMessage(string player)
        {
            EndMessage.Text = $"Player {player} has won the game. Congratulations!";
        }
    }
}
