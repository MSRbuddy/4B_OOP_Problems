﻿namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deck Of Cards program!");

            CardsSimulation cardsSimulation = new CardsSimulation();
            cardsSimulation.DriverMethod();
        }
    }
}