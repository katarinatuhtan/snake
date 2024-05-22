using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Food = LoadImage("Food.png");

        private static ImageSource LoadImage(string fileName)
        { return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative)); }
    }
}
