using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoDSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Profile : Page
    {

        int Gold, Gems;
        public Profile()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Gold = Player.gold;
            Gems = Player.gems;
            
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(Frame.BackStack.Last().SourcePageType);
        }



        private void WindowClicked(object sender, RoutedEventArgs e)
        {
            OverviewPanel.Visibility = Visibility.Collapsed;
            HistoryPanel.Visibility = Visibility.Collapsed;
            HighlightsPanel.Visibility = Visibility.Collapsed;
            IconsPanel.Visibility = Visibility.Collapsed;
            Overview.Background = (SolidColorBrush)Resources["BlueColor"];
            History.Background = (SolidColorBrush)Resources["BlueColor"];
            HighLights.Background = (SolidColorBrush)Resources["BlueColor"];
            Icons.Background = (SolidColorBrush)Resources["BlueColor"];
            Button b = sender as Button;
            switch (b.Name)
            {
                case "Overview":
                    OverviewPanel.Visibility = Visibility.Visible;
                    Overview.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "History":
                    HistoryPanel.Visibility = Visibility.Visible;
                    History.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "HighLights":
                    HighlightsPanel.Visibility = Visibility.Visible;
                    HighLights.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "Icons":
                    IconsPanel.Visibility = Visibility.Visible;
                    Icons.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
            }
        }

        private void GameClicked(object sender, RoutedEventArgs e)
        {
            Game0.Visibility = Visibility.Collapsed;
            Game1.Visibility = Visibility.Collapsed;
            Game2.Visibility = Visibility.Collapsed;
            Game3.Visibility = Visibility.Collapsed;
            Game0Button.Background = (SolidColorBrush)Resources["WeirdGray"];
            Game1Button.Background = (SolidColorBrush)Resources["WeirdGray"];
            Game2Button.Background = (SolidColorBrush)Resources["WeirdGray"];
            Game3Button.Background = (SolidColorBrush)Resources["WeirdGray"];
            SelectGame.Visibility = Visibility.Collapsed;
            ReplayPanel.Visibility = Visibility.Visible;
            Button b = sender as Button;
            switch (b.Name)
            {
                case "Game0Button":
                    Game0.Visibility = Visibility.Visible;
                    Game0Button.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "Game1Button":
                    Game1.Visibility = Visibility.Visible;
                    Game1Button.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "Game2Button":
                    Game2.Visibility = Visibility.Visible;
                    Game2Button.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
                case "Game3Button":
                    Game3.Visibility = Visibility.Visible;
                    Game3Button.Background = (SolidColorBrush)Resources["GoldColor"];
                    break;
            }
        }

        private void WatchReplay_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
        }

    }
}
