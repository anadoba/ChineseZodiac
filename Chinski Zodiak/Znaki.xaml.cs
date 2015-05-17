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
            NavigationService.Navigate(new Uri("/Szczur.xaml", UriKind.Relative));
        }

        private void Bawol_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Bawol.xaml", UriKind.Relative));
        }

        private void Tygrys_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tygrys.xaml", UriKind.Relative));
        }

        private void Krolik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Krolik.xaml", UriKind.Relative));
        }

        private void Smok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Smok.xaml", UriKind.Relative));
        }

        private void Waz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Waz.xaml", UriKind.Relative));
        }

        private void Kon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kon.xaml", UriKind.Relative));
        }

        private void Koza_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Koza.xaml", UriKind.Relative));
        }

        private void Malpa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Malpa.xaml", UriKind.Relative));
        }

        private void Kogut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kogut.xaml", UriKind.Relative));
        }

        private void Pies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pies.xaml", UriKind.Relative));
        }

        private void Swinia_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Swinia.xaml", UriKind.Relative));
        }
    }
}