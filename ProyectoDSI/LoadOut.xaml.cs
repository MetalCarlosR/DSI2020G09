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

        public LoadOut()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            iconProfile = Player.icono.image;

            for (int i = 0; i < Items.boughtItems_.Count(); i++)
                switch(Items.boughtItems_[i].type)
                {
                    case StoreItem.Type.character:
                        string name = "Character" + (i+1);
                        Image item = Layout.FindName(name) as Image;
                        if(item!=null)
                        {
                            string src = Items.boughtItems_[i].profImage;

                            ImageSource source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@src, UriKind.Relative)));

                            item.Source = source;
                            item.HorizontalAlignment = HorizontalAlignment.Stretch;
                            item.VerticalAlignment = VerticalAlignment.Stretch;
                        }
                         
                    break;
                    case StoreItem.Type.skin:
                    SunglassesOptions.Items.Insert(SunglassesOptions.Items.Count(), Items.boughtItems_[i].name);
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
        }

        private void ChangeSpacing(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;


            SunglassesOptions.Visibility = Visibility.Collapsed;
            GlovesOptions.Visibility = Visibility.Collapsed;
            ShoesOptions.Visibility = Visibility.Collapsed;

            if (lastClicked != b)
            {
                upgradesMenuInUse = true;
                Buttons.Spacing = 8;
                lastClicked = b;
            }
            else
            {
                Buttons.Spacing = 25;
                upgradesMenuInUse = false;
                lastClicked = null;
            }
        }

        private void ShowObjects(string type)
        {
            if (upgradesMenuInUse)
            {
                switch (type)
                {
                    case "Sunglasses":
                        SunglassesOptions.Visibility = Visibility.Visible;
                        GlovesOptions.Visibility = Visibility.Collapsed;
                        ShoesOptions.Visibility = Visibility.Collapsed;
                        break;
                    case "Gloves":
                        SunglassesOptions.Visibility = Visibility.Collapsed;
                        GlovesOptions.Visibility = Visibility.Visible;
                        ShoesOptions.Visibility = Visibility.Collapsed;
                        break;
                    case "Shoes":
                        SunglassesOptions.Visibility = Visibility.Collapsed;
                        GlovesOptions.Visibility = Visibility.Collapsed;
                        ShoesOptions.Visibility = Visibility.Visible;
                        break;
                }
            }
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ChangeSpacing(sender, e);
            ShowObjects(button.Name);
        }

        private void ChangeCharacter(object sender, RoutedEventArgs e)
        {
            Image img = (sender as Button).Content as Image;
            string src = img.Source.ToString();
            if( src != "Assets/BlackPortrait.png")
            {
                if (changingCharacter)
                    Selected.Source = new BitmapImage(new Uri((Items.boughtItems_.Find(x => x.name == (sender as Button).Name)).image));
                else
                    Back.Source = new BitmapImage(new Uri((Items.boughtItems_.Find(x => x.name == (sender as Button).Name)).image));
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
