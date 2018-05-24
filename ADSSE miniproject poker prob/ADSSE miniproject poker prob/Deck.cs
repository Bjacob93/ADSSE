using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{
    private Card[]

    public class Deck
    {
       cards[] = new Card[52]; 

        public int[] randNum()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 5);
            return num;
        }

    }

    class Card
    {
        public int Rank, Suit;

        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}
