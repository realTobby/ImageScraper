using HtmlAgilityPack;
using System.Collections.Generic;
using System.Net;

namespace LibImageScraper.Scrapers
{
    public class OnlineHTMLScraper : IScraper
    {
        private string URL = "https://www.google.com";


        private List<Dump> urlDump = new List<Dump>();


        public OnlineHTMLScraper(string url)
        {
            SetSource(url);
        }

        public void SetSource(string source)
        {
            URL = source;
        }

        public List<Dump> Scrape()
        {
            urlDump.Clear();

            var web = new HtmlWeb();
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            var document = web.Load(URL);
            HtmlNodeCollection imgs = document.DocumentNode.SelectNodes("//img[@src]");
            if (imgs == null)
            {
                urlDump.Add(new Dump("no images found"));
                return urlDump;
            }

            foreach (HtmlNode img in imgs)
            {
                if (img.Attributes["src"] == null)
                    continue;
                HtmlAttribute src = img.Attributes["src"];

                if (src.Value.StartsWith("https://"))
                    urlDump.Add(new Dump(src.Value));
                else
                    urlDump.Add(new Dump( URL + src.Value));
            }

            return urlDump;
        }

        public List<Dump> ReturnDump()
        {
            return urlDump;
        }
    }
}
