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
        BuildDeck deck = new BuildDeck();
        bool pair = false;

        public float[] Probabilities(List<BuildDeck.Card> currentCards)
        {
            float[] probabilities = new float[9];
            if (currentCards.Count == 2)
            {
                //probability for a pair if you have two cards in hand.
                foreach (BuildDeck.Card c in currentCards){
                    foreach (BuildDeck.Card d in currentCards){
                        if (c != d){
                            if (c.rank == d.rank){
                                pair = true;
                                probabilities[0] = 100;
                            }
                            else{
                                probabilities[0] = (((deck.TypeOfCardLeft(GameDeck, c.rank) + (deck.TypeOfCardLeft(GameDeck, d.rank))) / deck.CardsLeft(GameDeck)) * 100);
                            }
                        }
                    }
                }
                //probability of three of a kind
                foreach(BuildDeck.Card c in currentCards){
                    foreach(BuildDeck.Card d in currentCards){if(c != d){ 
                            if(c != d){
                                //if i already have a pair
                                if (c.rank == d.rank){
                                    probabilities[2] = ((deck.TypeOfCardLeft(GameDeck, c.rank)) / deck.CardsLeft(GameDeck)) * 100;
                                }else
                                {
                                }
                            }
                            
                        }
                    }
                }
            }
            return probabilities;
        }
    }
}
