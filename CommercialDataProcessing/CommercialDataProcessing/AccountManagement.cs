using Newtonsoft.Json;

namespace CommercialDataProcessing
{
    // this class manages the StockAccounts class
    public class AccountManagement
    {
        private static string path = @"C:\Users\USER\source\BL\CommercialDataProcessing\CommercialDataProcessing\Accounts.json";
   
        // this method is used to run the Account Management program
        public void DriverMethod()
        {
            //creating own class to use its Methods
            AccountManagement ac = new AccountManagement();
            Console.WriteLine("Welcome to Stock Accounts\n" +
                "Enter 1 to dispaly account report\n" +
                "Enter 2 to remove an account\n" +
                "Enter 3 to Add a New account");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter Name: ");
                    ac.AcReport(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter Name: ");
                    ac.Remove(Console.ReadLine());
                    break;
                case 3:
                    ac.Add();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        // to add new Accounts
        public void Add()
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            Console.WriteLine("enter the Name: ");
            StockAccount ac = new StockAccount();
            ac.Fill(Console.ReadLine());

            ls.Add(ac);

            string serial = JsonConvert.SerializeObject(ls);
            File.WriteAllText(path, serial);
            Console.WriteLine("done");

            //directly writing into file
            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }

            Console.WriteLine("Successfully added");
        }

        // to remove existing accounts
        public void Remove(string name)
        {
            // fetching string from json
            string jfile = File.ReadAllText(path);

            // initializing the Object
            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            // iterating through List of Objects
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Name.Equals(name))
                {
                    ls.Remove(ls[i]);
                    break;
                }
            }

            // directly writing into json file
            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }

            Console.WriteLine("removed successfully");
        }

        // this method is to display the details of respective account name
        public void AcReport(string name)
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            // iterating the List of Account objects
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Name.Equals(name))
                {
                    ls[i].PrintReport();
                    break;
                }
            }
        }
    }
}