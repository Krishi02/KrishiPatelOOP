namespace CMP1903M_A01_2223
{
        class Pack
    {
        // List to hold all values
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
}
