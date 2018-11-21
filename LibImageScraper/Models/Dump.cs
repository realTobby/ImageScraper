namespace LibImageScraper
{
    public class Dump
    {
        // can be url, a path or anything else (comes down to the Scraper that Implements the Interface to Handle it)
        public string Path { get; set; }


        public Dump(string source)
        {
            Path = source;
        }

    }
}
