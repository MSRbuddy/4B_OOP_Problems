namespace JSON_InventoryManagement
{
    // this is the class for seeds for every type
    public class Inventory
    {
        public int Sum { get; set; }
        public List<Seeds> Rice;
        public List<Seeds> Pulses;
        public List<Seeds> Wheats;
    }
    public class Seeds
    {
        public string brand;
        public int PricePerKg;
        public int Weight;
        public int TotalPrice;
        // this method is to represent the object into String format
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}\nTotalPrice:\t{3}", this.brand, this.PricePerKg, this.Weight, this.TotalPrice);
        }
    }

}