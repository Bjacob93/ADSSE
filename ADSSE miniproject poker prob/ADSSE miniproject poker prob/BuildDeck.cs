using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{

    public class BuildDeck
    {
        enum Suit { Diamonds, Hearts, Clubs, Spades}
        
        class Deck
        {
            public List<Card> Cards { get; set; }
            public Deck()
            {
                Cards = new List<Card>();
                foreach(Suit s in Enum.GetValues(typeof(Suit)))
                {
                    for(int i = 1; i < 13; i++)
                    {
                        Cards.Add(new Card(s, i));
                    }
                }
            }
        }

        class Card
        {
            Suit suit { get; set; }
            int rank { get; set; }
            public Card(Suit s, int r)
            {
                suit = s;
                rank = r;
            }
        }

    }
}
