namespace JSON_InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON Inventory Management Program!");
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.DriverMethod();
        }
    }
}