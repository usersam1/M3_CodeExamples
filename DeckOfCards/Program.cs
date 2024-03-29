﻿using System;

namespace DeckOfCards
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public string StringToPrint => $"{Value} of {Color}, a {BlackOrRed} card";
		//exactly the same as above
		public string StringToPrint1
		{
			get
			{
				return $"{Value} of {Color}, a {BlackOrRed} card";
			}
		}

		public PlayingCard() { }
		public PlayingCard (bool HigestOrLowest)
		{ 
			if (HigestOrLowest)
            {
				Color = PlayingCardColor.Spades;
				Value = PlayingCardValue.Ace;
            }
			else
            {
				Color = PlayingCardColor.Clubs;
				Value = PlayingCardValue.Two;
            }
		}
		public PlayingCard(bool HigestOrLowest, PlayingCardColor Color)
		{
			this.Color = Color;
			if (HigestOrLowest)
			{
				Value = PlayingCardValue.Ace;
			}
			else
			{
				Value = PlayingCardValue.Two;
			}
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
			PlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Queen };
            Console.WriteLine(card1.StringToPrint);

			PlayingCard card2 = new PlayingCard(true);
			Console.WriteLine(card2.StringToPrint);

			PlayingCard card3 = new PlayingCard(false, PlayingCardColor.Clubs);
			Console.WriteLine(card3.StringToPrint);
		}
	}
}
//Group Exercise1
//1.	Modify PlayingCard so the Data Members Color and Value becomes properties that can be read by all users of the type but only set during initialization
//2.	Modify PrintOut() so it becomes a property named StringToPrint
//3.	Add a property of type string to PlayingCard named BlackOrRed that returns the string "Black" for Clubs and Spades, otherwise "Red"
//4.	Modify StringToPrint to also include if the card is Red or Black in the string to printout

//Group Exercise2
//1.	Create a constructor to PlayingCard that takes one parameter, HigestOrLowest, of type bool
//		and if true initialize the instance to Ace of Spades, otherwise initializes the instance to Two of Clubs.
//2.	Create another constructor that takes two parameters HigestOrLowest (type bool) and Color (type PlayingCardColor).
//		Creates an instance of the higest and lowest card of that specific color

