using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Classes
{
	class Deck
	{
		//card list
		private List<Card> Cards { get; set; } = new List<Card>();


		//properties
		public int NumberOfCardsRemaining
		{
			get
			{
				return Cards.Count();
			}
		}


		//constructor
		public Deck()
		{
			LoadDeck();
		}


		//methods
		private void LoadDeck()
		{
			string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
			Cards.Clear();
			foreach (string suit in suits)
			{
				for (int i = 1; i <= 13; i++)
				{
					Card c = new Card(suit, i);
					Cards.Add(c);
				}
			}
		}

		public Card[] Draw(int numberOfCards)
		{
			Card[] numCards = new Card[numberOfCards];

			Card result = null;
			for(int i = 0; i < numCards.Length; i++)
			{
				// If there are 1 or more cards in the "Cards" list
				if (Cards.Count > 0)
				{
					// Retrieve the first "Card"/element out of the Cards list.
					result = Cards[0];
					numCards[i] = result;
					// Removing from the card list
					Cards.Remove(result);
				}
			}			
			// Give to the class that requested the card
			return numCards;
		}

		public void ListCards()
		{
			foreach(Card card in Cards)
			{
				Console.WriteLine(card.ToString());
			}
		}

		public void Shuffle()
		{
			Random rnd = new Random();
			LoadDeck();
			for (int i = 0; i < 500; i++)
			{
				int position1 = rnd.Next(0, 51);
				int position2 = rnd.Next(0, 51);
				Card tempCard = Cards[position1];
				Cards[position1] = Cards[position2];
				Cards[position2] = tempCard;
			}
		}
	}
}

