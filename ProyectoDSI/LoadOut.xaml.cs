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
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Input;
using Windows.UI.Input;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Core;
using Windows.System;
using Windows.Gaming.Input;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoDSI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class LoadOut : Page
    {

        bool upgradesMenuInUse = false;
        bool changingCharacter = true;
        Button lastClicked = null;
        string iconProfile;

        List<StoreItem> characters_ = new List<StoreItem>();
        public LoadOut()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(Player.character != null) Selected.Source = new BitmapImage(new Uri("ms-appx:///" + Player.character.image));
            setRole();
            iconProfile = Player.icono.image;
            money.Text = Player.gold.ToString();
            gems.Text = Player.gems.ToString();
            characters_ = Items.characters_;

            for (int i = 0; i < characters_.Count; i++)
            {
                string name = characters_[i].name;
                Image item = Layout.FindName(name) as Image;
                if (item != null)
                {
                    item.Source = new BitmapImage(new Uri("ms-appx:///" + characters_[i].image));
                    item.Tag = i;
                    item.HorizontalAlignment = HorizontalAlignment.Stretch;
                    item.VerticalAlignment = VerticalAlignment.Stretch;
                }
            }
        }


        private void setRole()
        {
            Back.Visibility = Visibility.Collapsed;
            switch (Player.role)
            {
                case 0:
                    Role.Text = "Driver";
                    Option1.Content = "BoostTrail";
                    Option2.Content = "Gloves";
                    Option3.Content = "Claxon";
                    Back.Visibility = Visibility.Visible;
                    break;
                case 1:
                    Role.Text = "Support";
                    Option1.Content = "Healing";
                    Option2.Content = "Buff";
                    Option3.Content = "Debuff";
                    break;
                case 2:
                    Role.Text = "CoPilot";
                    Option1.Content = "Weapon1";
                    Option2.Content = "Weapon2";
                    Option3.Content = "Grenade";
                    break;
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(Frame.BackStack.Last().SourcePageType);
        }

        private void ChangeSelection(object sender, PointerRoutedEventArgs e)
        {
            ImageSource aux = Back.Source;
            Back.Source = Selected.Source;
            Selected.Source = aux;
            changingCharacter = !changingCharacter;
            if (changingCharacter)
            {
                ButtonsPlayer.Visibility = Visibility.Visible;
                ButtonsCar.Visibility = Visibility.Collapsed;
            }
            else
            {
                ButtonsPlayer.Visibility = Visibility.Collapsed;
                ButtonsCar.Visibility = Visibility.Visible;
            }

        }

        private void ChangeSpacingPlayer(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;


            Option1Options.Visibility = Visibility.Collapsed;
            Option2Options.Visibility = Visibility.Collapsed;
            Option3Options.Visibility = Visibility.Collapsed;

            if (lastClicked != b)
            {
                upgradesMenuInUse = true;
                ButtonsPlayer.Spacing = 8;
                lastClicked = b;
            }
            else
            {
                ButtonsPlayer.Spacing = 25;
                upgradesMenuInUse = false;
                lastClicked = null;
            }
        }

        private void ChangeSpacingCar(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            EngineOptions.Visibility = Visibility.Collapsed;
            ChasisOptions.Visibility = Visibility.Collapsed;
            WheelsOtions.Visibility = Visibility.Collapsed;

            if (lastClicked != b)
            {
                upgradesMenuInUse = true;
                ButtonsCar.Spacing = 8;
                lastClicked = b;
            }
            else
            {
                ButtonsCar.Spacing = 25;
                upgradesMenuInUse = false;
                lastClicked = null;
            }
        }

        private void ShowObjectsCar(string type)
        {
            if (upgradesMenuInUse)
            {
                switch (type)
                {
                    case "Engine":
                        EngineOptions.Visibility = Visibility.Visible;
                        ChasisOptions.Visibility = Visibility.Collapsed;
                        WheelsOtions.Visibility = Visibility.Collapsed;
                        break;
                    case "Chasis":
                        EngineOptions.Visibility = Visibility.Collapsed;
                        ChasisOptions.Visibility = Visibility.Visible;
                        WheelsOtions.Visibility = Visibility.Collapsed;
                        break;
                    case "Wheels":
                        EngineOptions.Visibility = Visibility.Collapsed;
                        ChasisOptions.Visibility = Visibility.Collapsed;
                        WheelsOtions.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void ShowObjects(string type)
        {
            if (upgradesMenuInUse)
            {
                switch (type)
                {
                    case "Option1":
                        Option1Options.Visibility = Visibility.Visible;
                        Option2Options.Visibility = Visibility.Collapsed;
                        Option3Options.Visibility = Visibility.Collapsed;
                        break;
                    case "Option2":
                        Option1Options.Visibility = Visibility.Collapsed;
                        Option2Options.Visibility = Visibility.Visible;
                        Option3Options.Visibility = Visibility.Collapsed;
                        break;
                    case "Option3":
                        Option1Options.Visibility = Visibility.Collapsed;
                        Option2Options.Visibility = Visibility.Collapsed;
                        Option3Options.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ChangeSpacingPlayer(sender, e);
            ShowObjects(button.Name);
        }

        private void buttonClicked1(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ChangeSpacingCar(sender, e);
            ShowObjectsCar(button.Name);
        }

        private void ChangeCharacter(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            if (img.Tag.ToString() != "-1")
            {
                Player.character = characters_[Int32.Parse(img.Tag.ToString())];
                if (changingCharacter) Selected.Source = new BitmapImage(new Uri("ms-appx:///" + characters_[Int32.Parse(img.Tag.ToString())].image));
                else Back.Source = new BitmapImage(new Uri("ms-appx:///" + characters_[Int32.Parse(img.Tag.ToString())].image));
            }
        }
        /*
        private void ChangeCharacter(object sender, PointerRoutedEventArgs e)
        {
            Image img = (sender as Button).Content as Image;
            string src = img.Source.ToString();
            if (src != "Assets/BlackPortrait.png")
            {
                if (changingCharacter)
                    Selected.Source = new BitmapImage(new Uri((Items.boughtItems_.Find(x => x.name == (sender as Button).Name)).image));
                else
                    Back.Source = new BitmapImage(new Uri((Items.boughtItems_.Find(x => x.name == (sender as Button).Name)).image));
            }
        }
        /**/
    }
}
