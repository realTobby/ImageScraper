using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibImageScraper.Models
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
