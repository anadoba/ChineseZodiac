using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using HtmlAgilityPack;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Chinski_Zodiak
{
    public partial class Znak : PhoneApplicationPage
    {
        
        public Znak()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            String znak = "";

            if (NavigationContext.QueryString.TryGetValue("znak", out znak))
            {
                Nazwa.Text = znak;

                if (znak.Equals("Świnia"))
                    znak = "Swinia";
                if (znak.Equals("Bawół"))
                    znak = "Bawol";
                if (znak.Equals("Królik"))
                    znak = "Krolik";
                if (znak.Equals("Wąż"))
                    znak = "Waz";
                if (znak.Equals("Koń"))
                    znak = "Kon";
                if (znak.Equals("Małpa"))
                    znak = "Malpa";

                znak = znak.ToLower();

                Ikona.Source = new BitmapImage(new Uri("/znaki/" + znak + ".png", UriKind.Relative));

                string uriZodiaku = "http://przewodnikduchowy.pl/astrologia-chinska/chinski-znak-zodiaku-" + znak;
                HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(uriZodiaku);
                request.BeginGetResponse(GetOpisZnaku, request);
            }
        }

        private void GetOpisZnaku(IAsyncResult result)
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
                        String html = reader.ReadToEnd();
                        Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                            htmlDoc.LoadHtml(html);

                            StringBuilder opisZnaku = new StringBuilder();

                            int licznik = 0;
                            foreach (HtmlNode node in htmlDoc.DocumentNode.Descendants("p"))
                            {
                                if (licznik == 5)
                                    break;

                                opisZnaku.AppendLine(node.InnerText + "\n");
                                licznik++;
                            }

                            Opis.Text = opisZnaku.ToString();

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