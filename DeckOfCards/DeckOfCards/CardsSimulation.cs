namespace DeckOfCards
{
    // to distribute cards to players
    public class CardsSimulation
    {
        //  method to invoke DeckOfCards class
        public void DriverMethod()
        {
            //this will create a deck of cards
            DeckOfCards deckOfCards = new DeckOfCards();
            // this will shuffle the deck of cards
            deckOfCards.Shuffle();

            Player[] players = new Player[4];
            // initializing the List and player objects to fill them further
            for (int i = 0; i < 4; i++)
            {
                players[i] = new Player();
                players[i].cards = new List<Card>();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    players[i].cards.Add(deckOfCards.TakeCard());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(players[i]);
            }
        }
    }
    
    // this player object will store the number of cards distributed to him
    public class Player
    {
        public List<Card> cards;
       
        // this is to represent the player object in string format
        public override string ToString()
        {
            return cards.ToString();
        }
    }
}