using LibImageScraper;
using LibImageScraper.Scrapers;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ImageScraperGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        IScraper IMAGESCRAPER = null;
        public MainWindow()
        {
            InitializeComponent();


            LoadScrapers();
                 
        }

        private void LoadScrapers()
        {
            scrapeSelect.Items.Add("Online4chanScraper");
            scrapeSelect.Items.Add("OnlineHTMLScraper");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxResult.Items.Clear();
            if (!string.IsNullOrEmpty(textBoxUrl.Text))
            {
                switch (scrapeSelect.SelectedItem.ToString())
                {
                    case "Online4chanScraper":
                        IMAGESCRAPER = new Online4chanScraper(textBoxUrl.Text);
                    break;
                    case "OnlineHTMLScraper":
                        IMAGESCRAPER = new OnlineHTMLScraper(textBoxUrl.Text);
                        break;
                }

                if(IMAGESCRAPER != null)
                {
                    List<Dump> result = IMAGESCRAPER.Scrape();
                    foreach (var item in result)
                    {
                        listBoxResult.Items.Add(item.Path);
                    }
                }

                
            }
            
        }

        private void listBoxResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxResult.SelectedItem != null)
            {

                string clicked = listBoxResult.SelectedItem.ToString();
                try
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(clicked, UriKind.Absolute);
                    bitmap.EndInit();

                    imagePreview.Source = bitmap;
                }catch(Exception gex)
                {
                    Console.WriteLine(gex.Message);
                    listBoxResult.Items.Clear();
                }
                    

                
            }

        }

        private void btn_downloadAll_Click(object sender, RoutedEventArgs e)
        {
            foreach(var url in listBoxResult.Items)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(url.ToString(), UriKind.Absolute);
                image.EndInit();
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));

                using (var fileStream = new System.IO.FileStream(GenerateRandomFileName() + ".png", System.IO.FileMode.Create))
                {
                    encoder.Save(fileStream);
                }
            }
        }

        private string GenerateRandomFileName()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz1234567890";
            string returnName = "is_";
            int length = random.Next(6,12);
            for(int i = 0; i < length; i++)
            {
                int nxtChar = random.Next(0, abc.Length);
                if(i == nxtChar)
                {
                    returnName = returnName + abc[random.Next(0, abc.Length)].ToString().ToUpper();
                }else
                {
                    returnName = returnName + abc[random.Next(0, abc.Length)].ToString().ToLower();
                }
                
            }
            return returnName;
        }

    }
}
