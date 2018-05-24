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
            public bool available;

            public Card(int suit, int rank, bool available)
            {
                this.suit = suit;
                this.rank = rank;
                this.available = available;
            }


        }

        //build the deck of cards
        public List<Card> myDeck()
        {
            //initialize list of cards or the deack
            List<Card> cards = new List<Card>();
            //run through the card suits
            //0 = Hearts, 1 = Clubs, 2 = Diamonds, 3 = Spades
                for(int i = 0; i <= 3; i++)
                {
                //run through the card ranks
                // 0 = Ace , 12 = King
                    for (int j = 0; j <= 12; j++)
                    {
                        cards.Add(new Card(i, j, true));
                    }
                }   
            return cards;
        }

        public int CardsLeft(List<Card> deck)
        {
            int amountOfCardsLeft = 0;

            for(int c = 0; c < deck.Count; c++)
            {
                if(deck[c].available) amountOfCardsLeft += 1;
            }
            return amountOfCardsLeft;
        }

        public int TypeOfCardLeft(List<Card> deck, int i)
        {
            int typeLeft = 0;
            for (int a = 0; a < deck.Count; a++)
            {
                if (deck[a].rank == i && deck[a].available) typeLeft += 1;
            }
            return typeLeft;
        }

        public int AcesLeft(List<Card> deck)
        {
            int acesLeft = 0;
            for (int a = 0; a < deck.Count; a++)
            {
                if(deck[a].rank == 0 && deck[a].available) acesLeft += 1;
            }
            return acesLeft;
        }

        public int TwosLeft(List<Card> deck)
        {
            int twosLeft = 0;
            for(int tw = 0; tw < deck.Count; tw++)
            {
                if (deck[tw].rank == 1 && deck[tw].available) twosLeft += 1;
            }
            return twosLeft;
        }

        public int ThreesLeft(List<Card> deck)
        {
            int threesLeft = 0;
            for(int th = 0; th < deck.Count; th++)
            {
                if (deck[th].rank == 2 && deck[th].available) threesLeft += 1;
            }
            return threesLeft;
        }

        public int FoursLeft(List<Card> deck)
        {
            int foursLeft = 0;
            for (int fo = 0; fo < deck.Count; fo++)
            {
                if (deck[fo].rank == 3 && deck[fo].available) foursLeft += 1; 
            }
            return foursLeft;
        }

        public int FivesLeft(List<Card> deck)
        {
            int fivesLeft = 0;
            for(int fv = 0; fv < deck.Count; fv++)
            {
                if (deck[fv].rank == 4 && deck[fv].available) fivesLeft += 1;
            }
            return fivesLeft;
        }

        public int SixsLeft(List<Card> deck)
        {
            int sixsLeft = 0;
            for(int si = 0; si < deck.Count; si++)
            {
                if (deck[si].rank == 5 && deck[si].available) sixsLeft += 1;
            }
            return sixsLeft;
        }

        public int SevensLeft(List<Card> deck)
        {
            int sevensLeft = 0;
            for(int sv = 0; sv < deck.Count; sv++)
            {
                if (deck[sv].rank == 6 && deck[sv].available) sevensLeft += 1;
            }
            return sevensLeft;
        }

        public int EightsLeft(List<Card> deck)
        {
            int eightsLeft = 0;
            for (int e = 0; e < deck.Count; e++)
            {
                if (deck[e].rank == 7 && deck[e].available) eightsLeft += 1;
            }
            return eightsLeft;
        }

        public int NinesLeft(List<Card> deck)
        {
            int ninesLeft = 0;
            for (int n = 0; n < deck.Count; n++)
            {
                if (deck[n].rank == 8 && deck[n].available) ninesLeft += 1;
            }
            return ninesLeft;
        }

        public int TensLeft(List<Card> deck)
        {
            int tensLeft = 0;
            for (int ten = 0; ten < deck.Count; ten++)
            {
                if (deck[ten].rank == 9 && deck[ten].available) tensLeft += 1;
            }
            return tensLeft;
        }

        public int JacksLeft(List<Card> deck)
        {
            int jacksLeft = 0;
            for (int j = 0; j < deck.Count; j++)
            {
                if (deck[j].rank == 10 && deck[j].available) jacksLeft += 1;
            }
            return jacksLeft;
        }

        public int QueensLeft(List<Card> deck)
        {
            int queensLeft = 0;
            for (int q = 0; q < deck.Count; q++)
            {
                if (deck[q].rank == 11 && deck[q].available) queensLeft += 1;
            }
            return queensLeft;
        }

        public int KingsLeft(List<Card> deck)
        {
            int kingsLeft = 0;
            for (int k = 0; k < deck.Count; k++)
            {
                if (deck[k].rank == 12 && deck[k].available) kingsLeft += 1;
            }
            return kingsLeft;
        }

        public int HeartsLeft(List<Card> deck)
        {
            int heartlsLeft = 0;
            for (int hl = 0; hl < deck.Count; hl++)
            {
                if (deck[hl].suit == 0 && deck[hl].available) heartlsLeft += 1;
            }
            return heartlsLeft;
        }

        public int ClubsLeft(List<Card> deck)
        {
            int clubsLeft = 0;
            for (int cl = 0; cl < deck.Count; cl++)
            {
                if (deck[cl].suit == 1 && deck[cl].available) clubsLeft += 1;
            }
            return clubsLeft;
        }

        public int DiamondsLeft(List<Card> deck)
        {
            int diamondsLeft = 0;
            for (int dl = 0; dl < deck.Count; dl++)
            {
                if (deck[dl].suit == 2 && deck[dl].available) diamondsLeft += 1;
            }
            return diamondsLeft;
        }

        public int SpadesLeft(List<Card> deck)
        {
            int spadesLeft = 0;
            for (int sl = 0; sl < deck.Count; sl++)
            {
                if (deck[sl].suit == 3 && deck[sl].available) spadesLeft += 1;
            }
            return spadesLeft;
        }
    }
}
