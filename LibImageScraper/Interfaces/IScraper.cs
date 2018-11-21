using System.Collections.Generic;

namespace LibImageScraper
{
    public interface IScraper
    {
        // Gives the Scraper a source to work with (ex: a path or a url)
        void SetSource(string source);

        // Starts the scraping process
        List<Dump> Scrape();


    }
}
