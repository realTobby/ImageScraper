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
        OnlineHTMLScraper IMAGESCRAPER;
        public MainWindow()
        {
            InitializeComponent();
            IMAGESCRAPER = new OnlineHTMLScraper("https://www.google.com");          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxResult.Items.Clear();
            if(!string.IsNullOrEmpty(textBoxUrl.Text))
                IMAGESCRAPER.SetSource(textBoxUrl.Text);

            List<Dump> result = IMAGESCRAPER.Scrape();
            foreach(var item in result)
            {
                listBoxResult.Items.Add(item.Path);
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
    }
}
