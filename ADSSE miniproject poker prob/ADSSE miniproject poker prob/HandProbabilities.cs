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

        //calculates the probability of getting a pair
        public float ProbabilityOfPair(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();



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
                                probability = (float)(deck.TypeOfCardLeft(GameDeck, c.rank) + (deck.TypeOfCardLeft(GameDeck, d.rank))) / (float)(deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }
            }

            if(currentCards.Count == 5)
            {
                for(int i = 0; i < currentCards.Count-1; i++){
                    for(int j = 1; j < currentCards.Count; j++){
                            if(currentCards[i].rank == currentCards[j].rank){
                                pair = true;
                                probability = 100;
                            }
                        else {
                            probability = (float)(((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)))
                                               + ((deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)))) / (float)(deck.CardsLeft(GameDeck));
                            }
                    }
                }
            }
            if(currentCards.Count == 6){
                for (int i = 0; i < currentCards.Count - 1; i++){
                    for (int j = 1; j < currentCards.Count; j++){
                        if (currentCards[i].rank == currentCards[j].rank){
                            pair = true;
                            probability = 100;
                        }
                        else{
                            probability = (float)(((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)))
                                               + ((deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[4].rank))) +
                                                 ((deck.TypeOfCardLeft(GameDeck, currentCards[5].rank)))) / (float)(deck.CardsLeft(GameDeck));
                        }
                    }
                }

            }

            return probability * 100f;
        }

        public float ProbabilityOfThreeOfaKind(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            if(currentCards.Count == 2){
                for(int i = 0; i < currentCards.Count - 1; i++){
                    for(int j = 1; j < currentCards.Count; j++){
                        if(currentCards[i].rank == currentCards[j].rank){
                            probability = (float)(deck.TypeOfCardLeft(GameDeck, currentCards[i].rank)) / (float)(deck.CardsLeft(GameDeck));
                        }
                        else{

                        }
                    }
                }
            }
            else if(currentCards.Count == 5){

            }
            else if(currentCards.Count == 6){

            }


            return probability * 100f;
        }
    }
}
