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
        public Profile()
        {
            this.InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
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

    }
}
