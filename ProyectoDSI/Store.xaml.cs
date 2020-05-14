using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoDSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Store : Page
    {
        Button lastClicked = null;
        public Store()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            money.Text = Player.gold.ToString();
            gems.Text = Player.gems.ToString();
        }

        private void WindowClicked(object sender, RoutedEventArgs e)
        {
            FeaturedOptions.Visibility = Visibility.Collapsed;
            CharacterOptions.Visibility = Visibility.Collapsed;
            SkinsOptions.Visibility = Visibility.Collapsed;
            MadOptions.Visibility = Visibility.Collapsed;

            Characters.Background = new SolidColorBrush(Colors.CadetBlue);
            Skins.Background = new SolidColorBrush(Colors.CadetBlue);
            MadCoins.Background = new SolidColorBrush(Colors.CadetBlue);

            Button b = sender as Button;
            switch(b.Name)
            {
                case "Featured":
                    FeaturedOptions.Visibility = Visibility.Visible;
                    break;
                case "Characters":
                    CharacterOptions.Visibility = Visibility.Visible;
                    Characters.Background = new SolidColorBrush(Colors.MidnightBlue);
                    break;
                case "Skins":
                    SkinsOptions.Visibility = Visibility.Visible;
                    Skins.Background = new SolidColorBrush(Colors.MidnightBlue);
                    break;
                case "MadCoins":
                    MadOptions.Visibility = Visibility.Visible;
                    MadCoins.Background = new SolidColorBrush(Colors.MidnightBlue);
                    break;
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(Frame.BackStack.Last().SourcePageType);
        }

        private void AddCharacterToLoadOut(object sender, RoutedEventArgs e)
        {
            //buscamos el item que se quiere comprar dentro de la lista
            string button = lastClicked.Name;
            StoreItem bought = Items.items_.Find(x => x.name == button);

            //se resta el gold y gemas que cuesta del jugador
            Player.gold -= bought.money;
            Player.gems -= bought.gems;
            money.Text = Player.gold.ToString();
            gems.Text = Player.gems.ToString();
            Items.buyItem(bought);
            bought.bought = true;


            lastClicked.Opacity = 0.75;
            BuyOption.Visibility = Visibility.Collapsed;
        }

        private void RejectBuy(object sender, RoutedEventArgs e)
        {
            BuyOption.Visibility = Visibility.Collapsed;
            lastClicked = null;
        }

        private void BuyItem(object sender, RoutedEventArgs e)
        {
            lastClicked = sender as Button;
            StoreItem bought = Items.items_.Find(x => x.name == lastClicked.Name);
            if (bought != null)
            {
                if (!bought.bought && int.Parse(money.Text.ToString()) - bought.money >= 0 && int.Parse(gems.Text.ToString()) - bought.gems >= 0)
                {
                    BuyOption.Visibility = Visibility.Visible;
                }

            }
            else lastClicked = null;
        }
    }
}
