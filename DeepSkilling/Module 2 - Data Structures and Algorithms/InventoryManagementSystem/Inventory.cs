using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void AddProduct(Product product)
        {
            products[product.ProductId] = product;
            Console.WriteLine("Product added successfully.");
        }

        public void UpdateProduct(int id, int quantity, double price)
        {
            if (products.ContainsKey(id))
            {
                products[id].Quantity = quantity;
                products[id].Price = price;
                Console.WriteLine("Product updated successfully.");
            }
        }

        public void DeleteProduct(int id)
        {
            if (products.Remove(id))
            {
                Console.WriteLine("Product deleted successfully.");
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nInventory:");

            foreach (var product in products.Values)
            {
                Console.WriteLine(
                    $"ID: {product.ProductId}, Name: {product.ProductName}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
    }
}