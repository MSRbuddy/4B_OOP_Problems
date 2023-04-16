namespace CommercialDataProcessing
{
   
    // class as an account data type
    public class StockAccount
    {
        //variable to hold the data about account 
        public double Cash { get; set; }

        public string Name { get; set; }

        public int N { get; set; }

        public List<int> Shares { get; set; }

        public List<string> Stocks { get; set; }

        public List<int> StockPrice { get; set; }

        public DateTime Timing = DateTime.Now;

        // constructor to initialize the customer Name
        public void Fill(string Name)
        {
            //taking the inputs from the user
            Console.WriteLine("Enter the Cash balance");
            this.Cash = double.Parse(Console.ReadLine());

            //initialized the Name
            this.Name = Name;

            Console.WriteLine("Enter the number of Stocks purchased");
            this.N = int.Parse(Console.ReadLine());

            //initializing the values
            this.Shares = new List<int>();
            this.Stocks = new List<string>();
            this.StockPrice = new List<int>();

            //loop to fetch the array details
            for (int i = 0; i < this.N; i++)
            {
                Console.Write("enter the Name of Stock: ");
                this.Stocks.Add(Console.ReadLine());
                Console.Write("Enter the number of Shares: ");
                this.Shares.Add(int.Parse(Console.ReadLine()));
                Console.Write("Enter the Price/share: ");
                this.StockPrice.Add(this.Shares[i] * int.Parse(Console.ReadLine()));
            }
        }

        // it returns sum of all the stocks and shares sum price
        public double ValueOf()
        {
            double grandTotal = 0;

            for (int i = 0; i < this.N; i++)
            {
                grandTotal += this.StockPrice[i];
            }

            return grandTotal;
        }

        // prints all the details of the Account
        public void PrintReport()
        {
            Console.WriteLine("{0,-25}{1}", "Customer Name is:", this.Name);
            Console.WriteLine("{0,-25}{1}", "Account Balance is:", this.Cash);
            Console.Write("{0,-25}", "Account opened at:");
            Console.WriteLine("{0:d} {0:t}", this.Timing);
            for (int i = 0; i < this.N; i++)
            {
                Console.WriteLine("{0,-25}{1}", "stock symbol:", this.Stocks[i]);
                Console.WriteLine("{0,-25}{1}", "number of shares:", this.Shares[i]);
                Console.WriteLine("{0,-25}{1}", "total Price of stock is:", this.StockPrice[i]);
            }
        }
    }
}