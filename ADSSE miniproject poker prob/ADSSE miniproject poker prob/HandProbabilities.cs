using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_miniproject_poker_prob
{
    class HandProbabilities
    {
        BuildDeck deck = new BuildDeck();
        bool pair = false;
        float probability = 0;

        public float ProbabilityOfPair(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {

            float probabilityOfFirstCard = 0;
            float probabilityOfSecondCard = 0;
            if (currentCards.Count == 2)
            {
                //probability for a pair if you have two cards in hand.
                foreach (BuildDeck.Card c in currentCards){
                    foreach (BuildDeck.Card d in currentCards){
                        if (c != d){
                            if (c.rank == d.rank){
                                pair = true;
                                probability = 1;
                            }
                            else{
                                probabilityOfFirstCard = (deck.TypeOfCardLeft(GameDeck, c.rank) / deck.CardsLeft(GameDeck));
                                probabilityOfSecondCard = (deck.TypeOfCardLeft(GameDeck, d.rank) / deck.CardsLeft(GameDeck));
                                probability = (float)(deck.TypeOfCardLeft(GameDeck, c.rank) + (deck.TypeOfCardLeft(GameDeck, d.rank))) / (float)(deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }
            }

            if(currentCards.Count == 5 || currentCards.Count == 7)
            {
                foreach(BuildDeck.Card c in currentCards){
                    foreach(BuildDeck.Card d in currentCards){
                        if(c != d){
                            if(c.rank == d.rank){
                                pair = true;
                                probability = 100;
                            }else
                            {
                                probability = probability * ((deck.TypeOfCardLeft(GameDeck, c.rank) / deck.CardsLeft(GameDeck)));
                            }
                        }
                    }
                }
            }
            return probability * 100f;
        }

        public float ProbabilityOfThreeOfaKind(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            foreach (BuildDeck.Card c in currentCards)
            {
                foreach(BuildDeck.Card d in currentCards)
{
                    if(currentCards.Count == 2)
                    {
                        if(c != d)
                        {
                            if(c.rank == d.rank)
                            {
                                probability = ((float)(deck.TypeOfCardLeft(GameDeck, c.rank)) / (float)deck.CardsLeft(GameDeck));
                            }else
                            {
                            }
                        }
                    }
                }
            }
            return probability * 100f;
        }
    }
}
