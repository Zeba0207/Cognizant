namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddProduct(new Product(1, "Laptop", 10, 50000));
            inventory.AddProduct(new Product(2, "Mouse", 50, 500));

            inventory.DisplayProducts();

            inventory.UpdateProduct(1, 15, 52000);

            inventory.DisplayProducts();

            inventory.DeleteProduct(2);

            inventory.DisplayProducts();
        }
    }
}