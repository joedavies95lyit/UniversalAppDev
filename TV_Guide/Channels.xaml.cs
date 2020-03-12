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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TV_Guide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Channels : Page
    {
        public Channels()
        {
            this.InitializeComponent();
        }

        private void HboButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstChannelShow.Items.Count <= 0)
            {
                lstChannelShow.Items.Add("HBO Shows");
            }
            else
            {
                lstChannelShow.Items.Clear();
                lstChannelShow.Items.Add("HBO Shows");
            }

        }

        private void AmcButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstChannelShow.Items.Count <= 0)
            {
                lstChannelShow.Items.Add("AMC Shows");
            }
            else
            {
                lstChannelShow.Items.Clear();
                lstChannelShow.Items.Add("AMC Shows");
            }

        }

        private void NetflixButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstChannelShow.Items.Count <= 0)
            {
                lstChannelShow.Items.Add("Netflix Shows");
            }
            else
            {
                lstChannelShow.Items.Clear();
                lstChannelShow.Items.Add("Netflix Shows");
            }

        }

        private void AmazonButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstChannelShow.Items.Count <= 0)
            {
                lstChannelShow.Items.Add("Amazon Shows");
            }
            else
            {
                lstChannelShow.Items.Clear();
                lstChannelShow.Items.Add("Amazon Shows");
            }
        }
    }
}
