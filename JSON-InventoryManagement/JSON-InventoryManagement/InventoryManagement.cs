namespace JSON_InventoryManagement
{
    // this is the Main Inventory Object Class Which Stores further List of seeds Objects
    public class InventoryManagement
    {
        public void DriverMethod()
        {
            Console.WriteLine("Welcome to Inventory MAnagement");
            InventoryImplementation imp = new InventoryImplementation();
            while (true)
            {
                Console.WriteLine("Enter A to Add\tEnter D to delete an Item");
                char entered = char.Parse(Console.ReadLine());
                switch (entered)
                {
                    case 'A':
                        imp.Add();
                        break;
                    case 'D':
                        imp.Delete();
                        break;
                    default:
                        Console.WriteLine("Enter a valid character");
                        break;
                }
                Console.WriteLine("enter yes/No to conitnue");
                if (Console.ReadLine() != "yes")
                {
                    break;
                }
            }
        }
    }
}
