namespace StockAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stock Account Management program!");

            StockManagement stockManagement = new StockManagement();
            stockManagement.DriverMethod();
        }
    }
}