using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibImageScraper.Scrapers
{
    public class Online4chanScraper : IScraper
    {
        private string URL = "";
        private List<Dump> urlDump = new List<Dump>();

        public Online4chanScraper(string url)
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

                string baseUrl = new Uri(URL).Host;
                baseUrl = "https://" + baseUrl;

                if (!string.IsNullOrEmpty(src.Value))
                {
                    if (src.Value[0] == '/' && src.Value[1] != '/')
                    {
                        src.Value = baseUrl + src.Value;
                    }

                    if (src.Value[0] == '/' && src.Value[1] == '/')
                    {
                        src.Value = "https:" + src.Value;
                    }

                    urlDump.Add(new Dump(src.Value));
                }

            }


            return urlDump.Distinct().ToList();
        }


        public List<Dump> GetDump()
        {
            return urlDump;
        }
    }
}
