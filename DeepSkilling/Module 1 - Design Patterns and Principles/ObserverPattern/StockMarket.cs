using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockMarket : IStock
    {
        private List<IObserver> observers = new List<IObserver>();

        private string stockName;
        private double price;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(stockName, price);
            }
        }

        public void SetStock(string stockName, double price)
        {
            this.stockName = stockName;
            this.price = price;

            NotifyObservers();
        }
    }
}