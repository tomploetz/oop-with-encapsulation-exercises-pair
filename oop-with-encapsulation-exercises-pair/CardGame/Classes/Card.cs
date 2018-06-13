using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Classes
{
	class Card
	{
		//properties
		public string Suit { get; }
		public int Value { get; }
		public bool IsFaceUp { get; private set; } = false;
		public string Color
		{
			get
			{
				if(Suit == "Hearts" || Suit == "Diamonds")
				{
					return "red";
				}
				else
				{
					return "black";
				}
			}			
		}
		public string FaceValue
		{
			get
			{
				if(Value == 1)
				{
					return "Ace of " + Suit;
				}
				else if(Value == 11)
				{
					return "Jack of " + Suit;
				}
				else if(Value == 12)
				{
					return "Queen of " + Suit;
				}
				else if(Value == 13)
				{
					return "King of " + Suit;
				}
				return Value + " of " + Suit;
			}
		}


		//constructors
		public Card(string suit, int value)
		{
			Suit = suit;
			Value = value;
		}


		//method
		public void TurnOver()
		{
			IsFaceUp = !IsFaceUp;
		}

		override public string ToString()
		{
			return FaceValue;
		}
	}
}
