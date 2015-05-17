using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Chinski_Zodiak
{
    public partial class Menu : PhoneApplicationPage
    {
        public Menu()
        {
            InitializeComponent();

#if DEBUG
            // Read the internal state of the Rate My App control
            DataContext = RateMyApp.Helpers.FeedbackHelper.Default;
#endif
        }



        private void Wyznacz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Wyznacz.xaml", UriKind.Relative));
        }

        private void Znaki_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znaki.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Check if ExtendedSplashscreen.xaml is on the backstack  and remove 
            if (NavigationService.BackStack.Count() == 1)
            {
                NavigationService.RemoveBackEntry();
            }

        }
    }
}