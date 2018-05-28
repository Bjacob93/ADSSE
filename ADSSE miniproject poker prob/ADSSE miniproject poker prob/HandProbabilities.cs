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
        bool pair, threeOfAKind = false;
        float probability;

        //calculates the probability of getting a pair
        public double ProbabilityOfPair(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0;

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
                                probability = 1;
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
                            probability = 1;
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
            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbabilityOfThreeOfaKind(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0;

            if (currentCards.Count == 2){
                for(int i = 0; i < currentCards.Count - 1; i++){
                    for(int j = 1; j < currentCards.Count; j++){
                        if(currentCards[i].rank == currentCards[j].rank){
                            probability = (float)(deck.TypeOfCardLeft(GameDeck, currentCards[i].rank)) / (float)(deck.CardsLeft(GameDeck));
                        }
                        else{
                            probability = (float)(((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) + (deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) / (float)(deck.CardsLeft(GameDeck)) *
                                          (float)((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (float)(deck.CardsLeft(GameDeck) - 1)));

                        }
                    }
                }
            }
            if(currentCards.Count == 5){

                if (pair)
                {
                    probability = 2f / (float)(deck.CardsLeft(GameDeck));
                }else
                {
                    probability = ((float)((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)) / (float)deck.CardsLeft(GameDeck)) *
                        (float)(2 / deck.CardsLeft(GameDeck) - 1));
                }

                //check if we have three of a kind with five cards
                //combinations in a sorted list
                // 1,2,3
                // 2,3,4
                // 3,4,5
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank))
                 || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank))
                 || ((currentCards[2].rank == currentCards[4].rank) && (currentCards[2].rank == currentCards[5].rank)))
                {
                    threeOfAKind = true;
                    probability = 1f;
                }
            }

            if(currentCards.Count == 6){

                //check if we have three of a kind with six cards
                //combinations in a sorted list
                // 1,2,3
                // 2,3,4
                // 3,4,5
                // 4,5,6
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank))
                 || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank))
                 || ((currentCards[2].rank == currentCards[4].rank) && (currentCards[2].rank == currentCards[5].rank))
                 || ((currentCards[4].rank == currentCards[5].rank) && (currentCards[1].rank == currentCards[6].rank)))
                    {
                    threeOfAKind = true;
                    probability = 1f;
                    }
            }


            if(currentCards.Count == 7){

                //check if we have three of a kind with seven cards
                //combinations in a sorted list
                // 1,2,3
                // 2,3,4
                // 3,4,5
                // 4,5,6
                // 5,6,7
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank))
                 || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank))
                 || ((currentCards[2].rank == currentCards[4].rank) && (currentCards[2].rank == currentCards[5].rank))
                 || ((currentCards[4].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank))
                 || ((currentCards[5].rank == currentCards[6].rank) && (currentCards[5].rank == currentCards[7].rank)))
                {
                    probability = 1f;
                }else
                {
                    probability = 0;
                }
            }
            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public float ProbabilityOfFourOfaKind(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck) {
            if (currentCards.Count == 2)
            {
                for (int i = 0; i < currentCards.Count - 1; i++)
                {
                    for (int j = 1; j < currentCards.Count; j++)
                    {
                        if (currentCards[i].rank == currentCards[j].rank)
                        {
                            probability = (float)(deck.TypeOfCardLeft(GameDeck, currentCards[i].rank)) / (float)(deck.CardsLeft(GameDeck));
                        }
                        else
                        {

                        }
                    }
                }
            }

            return probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }
    }
}
