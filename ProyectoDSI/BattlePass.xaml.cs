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
    public sealed partial class BattlePass : Page
    {
        Dictionary<int, ImageSource> characters = new Dictionary<int, ImageSource>();
        Dictionary<int, ImageSource> skins = new Dictionary<int, ImageSource>();
        Dictionary<int, ImageSource> grafittis = new Dictionary<int, ImageSource>();
        //This bools defines if we show daile or weekly chalenges
        bool daily = true; //false means weekly

        public BattlePass()
        {
            this.InitializeComponent();
            characters.Add(0, new BitmapImage(new Uri("ms-appx:///Assets/CharactersBattlePass.png", UriKind.Absolute)));
            characters.Add(1, new BitmapImage(new Uri("ms-appx:///Assets/Character1.png", UriKind.Absolute)));
            characters.Add(2, new BitmapImage(new Uri("ms-appx:///Assets/Character2.png", UriKind.Absolute)));
            characters.Add(3, new BitmapImage(new Uri("ms-appx:///Assets/Character3.png", UriKind.Absolute)));

            skins.Add(0, new BitmapImage(new Uri("ms-appx:///Assets/Skin1.png", UriKind.Absolute)));
            skins.Add(1, new BitmapImage(new Uri("ms-appx:///Assets/Skin2.png", UriKind.Absolute)));
            skins.Add(2, new BitmapImage(new Uri("ms-appx:///Assets/Skin3.png", UriKind.Absolute)));
            skins.Add(3, new BitmapImage(new Uri("ms-appx:///Assets/Skin4.png", UriKind.Absolute)));

            grafittis.Add(0, new BitmapImage(new Uri("ms-appx:///Assets/Grafitti1.png", UriKind.Absolute)));


        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ShowSkin(object sender, RoutedEventArgs e)
        {
            var index = ((Button)sender).Tag;
            displayImage.Source = skins[Int32.Parse((string)index)];
        }

        private void ShowCharacter(object sender, RoutedEventArgs e)
        {
            var index = ((Button)sender).Tag;
            displayImage.Source = characters[Int32.Parse((string)index)];
        }

        private void ShowVoice(object sender, RoutedEventArgs e)
        {
            var index = ((Button)sender).Tag;
            displayImage.Source = characters[Int32.Parse((string)index)];
        }

        private void ShowGrafitti(object sender, RoutedEventArgs e)
        {
            displayImage.Source = grafittis[0];
        }
        private void ShowChallenges()
        {
            List<Challenge> challengeList;
            if (daily)
                challengeList = Player.dailyChallenge;
            else
                challengeList = Player.weeklyChallenge;

            challengeText0.Text = (challengeList[0]).message;
            challengeText1.Text = (challengeList[1]).message;
            challengeText2.Text = (challengeList[2]).message;
            challengeText3.Text = (challengeList[3]).message;

            challengeStatus0.Text = (challengeList[0]).actualValue + "/" +(challengeList[0]).maxValue;
            challengeStatus1.Text = (challengeList[1]).actualValue + "/" +(challengeList[1]).maxValue;
            challengeStatus2.Text = (challengeList[2]).actualValue + "/" +(challengeList[2]).maxValue;
            challengeStatus3.Text = (challengeList[3]).actualValue + "/" +(challengeList[3]).maxValue;
        }

        private void ShowDailies(object sender, RoutedEventArgs e)
        {

        }
    }
}
