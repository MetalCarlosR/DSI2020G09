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
using Windows.UI.Xaml.Media.Imaging;
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
        string iconProfile;
        List<Icono> iconos;
        public Profile()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Gold = Player.gold;
            Gems = Player.gems;
            iconProfile = Player.icono.image;
            iconos = Iconos.iconos_;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int image = 0;
            Button b = sender as Button;

            switch (b.Name)
            {
                case "Primero":
                    image = 0;
                    break;
                case "Segundo":
                    image = 1;
                    break;
                case "Tercero":
                    image = 2;
                    break;
                case "Cuarto":
                    image = 3;
                    break;
                case "Quinto":
                    image = 4;
                    break;
                case "Sexto":
                    image = 5;
                    break;
                case "Septimo":
                    image = 6;
                    break;
                case "Octavo":
                    image = 7;
                    break;
                case "Noveno":
                    image = 8;
                    break;
                case "Decimo":
                    image = 9;
                    break;
            }

            Player.icono = Iconos.iconos_[image];

            iconProfile = Player.icono.image;

            Image img = IconoPerfil as Image;

            img.Source = new BitmapImage(new Uri("ms-appx:///" + iconProfile));
        }

        private void WatchReplay_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
        }

        
    }
}
