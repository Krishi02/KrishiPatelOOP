using System;
using System.Collections.Generic;
using System.ComponentModel;
using static CMP1903M_A01_2223.Card;

namespace CMP1903M_A01_2223
{
    class Card
    {
        // This is the card values ace(1) - king(13)
        public enum Value
        {
            Ace =1, Two = 2, Three = 3 , Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King= 13
        }
        // This is the suits for the cards 
        public enum Suit
        {
            Spade = 1, Heart = 2, Diamond = 3, Club = 4
        }
        // Properties to get and set the values of suit and value
        public Value CardValue { get; set; }
        public Suit CardSuit { get; set; }
        // Constructor to create cards with the value and suit
        public Card(Value value, Suit suit)
        {
            CardValue = value;
            CardSuit = suit;
        }
        // This had to be used to override the string rep
        public override string ToString()
        {
            return CardValue.ToString() + " of " + CardSuit.ToString() + "s";
        }
    }
    class Pack
    {   // List to hold all values
        private List<Card> cards;
        //creates the pack of cards
        public Pack()
        {
            cards = new List<Card>();
            //Creates cards with the combo of values and suits
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Card.Value value in Enum.GetValues(typeof(Card.Value)))
                {
                    cards.Add(new Card(value, suit));
                }

            }

        }
        // Shuffles the cards
        public void ShuffleCardPack()
        {
            //Shuffles the pack based on the type of shuffle
            //fisher-yates shuffle
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }

        }
        // Deals the cards
        public Card Deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;

        }
        public List<Card> DealCards(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealCards.Add(Deal());
            }
            return dealCards;
        }
        public void PrintPack()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   // Creates a pack
            Pack pack = new Pack();
            //Prints out deck
            Console.WriteLine("Complete Deck");
            pack.PrintPack();
            //Shuffles the deck
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            pack.ShuffleCardPack();
            //Prints out shuffled deck
            Console.WriteLine("SHUFFLE COMMENCING");
            pack.PrintPack();
        }
    }
}