using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace _4chanDumper
{
    public partial class MainFormImageScraper : Form
    {
        public List<string> urlList = new List<string>();
        public List<Image> dumpedList = new List<Image>();
        public int currentShow = 0;
        public int maxShow = 0;
        public Random rnd = new Random();
        public string currentDumpedCode = "No code dumped yet.";

        public MainFormImageScraper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public List<string> DumpImageFormat(string format, string dumpedCode)
        {
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
                if (imagelink != "")
                {
                    if (imagelink[0] != 'h' && imagelink[1] != 't' && imagelink[2] != 't' && imagelink[3] != 'p')
                    {
                        imagelink = textBox_url.Text + imagelink;
                    }
                }
                imageurls.Add(imagelink + firstMarker);
                dumpedCode = dumpedCode.Remove(0, indx + 3);
            }
            return imageurls;
        }

        public void GetImageFromURL(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse resp = req.GetResponse();
                Bitmap img = new Bitmap(resp.GetResponseStream());
                dumpedList.Add(img);
                pictureBox_preview.Image = img;
                pictureBox_preview.Update();
            }
            catch(Exception)
            {

            }
         }

        void DumpNLogEverything(List<List<string>> imageLists)
        {
            progessBar_dump.Maximum = 0;
            foreach (var item in imageLists)
            {
                progessBar_dump.Maximum = progessBar_dump.Maximum + item.Count;
            }

            foreach (var item in imageLists)
            {
                foreach (var listItem in item)
                {
                    textBox_log.Text = textBox_log.Text + Environment.NewLine + listItem;
                    textBox_log.Update();
                    GetImageFromURL(listItem);
                    progessBar_dump.Value = progessBar_dump.Value + 1;
                    progessBar_dump.Update();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            progessBar_dump.Value = 0;
            dumpedList = new List<Image>();
            string txtUrl = textBox_url.Text;
            if(txtUrl[4] == 's')
            {
                txtUrl = txtUrl.Remove(4,1);
            }
            if(txtUrl[txtUrl.Length-1] == '/')
            {
                txtUrl = txtUrl.Remove(txtUrl.Length - 1);
            }
            textBox_url.Text = txtUrl;



            textBox_log.Text = "";
            string dumpedCode = DumpHTML(textBox_url.Text);
            currentDumpedCode = dumpedCode;
            System.IO.File.WriteAllText("dumpedCode.txt", dumpedCode);
            System.IO.Directory.CreateDirectory("dumpedImages");

            List<string> dumpedPngs = DumpImageFormat(".png", dumpedCode);
            List<string> dumpedJpgs = DumpImageFormat(".jpg", dumpedCode);
            List<string> dumpedGifs = DumpImageFormat(".gif", dumpedCode);

            List<List<string>> dumpingList = new List<List<string>>();
            dumpingList.Add(dumpedPngs);
            dumpingList.Add(dumpedJpgs);
            dumpingList.Add(dumpedGifs);

            DumpNLogEverything(dumpingList);

            if(check_openDirectory.Checked == true)
                Process.Start("dumpedImages");
            pictureBox_preview.Image = dumpedList[0];
            
            maxShow = dumpedList.Count;


        }

        public string DumpHTML(string url)
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
            return code;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Delete("dumpedImages", true);
            System.IO.Directory.CreateDirectory("dumpedImages");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!System.IO.Directory.Exists("archive"))
            {
                System.IO.Directory.CreateDirectory("archive");
            }


            string startPath = "dumpedImages";
            string zipPath = "archive/" + System.IO.Directory.GetFiles("archive").Count() + ".zip";

            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("dumpedImages");
        }

        private void button2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                currentShow = currentShow - 1;
                if (currentShow < 0)
                    currentShow = dumpedList.Count - 1;
                if (currentShow > dumpedList.Count)
                    currentShow = 0;

                pictureBox_preview.Image = dumpedList[currentShow];
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                currentShow = currentShow + 1;
                if (currentShow < 0)
                    currentShow = dumpedList.Count - 1;
                if (currentShow > dumpedList.Count)
                    currentShow = 0;

                pictureBox_preview.Image = dumpedList[currentShow];
            }catch(Exception ex)
            {

            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(var item in dumpedList)
            {
                item.Save("dumpedImages/" + System.IO.Directory.GetFiles("dumpedImages").Length + ".png");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                pictureBox_preview.Image.Save("dumpedImages/" + System.IO.Directory.GetFiles("dumpedImages").Length + ".png");
            }catch(Exception ex)
            {
                // lmao dont be stoopid
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox_preview.Image = null;
            dumpedList = new List<Image>();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = rnd.Next(0, dumpedList.Count - 1);

                pictureBox_preview.Image = dumpedList[tmp];
            }catch(Exception ex)
            {
                // lmao dont be stoopid
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(currentDumpedCode);
        }
    }
}
