using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Compression;

namespace _ImageScraper
{
    public partial class MainFormImageScraper : Form
    {
        public int currentShow = 0;
        public int maxShow = 0;
        public Random rnd = new Random();

        private WebBrowser webBrowser = new WebBrowser();
        private Stopwatch timer = new Stopwatch();

        public MainFormImageScraper()
        {
            InitializeComponent();
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        /// <summary>
        /// The loading of the form just initializes the available filter options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ImageScrape.LoadFilter();
        }

        /// <summary>
        /// Will download all images in the imageLists list and write everything into the logConsoleTextBox
        /// </summary>
        /// <param name="imageLists"></param>
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
                    Bitmap tmp = ImageScrape.GetImageFromURL(listItem);

                    //## Added code - Aidan Fray ##
                    //Grabs extension
                    string[] parts = listItem.Split('.');
                    string extension = parts[parts.Length - 1]; //Assumes the last section is the file name
                    ImageScrape.DumpedList.Add(new DumpImage(tmp, "." + extension));

                    pictureBox_preview.Image = tmp;
                    pictureBox_preview.Update();
                    progessBar_dump.Value = progessBar_dump.Value + 1;
                    progessBar_dump.Update();
                    label_progress.Text = progessBar_dump.Value + "/" + GetMaxCount(imageLists);
                    label_progress.Update();
                }
            }
        }
        /// <summary>
        /// Just returns all entries in the imageList (the imageList concists of multiple lists) This will count trough them
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        int GetMaxCount(List<List<string>> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                foreach (var itemlist in item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>
        /// Inits the dumping process - Here is where the magic starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dump_Click(object sender, EventArgs e)
        {
            ImageScrape.LoadFilter();
            if(ImageScrape.FilterList.Count <= 0)
            {
                MessageBox.Show("You need to add an filter first! (ex: .png, .bmp, .gif)");
            }
            else
            {
                Duration1.Text = "...";
                timer.Restart();
                progessBar_dump.Value = 0;
                string webUrl = ImageScrape.PrepareUrl(textBox_url.Text);
                textBox_log.Text = "";

                webBrowser.Navigate(webUrl);
            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.IO.File.WriteAllText("dumpedCode.txt", webBrowser.DocumentText);
            System.IO.Directory.CreateDirectory("dumpedImages");

            var images = webBrowser.Document
                .GetElementsByTagName("img")
                .OfType<HtmlElement>()
                .Select(x => x.GetAttribute("src"))
                .ToList();

            List<List<string>> dumpingList = ImageScrape.GetAllImageLinks(images);

            label_progress.Text = "0/" + GetMaxCount(dumpingList);

            DumpNLogEverything(dumpingList);

            if (check_openDirectory.Checked == true)
                Process.Start("dumpedImages");

            pictureBox_preview.Image = ImageScrape.DumpedList[0].Image;

            maxShow = ImageScrape.DumpedList.Count;
            timer.Stop();
            Duration1.Text = timer.ElapsedMilliseconds + " ms";
            pictureBox_preview.Image = ImageScrape.DumpedList[0].Image;

            maxShow = ImageScrape.DumpedList.Count;
        }

        private void ClearDump_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Delete("dumpedImages", true);
            System.IO.Directory.CreateDirectory("dumpedImages");
        }

        private void ArchiveDump_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists("archive"))
            {
                System.IO.Directory.CreateDirectory("archive");
            }

            string startPath = "dumpedImages";
            string zipPath = "archive/" + System.IO.Directory.GetFiles("archive").Count() + ".zip";

            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);
        }

        private void OpenDump_Click(object sender, EventArgs e)
        {
            Process.Start("dumpedImages");
        }

        private void SaveDump_Click(object sender, EventArgs e)
        {
            foreach (var item in ImageScrape.DumpedList)
            {
                item.Image.Save("dumpedImages/" + System.IO.Directory.GetFiles("dumpedImages").Length + item.Extension);
            }
        }

        private void NewPreview_Left_Click(object sender, EventArgs e)
        {
            if (ImageScrape.DumpedList.Count > 0)
            {
                currentShow = currentShow - 1;
                if (currentShow < 0)
                    currentShow = ImageScrape.DumpedList.Count - 1;
                if (currentShow > ImageScrape.DumpedList.Count)
                    currentShow = 0;

                pictureBox_preview.Image = ImageScrape.DumpedList[currentShow].Image;
            }
        }
        private void NewPreview_Right_Click(object sender, EventArgs e)
        {
            if (ImageScrape.DumpedList.Count > 0)
            {
                currentShow = currentShow + 1;
                if (currentShow < 0)
                    currentShow = ImageScrape.DumpedList.Count - 1;
                if (currentShow > ImageScrape.DumpedList.Count)
                    currentShow = 1;

                pictureBox_preview.Image = ImageScrape.DumpedList[currentShow - 1].Image;
            }
        }
        private void NewPreview_Random_Click(object sender, EventArgs e)
        {
            if (ImageScrape.DumpedList.Count > 0)
            {
                int tmp = rnd.Next(0, ImageScrape.DumpedList.Count - 1);
                pictureBox_preview.Image = ImageScrape.DumpedList[tmp].Image;
            }
        }

        private void Preview_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox_preview.Image != null)
                pictureBox_preview.Image.Save("dumpedImages/" + System.IO.Directory.GetFiles("dumpedImages").Length + ".png");
        }
        private void Peview_Clean_Click(object sender, EventArgs e)
        {
            pictureBox_preview.Image = null;
            ImageScrape.ResetDumpedList();
        }

        private void button_addFilter_Click(object sender, EventArgs e)
        {
            ImageScrape.FilterList.Add(textBox_filter.Text);
            ImageScrape.SaveFilter();
            textBox_filter.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
