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
     /// Logique d'interaction pour MainWindow.xaml
     /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Intitilizae the first window as the Home window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Main.NavigationService.Navigate(new Home());
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
