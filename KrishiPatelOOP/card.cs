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
