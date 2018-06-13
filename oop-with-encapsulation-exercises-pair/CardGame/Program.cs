using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Classes;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
			Deck newDeck = new Deck();
			newDeck.Shuffle();
			Console.WriteLine("Creating a new deck...");
			Console.WriteLine("\n");
			newDeck.ListCards();
			Console.WriteLine("\n");
			Console.WriteLine("Drawn cards...");
			Console.WriteLine("\n");
			Card[] tempCards = newDeck.Draw(5);
			foreach(Card cards in tempCards)
			{
				Console.WriteLine(cards.ToString());
			}
			Console.WriteLine("\n");
			Console.WriteLine("New shuffled deck...");
			Console.WriteLine("\n");
			newDeck.ListCards();
			Console.WriteLine("\n");
			Console.ReadKey();
        }
    }
}
