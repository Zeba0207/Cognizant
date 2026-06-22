using System;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading image: " + fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + fileName);
        }
    }
}