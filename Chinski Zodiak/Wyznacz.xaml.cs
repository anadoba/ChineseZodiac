using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Windows.UI.Core;
using HtmlAgilityPack;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Chinski_Zodiak.Resources;

namespace Chinski_Zodiak
{
    public partial class Wyznacz : PhoneApplicationPage
    {

        public Wyznacz()
        {
            InitializeComponent();

        }

        private void dzien_GotFocus(object sender, RoutedEventArgs e)
        {
            dzien.Text = "";
        }

        private void dzien_LostFocus(object sender, RoutedEventArgs e)
        {
            if (dzien.Text == "")
                dzien.Text = "dd";
        }

        private void dzien_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dzien.Text.Length == 2)
                miesiac.Focus();
            dzien.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black);
        }

        private void miesiac_GotFocus(object sender, RoutedEventArgs e)
        {
            miesiac.Text = "";
        }

        private void miesiac_LostFocus(object sender, RoutedEventArgs e)
        {
            if (miesiac.Text == "")
                miesiac.Text = "mm";
        }

        private void miesiac_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (miesiac.Text.Length == 2)
                rok.Focus();
            miesiac.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black);
        }

        private void rok_GotFocus(object sender, RoutedEventArgs e)
        {
            rok.Text = "";
        }

        private void rok_LostFocus(object sender, RoutedEventArgs e)
        {
            if (rok.Text == "")
                rok.Text = "rrrr";
        }

        private void rok_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rok.Text.Length == 4)
                this.Focus();
            rok.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black);
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            string uriZodiaku = "http://www.numerologiachinska.pl/horoskop-chinski/twoj-znak/" +
                               "?d=" + dzien.Text +
                               "&m=" + miesiac.Text +
                               "&y=" + rok.Text;
            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(uriZodiaku);
            request.Method = "GET";
            request.BeginGetResponse(GetZnakZodiaku, request);
        }

        private void GetZnakZodiaku(IAsyncResult result)
        {
            HttpWebRequest request = result.AsyncState as HttpWebRequest;
            if (request != null)
            {
                try
                {
                    WebResponse response = request.EndGetResponse(result);
                    using (var stream = response.GetResponseStream())
                    using (var reader = new System.IO.StreamReader(stream, Encoding.UTF8))
                    {
                        String a = reader.ReadToEnd();
                        Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                            htmlDoc.LoadHtml(a);

                            String znalezionyZnak = htmlDoc.DocumentNode.Descendants("h1").Last().InnerText.Substring(19);

                            NavigationService.Navigate(new Uri("/Znak.xaml?znak=" + znalezionyZnak, UriKind.Relative));
                            //Sprawdz.Content
                        });
                    }
                }
                catch (WebException e)
                {
                    return;
                }
            }
        }
    }
}