using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoDSI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GoToBattlePass(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BattlePass));
        }

        private void GoToStore(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Store));
        }

        private void GoToProfile(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Profile));
        }

        private void GotoLoadout(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoadOut));
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Settings));
        }

        private void GoToGame(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game));
        }

        private void ButtonShowChat_Click(object sender, RoutedEventArgs e)
        {
            if (ChatBox.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ChatBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Chat.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                ChatBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Chat.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void FriendsButtonPanel_Click(object sender, RoutedEventArgs e)
        {
            FriendsPanel.SelectedItem = null;
            if (FriendsPanel.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                FriendsPanel.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                FriendsPanel.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void PushChat()
        {
            if (ChatInput.Text != "")
            {
                if (ChatBox.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                {
                    ChatBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    Chat.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
                ChatText.Text += "\r\n" + "Player 1:" + " " + ChatInput.Text;
                ChatInput.Text = "";
            }
        }

        private void ChatSendButton_Click(object sender, RoutedEventArgs e)
        {
            PushChat();
        }

        private void ChatInput_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
                PushChat();
        }

        private void ChatInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ChatBox.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ChatBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Chat.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }

        private void OpenPopUp(object sender, RoutedEventArgs e)
        {
            if (ExitPopUp.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ExitPopUp.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                ExitPopUp.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }
    }
}
