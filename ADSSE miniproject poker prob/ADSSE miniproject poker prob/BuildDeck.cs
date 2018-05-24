using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{

    //card object
    public class BuildDeck
    {
        public class Card
        {
            //card variables
            public int suit;
            public int rank;

            public Card(int suit, int rank)
            {
                this.suit = suit;
                this.rank = rank;
            }


        }

        //build the deck of cards
        public List<Card> myDeck()
        {
            //initialize list of cards or the deack
            List<Card> cards = new List<Card>();
            //run through the card suits
            //0 = Hearts, 1 = Spades, 2 = Diamonds, 3 = Clubs
                for(int i = 0; i <= 3; i++)
                {
                //run through the card ranks
                // 0 = Ace , 13 = King
                    for (int j = 0; j <= 13; j++)
                    {
                        cards.Add(new Card(i, j));
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
