using LibImageScraper;
using LibImageScraper.Scrapers;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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

            IMAGESCRAPER.Scrape();
            List<Dump> result = IMAGESCRAPER.ReturnDump();
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
                ImagePreview preview = new ImagePreview(clicked);
                preview.Show();
            }

        }
    }
}
