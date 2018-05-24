using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{


    public class BuildDeck
    {
        enum CardSuit { Diamonds, Hearts, Clubs, Spades }

        public class Card
        {
            private CardSuit suit;
            private int rank;

            public Card(CardSuit suit, int rank)
            {
                this.suit = suit;
                this.rank = rank;
            }

        }


        public List<Card> myDeck()
        {
            List<Card> cards = new List<Card>();
            foreach(CardSuit s in Enum.GetValues(typeof(CardSuit)))
            {
                for(int i = 1; i < 13; i++)
                {
                    cards.Add(new Card(s, i));
                }
            }
            return cards;
        }

        /*class Deck
        {
            List<Card> Cards { get; set; }
            public Deck()
            {
                Cards = new List<Card>();
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    for (int i = 1; i < 13; i++)
                    {
                        Cards.Add(new Card(s, i));
                    }
                }
            }
            public List<Card> MyDeck
            {
                get { return Cards; }
            }
        }*/
    }
}
