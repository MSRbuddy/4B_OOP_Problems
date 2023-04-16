namespace DeckOfCards
{
    // Class Card for poker simulation
    public class Card
    {
        private string suit, value;
        
        // card Constructor
        public Card(string tvalue, string tsuit)
        {
            this.suit = tsuit;
            this.value = tvalue;
        }
        
        // to represent card object as string
        public override string ToString()
        {
            return this.value + " of " + this.suit;
        }
    }
}