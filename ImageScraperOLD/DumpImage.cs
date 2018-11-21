using System.Drawing;
namespace _ImageScraper
{
    /// <summary>
    /// Class that keeps track of image and extension
    /// </summary>
    public class DumpImage
    {
        private Bitmap _image;
        public Bitmap Image
        {
            get { return _image; }
        }
        private string _extension;
        public string Extension
        {
            get { return _extension; }
        }

        public DumpImage(Bitmap image, string extension)
        {
            _image = image;
            _extension = extension;
        }
    }
}
