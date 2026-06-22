namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory;

            factory = new WordFactory();
            factory.CreateDocument().Open();

            factory = new PdfFactory();
            factory.CreateDocument().Open();

            factory = new ExcelFactory();
            factory.CreateDocument().Open();
        }
    }
}