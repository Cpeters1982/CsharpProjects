using System.Collections.Generic;
using System;
namespace deck_of_cards
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            reset();
            shuffle();
        }
        public Deck reset()
        {
            cards = new List<Card>();
            string[] suits = {"Hearts","Diamonds","Spades","Clubs"};
            string[] strVals = {"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
            // for each suit assemble set of cards
            foreach(string Suit in suits)
            {
                // build out set of individual cards, ye?
                for (int i = 0; i<strVals.Length;i++)
                {
                    Card noob = new Card(strVals[i], Suit, i+1);
                    cards.Add(noob);
                }
            }
            return this;
        }

        public Deck shuffle()
        {
            // iterate backwards through our deck!
            Random rando = new Random();
            for (int end = cards.Count-1; end > 0; end--)
            {
                // grab a random card
                int randx = rando.Next(end);
                Card temp = cards[randx];
                // swap it with our end value
                cards[randx] = cards[end];
                cards[end] = temp;
            }
            return this;
        }

        public Card deal()
        {
            if (cards.Count > 0)
            {
                // grab top card
                Card res = cards[0];
                // remove said card
                cards.RemoveAt(0);
                // return said card
                return res;
            }
            else{
                reset();
                return deal();
            }
        }
    }

}