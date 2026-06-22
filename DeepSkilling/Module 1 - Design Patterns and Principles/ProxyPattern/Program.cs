using System;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("photo.jpg");

            Console.WriteLine("First call:");
            image.Display();

            Console.WriteLine();

            Console.WriteLine("Second call:");
            image.Display();
        }
    }
}