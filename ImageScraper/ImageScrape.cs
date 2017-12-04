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

        public static List<List<string>> GetAllImageLinks()
        {
            Console.WriteLine("Called function GetAllImageLinks()");
            List<string> tmpList = new List<string>();
            List<List<string>> result = new List<List<string>>();
            foreach(var item in filterList)
            {
                tmpList = new List<string>();
                tmpList = DumpImageFormat(item, dumpedCode);
                result.Add(tmpList);
            }
            return result;
        }

        public static string DumpHTML(string url)
        {
            Console.WriteLine("Called function DumpHTML()");
            try
            {
                string urlAddress = url;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string code = "";
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    code = readStream.ReadToEnd();
                    response.Close();
                    readStream.Close();
                }
                dumpedCode = code;
                return code;
            }catch(Exception ex)
            {
                // ugly excpetion until i find a better solution
                return "";
            }
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

        public static List<string> DumpImageFormat(string format, string dumpedCode)
        {
            Console.WriteLine("Called function DumpImageFormat(" + format + ", dumpedCode)");
            List<string> imageurls = new List<string>();
            if (dumpedCode != null)
            {
                while (dumpedCode.Contains(format))
                {
                    int indx = dumpedCode.IndexOf(format);
                    string firstMarker = "";
                    for (int i = 0; i < format.Length; i++)
                    {
                        firstMarker = firstMarker + dumpedCode[indx + i].ToString();
                    }
                    string imagelink = "";
                    for (int i = indx - 1; i > 0; i--)
                    {
                        if (dumpedCode[i] != '"')
                            imagelink = dumpedCode[i] + imagelink;
                        else
                            i = 0;
                    }
                    if (imagelink != "")
                    {
                        if (imagelink[0] != 'h' && imagelink[1] != 't' && imagelink[2] != 't' && imagelink[3] != 'p')
                        {
                            imagelink = webUrl + imagelink;
                        }
                    }
                    imageurls.Add(imagelink + firstMarker);
                    dumpedCode = dumpedCode.Remove(0, indx + 3);
                }
                return imageurls;
            }
            return imageurls;
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
