using LibImageScraper;
using LibImageScraper.Logic;
using LibImageScraper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            IMAGESCRAPER = new OnlineHTMLScraper("https://pokemondb.net/pokedex/national");          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBoxResult.Items.Clear();
            if(!string.IsNullOrEmpty(textBoxUrl.Text))
                IMAGESCRAPER.SetSource(textBoxUrl.Text);

            IMAGESCRAPER.Scrape();
            List<Dump> result = IMAGESCRAPER.ReturnResult();
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
