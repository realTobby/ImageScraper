using HtmlAgilityPack;
using LibImageScraper.Interfaces;
using LibImageScraper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibImageScraper.Logic
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

        public void Scrape()
        {
            var web = new HtmlWeb();
            var document = web.Load(URL);
            HtmlNodeCollection imgs = document.DocumentNode.SelectNodes("//img[@src]");
            if (imgs == null)
            {
                urlDump.Add(new Dump("no images found"));
                return;
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


        }

        public List<Dump> ReturnResult()
        {
            return urlDump;
        }
    }
}
