using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _ImageScraper
{
    public static class ImageScrape
    {
        private static List<Image> dumpedList = new List<Image>();
        private static string dumpedCode;
        private static string webUrl;
        private static List<string> filterList = new List<string>();

        public static List<Image> DumpedList
        {
            get
            {
                return dumpedList;
            }
        }

        public static string DumpedCode
        {
            get
            {
                return dumpedCode;
            }
        }

        public static string Weburl
        {
            get
            {
                return webUrl;
            }
        }
        public static List<string> FilterList
        {
            get
            {
                return filterList;
            }
            set
            {
                filterList = value;
            }
        }

        public static List<List<string>> GetAllImageLinks(List<string> imageUrls)
        {
            Console.WriteLine("Called function GetAllImageLinks()");
            List<string> tmpList = new List<string>();
            List<List<string>> result = new List<List<string>>();
            foreach(var item in filterList)
            {
                tmpList = new List<string>();
                tmpList = imageUrls.Where(x => x.EndsWith(item)).ToList();
                result.Add(tmpList);
            }
            return result;
        }

        public static string PrepareUrl(string enteredUrl)
        {
            Console.WriteLine("Called function PrepareUrl()");
            string txtUrl = enteredUrl;
            if (txtUrl[4] == 's')
            {
                txtUrl = txtUrl.Remove(4, 1);
            }
            if (txtUrl[txtUrl.Length - 1] == '/')
            {
                txtUrl = txtUrl.Remove(txtUrl.Length - 1);
            }
            webUrl = txtUrl;
            return txtUrl;
        }
        
        static bool IsValidUri(String uri)
        {
            Console.WriteLine("Called function IsValidUri()");
            try
            {
                new Uri(uri);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void ResetDumpedList()
        {
            Console.WriteLine("Called function ResetDumpedList()");
            dumpedList = new List<Image>();
        }
        public static Bitmap GetImageFromURL(string url)
        {
            Console.WriteLine("Called function GetImageFromUrl(" + url + ")");
            Bitmap img = new Bitmap(1, 1);
            if (IsValidUri(url))
            {
                WebRequest req = WebRequest.Create(url);
                try
                {
                    WebResponse resp = req.GetResponse();
                    img = new Bitmap(resp.GetResponseStream());
                }
                catch(Exception ex)
                {
                    // ugly excpetion, this stays until i find another solution to this
                }
                return img;
            }
            return img;
        }

        public static void SaveFilter()
        {
            Console.WriteLine("Called function SaveFilter()");
            // prepare string before saving
            string stuffToSave = "";
            foreach(var item in filterList)
            {
                stuffToSave = stuffToSave + item + System.Environment.NewLine;
            }
            System.IO.File.WriteAllText("filter.txt", stuffToSave);
        }
        public static void LoadFilter()
        {
            Console.WriteLine("Called function LoadFilter()");
            if (System.IO.File.Exists("filter.txt"))
            {
                var tmp = System.IO.File.ReadAllLines("filter.txt");
                filterList = new List<string>();
                foreach (var item in tmp)
                {
                    filterList.Add(item);
                }
            }
        }




    }
}
