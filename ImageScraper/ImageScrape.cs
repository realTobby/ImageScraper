using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ImageScraper
{
    public static class ImageScrape
    {
        private static string dumpedCode;
        private static string webUrl;
        private static List<string> filterList = new List<string>();

        private static List<DumpImage> dumpedList = new List<DumpImage>();
        public static List<DumpImage> DumpedList
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

        /// <summary>
        /// returns all image links that were found
        /// </summary>
        /// <param name="imageUrls"></param>
        /// <returns></returns>
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

        /// <summary>
        /// gets the html code of a website
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string DumpHTML(string url)
        {
            Console.WriteLine("Called function DumpHTML()");
            try
            {
                string urlAddress = url;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);

                //Fix for the issues with TLS/SSL
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

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
                MessageBox.Show(ex.Message);
                // ugly excpetion until i find a better solution
                return "";
            }
        }

        /// <summary>
        /// will prepare the url so it will work (removes the s in https and the last /)
        /// </summary>
        /// <param name="enteredUrl"></param>
        /// <returns></returns>
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

        /// <summary>
        /// will dump the specified image witth image format
        /// </summary>
        /// <param name="format"></param>
        /// <param name="dumpedCode"></param>
        /// <returns></returns>
        public static List<string> DumpImageFormat(string format, string dumpedCode)
        {
            Console.WriteLine("Called function DumpImageFormat(" + format + ", dumpedCode)");
            List<string> imageurls = new List<string>();
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
                //Fix added for imageLink not being longer than 4 so the statement below crashed 
                if (imagelink != "" && imagelink.Length > 4)
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

        /// <summary>
        /// simple check if the entered url is valid
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
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
        /// <summary>
        /// resets the dumpedList to no entries
        /// </summary>
        public static void ResetDumpedList()
        {
            Console.WriteLine("Called function ResetDumpedList()");
            dumpedList = new List<DumpImage>();
        }
      
        /// <summary>
        /// gets the image corresponding with the url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
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
                    // TODO: ugly exception, this stays until i find another solution to this
                }
                return img;
            }
            return img;
        }

        /// <summary>
        /// will save the filter options
        /// </summary>
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

        /// <summary>
        /// will load the filter options
        /// </summary>
        public static void LoadFilter()
        {
            Console.WriteLine("Called function LoadFilter()");
            if (File.Exists("filter.txt"))
            {
                var tmp = System.IO.File.ReadAllLines("filter.txt");
                filterList = new List<string>();
                foreach (var item in tmp)
                {
                    filterList.Add(item);
                }
            }

            //Checks if there are filters set
            if (ImageScrape.FilterList.Count <= 0)
            {
                MessageBox.Show("You need to add an filter first! (ex: .png, .bmp, .gif)");
            }
        }
    }
}
