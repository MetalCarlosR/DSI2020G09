using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
    /// 
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(Frame.BackStack.Last().SourcePageType);
        }

        private void GeneralButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonClick(sender, e);
            GeneralSettings.Visibility = Visibility.Visible;
        }

        private void VideoButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonClick(sender, e);
            VideoSettings.Visibility = Visibility.Visible;
        }

        private void AudioButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonClick(sender, e);
            AudioSettings.Visibility = Visibility.Visible;
        }

        private void ControlsButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonClick(sender, e);
            ControlsSettings.Visibility = Visibility.Visible;
        }

        private void AccesibilityButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonClick(sender, e);
            AccesibilitySettings.Visibility = Visibility.Visible;
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            GeneralButton.Background = (SolidColorBrush)Resources["grayColor"];
            VideoButton.Background = (SolidColorBrush)Resources["grayColor"];
            AudioButton.Background = (SolidColorBrush)Resources["grayColor"];
            AccesibilityButton.Background = (SolidColorBrush)Resources["grayColor"];
            ControlsButton.Background = (SolidColorBrush)Resources["grayColor"];



            AudioSettings.Visibility = Visibility.Collapsed;
            AccesibilitySettings.Visibility = Visibility.Collapsed;
            ControlsSettings.Visibility = Visibility.Collapsed;
            GeneralSettings.Visibility = Visibility.Collapsed;
            VideoSettings.Visibility = Visibility.Collapsed;

            (sender as Button).Background = (SolidColorBrush)Resources["yellowColor"];

        }
    }
}
