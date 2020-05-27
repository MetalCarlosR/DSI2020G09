using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
    public sealed partial class Game : Page
    {
        public Game()
        {
            this.InitializeComponent();
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Escape)
            {

                if (PauseMenu.Visibility == Visibility.Collapsed)
                {
                    PauseMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    PauseMenu.Visibility = Visibility.Collapsed;
                }
            }
            if (e.VirtualKey == Windows.System.VirtualKey.Tab)
            {

                if (TabMenu.Visibility == Visibility.Collapsed)
                {
                    TabMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    TabMenu.Visibility = Visibility.Collapsed;
                }
            }
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void OptionsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Settings));
        }
        private void ResumeClick(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Collapsed;
        }
    }
}
