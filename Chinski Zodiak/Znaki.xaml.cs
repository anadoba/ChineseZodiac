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
    public partial class Znaki : PhoneApplicationPage
    {
        public Znaki()
        {
            InitializeComponent();
        }

        private void Szczur_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Szczur", UriKind.Relative));
        }

        private void Bawol_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Bawół", UriKind.Relative));
        }

        private void Tygrys_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Tygrys", UriKind.Relative));
        }

        private void Krolik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Królik", UriKind.Relative));
        }

        private void Smok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Smok", UriKind.Relative));
        }

        private void Waz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Wąż", UriKind.Relative));
        }

        private void Kon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Koń", UriKind.Relative));
        }

        private void Koza_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Koza", UriKind.Relative));
        }

        private void Malpa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Małpa", UriKind.Relative));
        }

        private void Kogut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Kogut", UriKind.Relative));
        }

        private void Pies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Pies", UriKind.Relative));
        }

        private void Swinia_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + "Świnia", UriKind.Relative));
        }
    }
}