using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{
    class HandProbabilities
    {

        List<BuildDeck.Card> GameDeck = new List<BuildDeck.Card>();

        public float Probabilities(List<BuildDeck.Card> currentCards)
        {
            bool pair;
            float pairProbability = 0, twoPairProbability = 0;
            if(currentCards.Count == 2)
            {
                foreach(BuildDeck.Card c in currentCards){
                    foreach(BuildDeck.Card d in currentCards){
                        if(c != d){
                            if (c.rank == d.rank){
                                pair = true;
                                pairProbability = 100;
                            }else
                            {
                                pairProbability = ((6 / 50) * 100);
                            }
                        }
                    }
                }
            }
            return pairProbability;
        }
    }
}
