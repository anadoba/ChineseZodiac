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
        string znak = "";

        DateTime data_urodzenia;

        // MM dd rrrr
        DateTime szczur1 = DateTime.Parse("2/5/1924");
        DateTime szczur1k = DateTime.Parse("1/24/1925");
        DateTime szczur2 = DateTime.Parse("1/24/1936");
        DateTime szczur2k = DateTime.Parse("2/10/1949");
        DateTime szczur3 = DateTime.Parse("2/10/1948");
        DateTime szczur3k = DateTime.Parse("1/28/1949");
        DateTime szczur4 = DateTime.Parse("1/28/1960");
        DateTime szczur4k = DateTime.Parse("2/14/1961");
        DateTime szczur5 = DateTime.Parse("2/15/1972");
        DateTime szczur5k = DateTime.Parse("2/2/1973");
        DateTime szczur6 = DateTime.Parse("02/02/1984");
        DateTime szczur6k = DateTime.Parse("02/19/1985");
        DateTime szczur7 = DateTime.Parse("02/19/1996");
        DateTime szczur7k = DateTime.Parse("02/06/1997");
        DateTime szczur8 = DateTime.Parse("02/06/2008");
        DateTime szczur8k = DateTime.Parse("01/25/2009");

        DateTime bawol1 = DateTime.Parse("01/24/1925");
        DateTime bawol1k = DateTime.Parse("02/12/1926");
        DateTime bawol2 = DateTime.Parse("02/11/1937");
        DateTime bawol2k = DateTime.Parse("01/30/1938");
        DateTime bawol3 = DateTime.Parse("01/29/1949");
        DateTime bawol3k = DateTime.Parse("02/16/1950");
        DateTime bawol4 = DateTime.Parse("02/15/1961");
        DateTime bawol4k = DateTime.Parse("02/04/1962");
        DateTime bawol5 = DateTime.Parse("02/03/1973");
        DateTime bawol5k = DateTime.Parse("01/22/1974");
        DateTime bawol6 = DateTime.Parse("02/20/1985");
        DateTime bawol6k = DateTime.Parse("02/08/1986");
        DateTime bawol7 = DateTime.Parse("02/07/1997");
        DateTime bawol7k = DateTime.Parse("01/27/1998");
        DateTime bawol8 = DateTime.Parse("01/26/2009");
        DateTime bawol8k = DateTime.Parse("02/13/2010");

        DateTime tygrys1 = DateTime.Parse("02/13/1926");
        DateTime tygrys1k = DateTime.Parse("02/01/1927");
        DateTime tygrys2 = DateTime.Parse("01/31/1938");
        DateTime tygrys2k = DateTime.Parse("02/18/1939");
        DateTime tygrys3 = DateTime.Parse("02/17/1950");
        DateTime tygrys3k = DateTime.Parse("02/05/1951");
        DateTime tygrys4 = DateTime.Parse("02/05/1962");
        DateTime tygrys4k = DateTime.Parse("01/24/1963");
        DateTime tygrys5 = DateTime.Parse("01/23/1974");
        DateTime tygrys5k = DateTime.Parse("02/10/1975");
        DateTime tygrys6 = DateTime.Parse("02/09/1986");
        DateTime tygrys6k = DateTime.Parse("01/28/1987");
        DateTime tygrys7 = DateTime.Parse("01/28/1998");
        DateTime tygrys7k = DateTime.Parse("02/15/1999");
        DateTime tygrys8 = DateTime.Parse("02/14/2010");
        DateTime tygrys8k = DateTime.Parse("02/02/2011");

        DateTime krolik1 = DateTime.Parse("02/02/1927");
        DateTime krolik1k = DateTime.Parse("01/22/1928");
        DateTime krolik2 = DateTime.Parse("02/19/1939");
        DateTime krolik2k = DateTime.Parse("02/08/1940");
        DateTime krolik3 = DateTime.Parse("02/06/1951");
        DateTime krolik3k = DateTime.Parse("01/26/1952");
        DateTime krolik4 = DateTime.Parse("01/25/1963");
        DateTime krolik4k = DateTime.Parse("02/12/1964");
        DateTime krolik5 = DateTime.Parse("02/11/1975");
        DateTime krolik5k = DateTime.Parse("01/30/1976");
        DateTime krolik6 = DateTime.Parse("01/29/1987");
        DateTime krolik6k = DateTime.Parse("02/16/1988");
        DateTime krolik7 = DateTime.Parse("02/16/1999");
        DateTime krolik7k = DateTime.Parse("02/04/2000");
        DateTime krolik8 = DateTime.Parse("02/03/2011");
        DateTime krolik8k = DateTime.Parse("01/22/2012");

        DateTime smok1 = DateTime.Parse("01/23/1928");
        DateTime smok1k = DateTime.Parse("02/09/1929");
        DateTime smok2 = DateTime.Parse("02/09/1940");
        DateTime smok2k = DateTime.Parse("01/26/1941");
        DateTime smok3 = DateTime.Parse("01/27/1952");
        DateTime smok3k = DateTime.Parse("02/13/1953");
        DateTime smok4 = DateTime.Parse("02/13/1964");
        DateTime smok4k = DateTime.Parse("02/01/1965");
        DateTime smok5 = DateTime.Parse("01/31/1976");
        DateTime smok5k = DateTime.Parse("02/17/1977");
        DateTime smok6 = DateTime.Parse("02/17/1988");
        DateTime smok6k = DateTime.Parse("02/05/1989");
        DateTime smok7 = DateTime.Parse("02/05/2000");
        DateTime smok7k = DateTime.Parse("01/23/2001");
        DateTime smok8 = DateTime.Parse("01/23/2012");
        DateTime smok8k = DateTime.Parse("02/09/2013");

        DateTime waz1 = DateTime.Parse("02/10/1929");
        DateTime waz1k = DateTime.Parse("01/29/1930");
        DateTime waz2 = DateTime.Parse("01/27/1941");
        DateTime waz2k = DateTime.Parse("02/14/1942");
        DateTime waz3 = DateTime.Parse("02/14/1953");
        DateTime waz3k = DateTime.Parse("02/02/1954");
        DateTime waz4 = DateTime.Parse("02/02/1965");
        DateTime waz4k = DateTime.Parse("01/20/1966");
        DateTime waz5 = DateTime.Parse("02/18/1977");
        DateTime waz5k = DateTime.Parse("02/06/1978");
        DateTime waz6 = DateTime.Parse("02/06/1989");
        DateTime waz6k = DateTime.Parse("01/26/1990");
        DateTime waz7 = DateTime.Parse("01/24/2001");
        DateTime waz7k = DateTime.Parse("02/11/2002");
        DateTime waz8 = DateTime.Parse("02/10/2013");
        DateTime waz8k = DateTime.Parse("01/30/2014");


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

        private void Sprawdz2(object sender, RoutedEventArgs e)
        {
            string uriZodiaku = "http://www.numerologiachinska.pl/horoskop-chinski/twoj-znak/" +
                               "?d=" + dzien.Text +
                               "&m=" + miesiac.Text +
                               "&y=" + rok.Text;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uriZodiaku);
            request.Method = "GET";
            request.BeginGetResponse(GetZnakZodiaku, request);

            
        }

        void GetZnakZodiaku(IAsyncResult result)
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

                            if (znalezionyZnak.Equals("Świnia"))
                                znalezionyZnak = "Swinia";
                            if (znalezionyZnak.Equals("Bawół"))
                                znalezionyZnak = "Bawol";
                            if (znalezionyZnak.Equals("Królik"))
                                znalezionyZnak = "Krolik";
                            if (znalezionyZnak.Equals("Wąż"))
                                znalezionyZnak = "Waz";
                            if (znalezionyZnak.Equals("Koń"))
                                znalezionyZnak = "Kon";
                            if (znalezionyZnak.Equals("Małpa"))
                                znalezionyZnak = "Malpa";

                            NavigationService.Navigate(new Uri("/" + znalezionyZnak + ".xaml", UriKind.Relative));
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

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            /*if (dzien.Text == "dd" || miesiac.Text == "mm" || rok.Text == "rrrr")
            {
                dzien.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                miesiac.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                rok.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            }
            else1
            {*/
            try{
                data_urodzenia = DateTime.Parse(miesiac.Text.ToString() + "/" + dzien.Text.ToString() + "/" + rok.Text.ToString());

                if (szczur1 < data_urodzenia && data_urodzenia < szczur1k)
                    znak = "szczur";
                if (szczur2 < data_urodzenia && data_urodzenia < szczur2k)
                    znak = "szczur";
                if (szczur3 < data_urodzenia && data_urodzenia < szczur3k)
                    znak = "szczur";
                if (szczur4 < data_urodzenia && data_urodzenia < szczur4k)
                    znak = "szczur";
                if (szczur5 < data_urodzenia && data_urodzenia < szczur5k)
                    znak = "szczur";
                if (szczur6 < data_urodzenia && data_urodzenia < szczur6k)
                    znak = "szczur";
                if (szczur7 < data_urodzenia && data_urodzenia < szczur7k)
                    znak = "szczur";
                if (szczur8 < data_urodzenia && data_urodzenia < szczur8k)
                    znak = "szczur";

                if (bawol1 < data_urodzenia && data_urodzenia < bawol1k)
                    znak = "bawol";
                if (bawol2 < data_urodzenia && data_urodzenia < bawol2k)
                    znak = "bawol";
                if (bawol3 < data_urodzenia && data_urodzenia < bawol3k)
                    znak = "bawol";
                if (bawol4 < data_urodzenia && data_urodzenia < bawol4k)
                    znak = "bawol";
                if (bawol5 < data_urodzenia && data_urodzenia < bawol5k)
                    znak = "bawol";
                if (bawol6 < data_urodzenia && data_urodzenia < bawol6k)
                    znak = "bawol";
                if (bawol7 < data_urodzenia && data_urodzenia < bawol7k)
                    znak = "bawol";
                if (bawol8 < data_urodzenia && data_urodzenia < bawol8k)
                    znak = "bawol";

                if (tygrys1 < data_urodzenia && data_urodzenia < tygrys1k)
                    znak = "tygrys";
                if (tygrys2 < data_urodzenia && data_urodzenia < tygrys2k)
                    znak = "tygrys";
                if (tygrys3 < data_urodzenia && data_urodzenia < tygrys3k)
                    znak = "tygrys";
                if (tygrys4 < data_urodzenia && data_urodzenia < tygrys4k)
                    znak = "tygrys";
                if (tygrys5 < data_urodzenia && data_urodzenia < tygrys5k)
                    znak = "tygrys";
                if (tygrys6 < data_urodzenia && data_urodzenia < tygrys6k)
                    znak = "tygrys";
                if (tygrys7 < data_urodzenia && data_urodzenia < tygrys7k)
                    znak = "tygrys";
                if (tygrys8 < data_urodzenia && data_urodzenia < tygrys8k)
                    znak = "tygrys";

                if (krolik1 < data_urodzenia && data_urodzenia < krolik1k)
                    znak = "krolik";
                if (krolik2 < data_urodzenia && data_urodzenia < krolik2k)
                    znak = "krolik";
                if (krolik3 < data_urodzenia && data_urodzenia < krolik3k)
                    znak = "krolik";
                if (krolik4 < data_urodzenia && data_urodzenia < krolik4k)
                    znak = "krolik";
                if (krolik5 < data_urodzenia && data_urodzenia < krolik5k)
                    znak = "krolik";
                if (krolik6 < data_urodzenia && data_urodzenia < krolik6k)
                    znak = "krolik";
                if (krolik7 < data_urodzenia && data_urodzenia < krolik7k)
                    znak = "krolik";
                if (krolik8 < data_urodzenia && data_urodzenia < krolik8k)
                    znak = "krolik";

                if (smok1 < data_urodzenia && data_urodzenia < smok1k)
                    znak = "smok";
                if (smok2 < data_urodzenia && data_urodzenia < smok2k)
                    znak = "smok";
                if (smok3 < data_urodzenia && data_urodzenia < smok3k)
                    znak = "smok";
                if (smok4 < data_urodzenia && data_urodzenia < smok4k)
                    znak = "smok";
                if (smok5 < data_urodzenia && data_urodzenia < smok5k)
                    znak = "smok";
                if (smok6 < data_urodzenia && data_urodzenia < smok6k)
                    znak = "smok";
                if (smok7 < data_urodzenia && data_urodzenia < smok7k)
                    znak = "smok";
                if (smok8 < data_urodzenia && data_urodzenia < smok8k)
                    znak = "smok";

                if (waz1 < data_urodzenia && data_urodzenia < waz1k)
                    znak = "waz";
                if (waz2 < data_urodzenia && data_urodzenia < waz2k)
                    znak = "waz";
                if (waz3 < data_urodzenia && data_urodzenia < waz3k)
                    znak = "waz";
                if (waz4 < data_urodzenia && data_urodzenia < waz4k)
                    znak = "waz";
                if (waz5 < data_urodzenia && data_urodzenia < waz5k)
                    znak = "waz";
                if (waz6 < data_urodzenia && data_urodzenia < waz6k)
                    znak = "waz";
                if (waz7 < data_urodzenia && data_urodzenia < waz7k)
                    znak = "waz";
                if (waz8 < data_urodzenia && data_urodzenia < waz8k)
                    znak = "waz";

                // kon
                if (DateTime.Parse("01/30/1930") < data_urodzenia && data_urodzenia < DateTime.Parse("02/16/1931"))
                    znak = "kon";
                if (DateTime.Parse("02/15/1942") < data_urodzenia && data_urodzenia < DateTime.Parse("02/04/1943"))
                    znak = "kon";
                if (DateTime.Parse("02/03/1954") < data_urodzenia && data_urodzenia < DateTime.Parse("01/23/1955"))
                    znak = "kon";
                if (DateTime.Parse("01/21/1966") < data_urodzenia && data_urodzenia < DateTime.Parse("02/08/1967"))
                    znak = "kon";
                if (DateTime.Parse("02/07/1978") < data_urodzenia && data_urodzenia < DateTime.Parse("01/27/1979"))
                    znak = "kon";
                if (DateTime.Parse("01/27/1990") < data_urodzenia && data_urodzenia < DateTime.Parse("02/14/1991"))
                    znak = "kon";
                if (DateTime.Parse("02/12/2002") < data_urodzenia && data_urodzenia < DateTime.Parse("01/31/2003"))
                    znak = "kon";
                if (DateTime.Parse("01/31/2014") < data_urodzenia && data_urodzenia < DateTime.Parse("02/18/2015"))
                    znak = "kon";

                    // koza
                    if (DateTime.Parse("02/17/1931") < data_urodzenia && data_urodzenia < DateTime.Parse("02/05/1932")) znak = "koza";

                if (DateTime.Parse("02/05/1943") < data_urodzenia && data_urodzenia < DateTime.Parse("01/24/1944")) znak = "koza";

                if (DateTime.Parse("01/24/1955") < data_urodzenia && data_urodzenia < DateTime.Parse("02/11/1956")) znak = "koza";

                if (DateTime.Parse("02/09/1967") < data_urodzenia && data_urodzenia < DateTime.Parse("01/29/1968")) znak = "koza";

                if (DateTime.Parse("01/28/1979") < data_urodzenia && data_urodzenia < DateTime.Parse("02/15/1980")) znak = "koza";

                if (DateTime.Parse("02/15/1991") < data_urodzenia && data_urodzenia < DateTime.Parse("02/03/1992")) znak = "koza";

                if (DateTime.Parse("02/01/2003") < data_urodzenia && data_urodzenia < DateTime.Parse("01/21/2004")) znak = "koza";

                if (DateTime.Parse("02/19/2015") < data_urodzenia && data_urodzenia < DateTime.Parse("02/07/2016")) znak = "koza";

                // malpa
                if (DateTime.Parse("02/06/1932") < data_urodzenia && data_urodzenia < DateTime.Parse("01/25/1933")) znak = "malpa";

                if (DateTime.Parse("01/25/1944") < data_urodzenia && data_urodzenia < DateTime.Parse("02/12/1945")) znak = "malpa";

                if (DateTime.Parse("02/12/1956") < data_urodzenia && data_urodzenia < DateTime.Parse("01/30/1957")) znak = "malpa";

                if (DateTime.Parse("01/30/1968") < data_urodzenia && data_urodzenia < DateTime.Parse("02/16/1969")) znak = "malpa";

                if (DateTime.Parse("02/16/1980") < data_urodzenia && data_urodzenia < DateTime.Parse("02/04/1981")) znak = "malpa";

                if (DateTime.Parse("02/04/1992") < data_urodzenia && data_urodzenia < DateTime.Parse("01/22/1993")) znak = "malpa";

                if (DateTime.Parse("01/22/2004") < data_urodzenia && data_urodzenia < DateTime.Parse("02/08/2005")) znak = "malpa";

                if (DateTime.Parse("02/08/2016") < data_urodzenia && data_urodzenia < DateTime.Parse("01/27/2017")) znak = "malpa";

                // kogut
                if (DateTime.Parse("01/26/1933") < data_urodzenia && data_urodzenia < DateTime.Parse("02/13/1934")) znak = "kogut";

                if (DateTime.Parse("02/13/1945") < data_urodzenia && data_urodzenia < DateTime.Parse("02/01/1946")) znak = "kogut";

                if (DateTime.Parse("01/31/1957") < data_urodzenia && data_urodzenia < DateTime.Parse("02/17/1958")) znak = "kogut";

                if (DateTime.Parse("02/17/1969") < data_urodzenia && data_urodzenia < DateTime.Parse("02/05/1970")) znak = "kogut";

                if (DateTime.Parse("02/05/1981") < data_urodzenia && data_urodzenia < DateTime.Parse("01/24/1982")) znak = "kogut";

                if (DateTime.Parse("01/23/1993") < data_urodzenia && data_urodzenia < DateTime.Parse("02/09/1994")) znak = "kogut";

                if (DateTime.Parse("02/09/2005") < data_urodzenia && data_urodzenia < DateTime.Parse("01/28/2006")) znak = "kogut";

                if (DateTime.Parse("01/28/2017") < data_urodzenia && data_urodzenia < DateTime.Parse("02/15/2018")) znak = "kogut";

                // pies
                if (DateTime.Parse("02/14/1934") < data_urodzenia && data_urodzenia < DateTime.Parse("02/03/1935")) znak = "pies";

                if (DateTime.Parse("02/02/1946") < data_urodzenia && data_urodzenia < DateTime.Parse("01/21/1947")) znak = "pies";

                if (DateTime.Parse("02/18/1958") < data_urodzenia && data_urodzenia < DateTime.Parse("02/07/1959")) znak = "pies";

                if (DateTime.Parse("02/06/1970") < data_urodzenia && data_urodzenia < DateTime.Parse("01/26/1971")) znak = "pies";

                if (DateTime.Parse("01/25/1982") < data_urodzenia && data_urodzenia < DateTime.Parse("02/12/1983")) znak = "pies";

                if (DateTime.Parse("02/10/1994") < data_urodzenia && data_urodzenia < DateTime.Parse("01/30/1995")) znak = "pies";

                if (DateTime.Parse("01/29/2006") < data_urodzenia && data_urodzenia < DateTime.Parse("02/17/2007")) znak = "pies";

                if (DateTime.Parse("02/16/2018") < data_urodzenia && data_urodzenia < DateTime.Parse("02/04/2019")) znak = "pies";

                // swinia
                if (DateTime.Parse("02/04/1935") < data_urodzenia && data_urodzenia < DateTime.Parse("01/23/1936")) znak = "swinia";

                if (DateTime.Parse("01/22/1947") < data_urodzenia && data_urodzenia < DateTime.Parse("02/09/1948")) znak = "swinia";

                if (DateTime.Parse("02/08/1959") < data_urodzenia && data_urodzenia < DateTime.Parse("01/27/1960")) znak = "swinia";

                if (DateTime.Parse("01/27/1971") < data_urodzenia && data_urodzenia < DateTime.Parse("02/24/1972")) znak = "swinia";

                if (DateTime.Parse("02/13/1983") < data_urodzenia && data_urodzenia < DateTime.Parse("02/01/1984")) znak = "swinia";

                if (DateTime.Parse("01/31/1995") < data_urodzenia && data_urodzenia < DateTime.Parse("02/18/1996")) znak = "swinia";

                if (DateTime.Parse("02/18/2007") < data_urodzenia && data_urodzenia < DateTime.Parse("02/06/2008")) znak = "swinia";

                if (DateTime.Parse("02/05/2019") < data_urodzenia && data_urodzenia < DateTime.Parse("01/24/2020")) znak = "swinia";

                NavigationService.Navigate(new Uri("/" + znak + ".xaml", UriKind.Relative));
            }
            catch(System.FormatException){
                dzien.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                miesiac.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                rok.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            }
        }
    }
}