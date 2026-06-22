using System;

namespace ObserverPattern
{
    public class MobileApp : IObserver
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine($"Mobile App: {stockName} price updated to {price}");
        }
    }
}