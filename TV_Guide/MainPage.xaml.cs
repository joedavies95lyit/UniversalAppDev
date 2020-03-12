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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TV_Guide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GotButton_Click(object sender, RoutedEventArgs e)
        {
            // Call app specific code to subscribe to the service. For example:
            ContentDialog viewGOT = new ContentDialog
            {
                Title = "Game Of Thrones",
                Content = "Emilia Clarke, Kit Harrington, Peter Dinklage, (2011)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewGOT.ShowAsync();

        }

        private async void BbButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewBB = new ContentDialog
            {
                Title = "Breaking Bad",
                Content = "Bryan Cranston, Aaron Paul, Vince Gilligan, (2008)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewBB.ShowAsync();

        }

        private async void SaulButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewSaul = new ContentDialog
            {
                Title = "Better Call Saul",
                Content = "Bob Odenkirk, Giancarlo Esposito, Johnathan Banks, (2015)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewSaul.ShowAsync();

        }

        private async void WwButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewWW = new ContentDialog
            {
                Title = "Westworld",
                Content = "Evan Rachel-Wood, Thandie Newton, Jeffrey Wright, (2016)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewWW.ShowAsync();

        }

        private async void AdButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewAD = new ContentDialog
            {
                Title = "Arrested Development",
                Content = "Jason Bateman, Will Arnett, David Cross, (2003)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewAD.ShowAsync();
        }

        private async void SopranosButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewSop = new ContentDialog
            {
                Title = "The Sopranos",
                Content = "James Gandolfini, Tony Sirico, David Chase, (2011)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewSop.ShowAsync();

        }

        private async void StrangerButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewST = new ContentDialog
            {
                Title = "Stranger Things",
                Content = "Winona Ryder, Finn Wolfhard, Millie Bobby-Brown, (2016)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewST.ShowAsync();
        }

        private async void ChernobylButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog viewCher = new ContentDialog
            {
                Title = "Chernobyl",
                Content = "Jared Harris, Stellan Skarsgård, (2019)",
                CloseButtonText = "Close",
                PrimaryButtonText = "View Show Details",
            };

            ContentDialogResult result = await viewCher.ShowAsync();

        }

        private async void BojackButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private async void FleabagButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void WitcherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void TheBoysButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
