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

namespace MadRacing
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Store : Page
    {
        public Store()
        {
            this.InitializeComponent();
        }

        private void WindowClicked(object sender, RoutedEventArgs e)
        {
            FeaturedOptions.Visibility = Visibility.Collapsed;
            CharacterOptions.Visibility = Visibility.Collapsed;
            SkinsOptions.Visibility = Visibility.Collapsed;
            MadOptions.Visibility = Visibility.Collapsed;
            Button b = sender as Button;
            switch(b.Name)
            {
                case "Featured":
                    FeaturedOptions.Visibility = Visibility.Visible;
                    break;
                case "Characters":
                    CharacterOptions.Visibility = Visibility.Visible;
                    break;
                case "Skins":
                    SkinsOptions.Visibility = Visibility.Visible;
                    break;
                case "MadCoins":
                    MadOptions.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
