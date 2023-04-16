namespace CommercialDataProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Commercial Data Processing program!");
            
            AccountManagement accountManagement= new AccountManagement();
            accountManagement.DriverMethod();
        }
    }
}