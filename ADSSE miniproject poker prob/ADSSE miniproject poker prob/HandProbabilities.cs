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
        bool pair, threeOfAKind, fourofkind = false;
        float probability;

        public void ResetHandCombinations()
        {
            pair = false;
            threeOfAKind = false;
        }


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
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                probability = 1;
                            }
                            else
                            {
                                probability = (float)(deck.TypeOfCardLeft(GameDeck, c.rank) + (deck.TypeOfCardLeft(GameDeck, d.rank))) / (float)(deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }
            }

            if (currentCards.Count == 5)
            {
                //probability for a pair if you have two cards in hand.
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                probability = 1;
                            }
                            else
                            {
                                probability = (float)(((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)))
                                                   + ((deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)))) / (float)(deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }
            }

            if (currentCards.Count == 6)
            {
                //probability for a pair if you have two cards in hand.
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                probability = 1;
                            }
                            else
                            {
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

                if (pair == true)
                {
                    probability = 2f / (float)(deck.CardsLeft(GameDeck));
                }else
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)) / deck.CardsLeft(GameDeck))
                        * (2 / (deck.CardsLeft(GameDeck) - 1));
                }

                //check if we have three of a kind with five cards
                //combinations in a sorted list
                // 0 = 1 = 2
                // 1 = 2 = 3
                // 2 = 3 = 4
                if(((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank)) || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank)) || ((currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank)))
                {
                    threeOfAKind = true;
                    probability = 1f;
                }

            }

            if(currentCards.Count == 6){

                if (pair == true)
                {
                    probability = 2f / (float)(deck.CardsLeft(GameDeck));
                }
                else
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[4].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[5].rank)) / deck.CardsLeft(GameDeck))
                        * (2 / (deck.CardsLeft(GameDeck) - 1));
                }
                //check if we have three of a kind with six cards
                //combinations in a sorted list
                // 0 = 1 = 2
                // 1 = 2 = 3
                // 2 = 3 = 4
                // 3 = 4 = 5
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank))
                 || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank))
                 || ((currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank))
                 || ((currentCards[3].rank == currentCards[4].rank) && (currentCards[3].rank == currentCards[5].rank)))
                    {
                    threeOfAKind = true;
                    probability = 1f;
                    }

                if (!pair) probability = 0f;
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
                 || ((currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank))
                 || ((currentCards[3].rank == currentCards[4].rank) && (currentCards[3].rank == currentCards[5].rank))
                 || ((currentCards[4].rank == currentCards[5].rank) && (currentCards[4].rank == currentCards[6].rank)))
                {
                    threeOfAKind = true;
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

        public double ProbabilityOfFourOfaKind(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck) {

            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0;

            if (currentCards.Count == 2)
            {
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) / deck.CardsLeft(GameDeck)) * ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1));
                            }
                            else
                            {
                                probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) + (deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) / (deck.CardsLeft(GameDeck)) *
                                                                          ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1))*((deck.TypeOfCardLeft(GameDeck,currentCards[0].rank)-1) / (deck.CardsLeft(GameDeck) - 1)));
                            }
                        }
                    }
                }
            }
            if (currentCards.Count == 5)
            {
                if (pair == true)
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank))/(deck.CardsLeft(GameDeck))* ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank-1)) / (deck.CardsLeft(GameDeck)-1) / (deck.CardsLeft(GameDeck)-1)));
                }
                if (threeOfAKind == true)
                {
                    probability = 1f / deck.CardsLeft(GameDeck);
                }
                else
                {
                    probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) + (deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))+ (deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))+ (deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))+ (deck.TypeOfCardLeft(GameDeck, currentCards[4].rank))) / (deck.CardsLeft(GameDeck))) *
                                                                                           ( 2 / (deck.CardsLeft(GameDeck) - 1 ))* (1 / (deck.CardsLeft(GameDeck)-1));
                }
                //check if we have three of a kind with five cards
                //combinations in a sorted list
                // 0 = 1 = 2 = 3
                // 1 = 2 = 3 = 4
                // 2 = 3 = 4 = 0
                // 3 = 4 = 0 = 1
                // 4 = 0 = 1 = 2
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank) && (currentCards[0].rank == currentCards[3].rank))
                || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank) && (currentCards[1].rank == currentCards[4].rank)))
                {
                    fourofkind = true;
                    probability = 1f;
                }

            }
            if (currentCards.Count == 6)
            {
                if (pair == true)
                {
                    probability = 0f;
                }
                if (threeOfAKind == true)
                {
                    probability = 1f / deck.CardsLeft(GameDeck);
                }
                else
                {
                    probability = 0f;
                }

                //check if we have three of a kind with six cards
                //combinations in a sorted list
                // 0 = 1 = 2 = 3 
                // 1 = 2 = 3 = 4 = 5
                // 2 = 3 = 4 = 5 = 0
                // 3 = 4 = 5 = 0 = 1
                // 4 = 5 = 0 = 1 = 2
                // 5 = 0 = 1 = 2 = 3

                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank) && (currentCards[0].rank == currentCards[3].rank))
                || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank) && (currentCards[1].rank == currentCards[4].rank))
                || ((currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank) && (currentCards[2].rank == currentCards[5].rank)))
                {
                    fourofkind = true;
                    probability = 1f;
                }
                if (currentCards.Count == 7)
                {
                   if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank) && (currentCards[0].rank == currentCards[3].rank))
               || ((currentCards[1].rank == currentCards[2].rank) && (currentCards[1].rank == currentCards[3].rank) && (currentCards[1].rank == currentCards[4].rank))
               || ((currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank) && (currentCards[2].rank == currentCards[5].rank))
               || ((currentCards[3].rank == currentCards[4].rank) && (currentCards[3].rank == currentCards[5].rank) && (currentCards[3].rank == currentCards[6].rank))
               || ((currentCards[4].rank == currentCards[5].rank) && (currentCards[4].rank == currentCards[6].rank) && (currentCards[4].rank == currentCards[7].rank)))
                    {
                        fourofkind = true;
                        probability = 1f;
                    }
                }
            }
            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbabilityOfTwoPair(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            if (currentCards.Count == 2)
            {
                if (pair)
                {
                    probability = ((deck.CardsLeft(GameDeck) - deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) / deck.CardsLeft(GameDeck)) * (3f / (deck.CardsLeft(GameDeck) - 1));
                }else
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank)) / (deck.CardsLeft(GameDeck))) * (deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) / (deck.CardsLeft(GameDeck) - 1));
                }
            }

            if (currentCards.Count == 5)
            {
                if (pair)
                {

                }else
                {
                    probability = (deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)) / (deck.CardsLeft(GameDeck));
                }
            }

            if (currentCards.Count == 6)
            {

            }

            if (currentCards.Count == 7)
            {

            }

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }
    }
}
