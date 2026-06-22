using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }

    public Product(int id, string name)
    {
        ProductId = id;
        ProductName = name;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (var product in products)
        {
            if (product.ProductId == id)
                return product;
        }
        return null;
    }

    static Product BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];

            if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop"),
            new Product(102,"Phone"),
            new Product(103,"Tablet"),
            new Product(104,"Watch"),
            new Product(105,"Headphones")
        };

        Product result1 = LinearSearch(products, 104);

        Console.WriteLine("Linear Search Result:");
        Console.WriteLine(result1?.ProductName);

        Product result2 = BinarySearch(products, 104);

        Console.WriteLine("Binary Search Result:");
        Console.WriteLine(result2?.ProductName);
    }
}