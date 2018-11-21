using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibImageScraper.Interfaces
{
    public interface IScraper
    {
        // Gives the Scraper a source to work with (ex: a path or a url)
        void SetSource(string source);

        // Starts the scraping process
        void Scrape();


    }
}
