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
using Windows.UI.ViewManagement;
using Windows.System.Display;

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
            DisplaySize.IsChecked = ApplicationView.GetForCurrentView().IsFullScreenMode;
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
            GeneralButton.Background = (SolidColorBrush)Resources["blueColor"];
            VideoButton.Background = (SolidColorBrush)Resources["blueColor"];
            AudioButton.Background = (SolidColorBrush)Resources["blueColor"];
            AccesibilityButton.Background = (SolidColorBrush)Resources["blueColor"];
            ControlsButton.Background = (SolidColorBrush)Resources["blueColor"];



            AudioSettings.Visibility = Visibility.Collapsed;
            AccesibilitySettings.Visibility = Visibility.Collapsed;
            ControlsSettings.Visibility = Visibility.Collapsed;
            GeneralSettings.Visibility = Visibility.Collapsed;
            VideoSettings.Visibility = Visibility.Collapsed;

            (sender as Button).Background = (SolidColorBrush)Resources["yellowColor"];

        }

        private void DisplaySize_Checked(object sender, RoutedEventArgs e)
        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            if (DisplaySize.IsChecked == true) view.TryEnterFullScreenMode();
            else view.ExitFullScreenMode();
        }
    }
}
