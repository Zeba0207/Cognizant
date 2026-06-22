namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockMarket stockMarket = new StockMarket();

            MobileApp mobile = new MobileApp();
            WebApp web = new WebApp();

            stockMarket.RegisterObserver(mobile);
            stockMarket.RegisterObserver(web);

            stockMarket.SetStock("TCS", 4200);

            stockMarket.RemoveObserver(web);

            stockMarket.SetStock("Infosys", 1800);
        }
    }
}