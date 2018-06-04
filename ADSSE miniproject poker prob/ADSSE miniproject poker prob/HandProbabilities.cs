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
        bool aceInStraight, pair, twoPair, threeOfAKind, fourOfAKind = false;
        float probability;
        int pairIndex, roaylFlushCard;

        public void ResetHandCombinations()
        {
            pair = false;
            twoPair = false;
            threeOfAKind = false;
            fourOfAKind = false;
            aceInStraight = false;
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
                                pairIndex = currentCards.IndexOf(c);
                                probability = 1;
                            }
                            else
                            {
                                probability = ((deck.TypeOfCardLeft(GameDeck, c.rank) + (deck.TypeOfCardLeft(GameDeck, d.rank))) / (deck.CardsLeft(GameDeck))) + ((((deck.CardsLeft(GameDeck) - (deck.TypeOfCardLeft(GameDeck,c.rank) + deck.TypeOfCardLeft(GameDeck, d.rank))) / deck.CardsLeft(GameDeck)) * (3f / (deck.CardsLeft(GameDeck)-1)))*3);
                            }
                        }
                    }
                }
            }

            if (currentCards.Count == 5)
            {
                //probability for a pair if you have five cards in hand.
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                pairIndex = currentCards.IndexOf(c);
                                probability = 1;
                            }
                            else
                            {
                                probability = ((((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank))) +
                                                ((deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) +
                                                ((deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))) +
                                                ((deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))) +
                                                ((deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)))) / 
                                                (deck.CardsLeft(GameDeck))) + (((deck.CardsLeft(GameDeck)-15) / 
                                                 deck.CardsLeft(GameDeck))*(3/(deck.CardsLeft(GameDeck)-1)));
                            }
                        }
                    }
                }
            }

            if (currentCards.Count == 6)
            {
                //probability for a pair if you have six cards in hand.
                foreach (BuildDeck.Card c in currentCards){
                    foreach (BuildDeck.Card d in currentCards){
                        if (c != d){
                            if (c.rank == d.rank){
                                pairIndex = currentCards.IndexOf(c);
                                pair = true;
                                probability = 1;
                            }
                            else{
                                probability = (float)(((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)))
                                                   + ((deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[2].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[3].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[4].rank))) +
                                                     ((deck.TypeOfCardLeft(GameDeck, currentCards[5].rank)))) 
                                                     / (float)(deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }
            }

            if (currentCards.Count == 7)
            {
                //probability for a pair if you have seven cards in hand.
                foreach (BuildDeck.Card c in currentCards)
                {
                    foreach (BuildDeck.Card d in currentCards)
                    {
                        if (c != d)
                        {
                            if (c.rank == d.rank)
                            {
                                pair = true;
                                pairIndex = currentCards.IndexOf(c);
                                probability = 1;
                            }
                            else
                            {
                                probability = 0;
                            }
                        }
                    }
                }
            }
            if (pair) probability = 1f;
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

            if (currentCards.Count == 2) {
                for (int i = 0; i < currentCards.Count - 1; i++) {
                    for (int j = 1; j < currentCards.Count; j++) {
                        if (currentCards[i].rank == currentCards[j].rank) {
                            probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[i].rank)) / (deck.CardsLeft(GameDeck)))+(48f/deck.CardsLeft(GameDeck)*(3f/(deck.CardsLeft(GameDeck)-1))*(2f/(deck.CardsLeft(GameDeck)-2))*3);
                        }
                        else {
                            probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) + (deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) / (deck.CardsLeft(GameDeck)) *
                                          ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1))) + (48f / deck.CardsLeft(GameDeck) * (3f /( deck.CardsLeft(GameDeck) - 1)) * (2f /( deck.CardsLeft(GameDeck) - 2)) * 3);

                        }
                    }
                }
            }
            if (currentCards.Count == 5) {

                if (pair == true){
                    probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank)) /
                        (deck.CardsLeft(GameDeck))) + ((9 / deck.CardsLeft(GameDeck)) * 
                        (2 / (deck.CardsLeft(GameDeck) - 1))));
                }
                if (twoPair == true){
                    probability = (4f / deck.CardsLeft(GameDeck)) + (3f / deck.CardsLeft(GameDeck))
                        * (2f / (deck.CardsLeft(GameDeck) - 1));
                }
                if(!pair && !twoPair){
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)) / deck.CardsLeft(GameDeck))
                        * (2 / (deck.CardsLeft(GameDeck) - 1));
                }                

                if (((currentCards[0].rank == currentCards[1].rank) && 
                    (currentCards[0].rank == currentCards[2].rank)) || 
                    ((currentCards[1].rank == currentCards[2].rank) && 
                    (currentCards[1].rank == currentCards[3].rank)) || 
                    ((currentCards[2].rank == currentCards[3].rank) && 
                    (currentCards[2].rank == currentCards[4].rank))){
                    threeOfAKind = true;
                    probability = 1f;
                }
            }

            if (currentCards.Count == 6) {

                if (pair == true)
                {
                    probability = (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank)) / (deck.CardsLeft(GameDeck));
                }
                if (twoPair == true)
                {
                    probability = (4f / deck.CardsLeft(GameDeck));
                }
               if(!pair && !twoPair)
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

            if (currentCards.Count == 7) {
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
                } else
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
                                probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) / deck.CardsLeft(GameDeck)) * ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1)))+ (48f / deck.CardsLeft(GameDeck) * (3f / (deck.CardsLeft(GameDeck) - 1)) * (2f / (deck.CardsLeft(GameDeck) - 2))*(1f/(deck.CardsLeft(GameDeck)-3) * 3));
                            }
                            else
                            {
                                probability = (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) + (deck.TypeOfCardLeft(GameDeck, currentCards[1].rank))) / (deck.CardsLeft(GameDeck)) *
                                                                          ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1)) * ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) - 1) / (deck.CardsLeft(GameDeck) - 1))) + (48f / deck.CardsLeft(GameDeck) * (3f / (deck.CardsLeft(GameDeck) - 1)) * (2f / (deck.CardsLeft(GameDeck) - 2)) * (1f / (deck.CardsLeft(GameDeck) - 3) * 3));
                            }
                        }
                    }
                }
            }
            if (currentCards.Count == 5)
            {
                if (pair == true)
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) /
                    (deck.CardsLeft(GameDeck)) * ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank - 1)) /
                    (deck.CardsLeft(GameDeck) - 1) / (deck.CardsLeft(GameDeck) - 1)));
                }

                if (threeOfAKind == true)
                {
                    probability = 1f / deck.CardsLeft(GameDeck);
                }
                if(!pair && !threeOfAKind)
                {
                    probability = 0f;
                }
                //check if we have three of a kind with five cards
                //combinations in a sorted list
                // 0 = 1 = 2 = 3
                // 1 = 2 = 3 = 4
                // 2 = 3 = 4 = 0
                // 3 = 4 = 0 = 1
                // 4 = 0 = 1 = 2
                if (((currentCards[0].rank == currentCards[1].rank) && (currentCards[0].rank == currentCards[2].rank)
                && (currentCards[0].rank == currentCards[3].rank)) || ((currentCards[1].rank == currentCards[2].rank)
                && (currentCards[1].rank == currentCards[3].rank) && (currentCards[1].rank == currentCards[4].rank)))
                {
                    fourOfAKind = true;
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
                    fourOfAKind = true;
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
                        fourOfAKind = true;
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

            probability = 0f;

            if (currentCards.Count == 2)
            {
                if (pair)
                {
                    probability = ((deck.CardsLeft(GameDeck) - deck.TypeOfCardLeft(GameDeck, currentCards[0].rank)) / deck.CardsLeft(GameDeck)) * (3f / (deck.CardsLeft(GameDeck) - 1));
                } else
                {
                    probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank)) / (deck.CardsLeft(GameDeck))) * (deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) / (deck.CardsLeft(GameDeck) - 1));
                }
            }

            if (currentCards.Count == 5){
                if (pair){
                        probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) +
                        deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[4].rank) - 
                        (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank) * 2)) /
                        deck.CardsLeft(GameDeck)) + (((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[4].rank) - 
                        (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank))) / 
                        (deck.CardsLeft(GameDeck)) * (3f / (deck.CardsLeft(GameDeck) - 1))));
                }else{
                        probability = ((deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) +
                        deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) +
                        deck.TypeOfCardLeft(GameDeck, currentCards[4].rank)) / (deck.CardsLeft(GameDeck))) + 
                        (deck.TypeOfCardLeft(GameDeck,currentCards[0].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + 
                        deck.TypeOfCardLeft(GameDeck, currentCards[3].rank)) / (deck.CardsLeft(GameDeck) - 1);
                }
                if ((currentCards[0].rank == currentCards[1].rank) && (currentCards[2].rank == currentCards[3].rank) || 
                    (currentCards[0].rank == currentCards[1].rank) && (currentCards[3].rank == currentCards[4].rank) ||
                    (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank)){
                    probability = 1f;
                    twoPair = true;
                }
            }

            if (currentCards.Count == 6)
            {
                if (pair)
                {
                    probability = (deck.TypeOfCardLeft(GameDeck, currentCards[0].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[1].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[2].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[3].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[4].rank) + deck.TypeOfCardLeft(GameDeck, currentCards[5].rank) - (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank) * 2)) / deck.CardsLeft(GameDeck);
                } else
                {
                    probability = 0;
                }
                if ((currentCards[0].rank == currentCards[1].rank) && (currentCards[2].rank == currentCards[3].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[3].rank == currentCards[4].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[4].rank == currentCards[5].rank) ||
                    (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank) || (currentCards[1].rank == currentCards[2].rank) && (currentCards[4].rank == currentCards[5].rank) ||
                    (currentCards[2].rank == currentCards[3].rank) && (currentCards[4].rank == currentCards[5].rank))
                {
                    probability = 1f;
                    twoPair = true;
                }
            }



            if (currentCards.Count == 7)
            {

                /* check for two pairs with seven cards
                 0 == 1 && 2 == 3 || 0 == 1 && 3 == 4 || 0 == 1 && 4 == 5 || 0 == 1 && 5 == 6
                 1 == 2 && 3 == 4 || 1 == 2 && 4 == 5 || 1 == 2 && 5 == 6
                 2 == 3 && 4 == 5 || 2 == 3 && 5 == 6
                 3 == 4 && 5 == 6
                 */
                if ((currentCards[0].rank == currentCards[1].rank) && (currentCards[2].rank == currentCards[3].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[3].rank == currentCards[4].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[4].rank == currentCards[5].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[5].rank == currentCards[6].rank) ||
                    (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank) || (currentCards[1].rank == currentCards[2].rank) && (currentCards[4].rank == currentCards[5].rank) || (currentCards[1].rank == currentCards[2].rank) && (currentCards[5].rank == currentCards[6].rank) ||
                    (currentCards[2].rank == currentCards[3].rank) && (currentCards[4].rank == currentCards[5].rank) || (currentCards[3].rank == currentCards[4].rank) && (currentCards[5].rank == currentCards[6].rank) ||
                    (currentCards[3].rank == currentCards[4].rank) && (currentCards[5].rank == currentCards[6].rank))
                {
                    probability = 1;
                    twoPair = true;
                }
                else
                {
                    probability = 0;
                }
            }

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbabilityOfFullHouse(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0f;

            if (currentCards.Count == 2)
            {
                if (pair) {
                    probability = (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank) / deck.CardsLeft(GameDeck)) + ((((deck.CardsLeft(GameDeck) - 3f) / (deck.CardsLeft(GameDeck) - 1f)) * (3f / (deck.CardsLeft(GameDeck) - 2)))*3);
                }
                else
                    probability = ((((6f / deck.CardsLeft(GameDeck))*(2f/(deck.CardsLeft(GameDeck)-1)))*(3f/ (deck.CardsLeft(GameDeck) - 2))) + ((6f/ (deck.CardsLeft(GameDeck))) * ((3f/ (deck.CardsLeft(GameDeck) - 1))*(2f/(deck.CardsLeft(GameDeck) - 2))))) + (((44f /deck.CardsLeft(GameDeck)) * (3f/(deck.CardsLeft(GameDeck)-1))* (2f / (deck.CardsLeft(GameDeck) - 2)) * (40f / (deck.CardsLeft(GameDeck)-3)) * (3f / (deck.CardsLeft(GameDeck) - 4))) + ((44f/deck.CardsLeft(GameDeck)) * (3f/ (deck.CardsLeft(GameDeck)-1)) * (40f/(deck.CardsLeft(GameDeck)-2))* (3f/ (deck.CardsLeft(GameDeck) - 3))*(2f/ (deck.CardsLeft(GameDeck) - 4))));
            }

            if (currentCards.Count == 5)
            {
                if (pair)
                {
                    probability = (deck.TypeOfCardLeft(GameDeck, currentCards[pairIndex].rank) / deck.CardsLeft(GameDeck)) + ((9f / deck.CardsLeft(GameDeck)) * (2f / (deck.CardsLeft(GameDeck) - 1)));
                }
                if (threeOfAKind) {
                    probability = (6f / deck.CardsLeft(GameDeck)) + ((40f / deck.CardsLeft(GameDeck)) * (3f / (deck.CardsLeft(GameDeck) - 1)));
                }
                if (twoPair)
                {
                    probability = (4f / deck.CardsLeft(GameDeck)) + (3f / deck.CardsLeft(GameDeck)) * (2f / (deck.CardsLeft(GameDeck) - 1));
                }
                if (!pair && !threeOfAKind)
                {
                    probability = 0f;
                }
                if ((currentCards[0].rank==currentCards[1].rank )&& (currentCards[2].rank==currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank) || (currentCards[0].rank == currentCards[1].rank) && (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank))
                    probability = 1f;
            }

            if (currentCards.Count == 6)
            {
                if (pair) {
                    probability = 0f;
                }
                if (twoPair)
                {
                    probability = 4f / deck.CardsLeft(GameDeck);
                }
                if (threeOfAKind) {
                    probability = 9f / deck.CardsLeft(GameDeck);
                }
                if (!twoPair && !threeOfAKind)
                {
                    probability = 0f;
                }
                if ((currentCards[0].rank == currentCards[1].rank) && (currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank)
                    || (currentCards[0].rank == currentCards[1].rank) && (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank)
                     || (currentCards[0].rank == currentCards[1].rank) && (currentCards[1].rank == currentCards[2].rank) && (currentCards[4].rank == currentCards[5].rank)
                      || (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank) && currentCards[4].rank == currentCards[5].rank
                       || (currentCards[0].rank == currentCards[1].rank) && (currentCards[3].rank == currentCards[4].rank) && (currentCards[4].rank == currentCards[5].rank))
                    probability = 1f;
            }

            if (currentCards.Count == 7)
            {
                if ((currentCards[0].rank == currentCards[1].rank) && (currentCards[2].rank == currentCards[3].rank) && (currentCards[2].rank == currentCards[4].rank)
                    || (currentCards[0].rank == currentCards[1].rank) && (currentCards[3].rank == currentCards[4].rank) && (currentCards[4].rank == currentCards[5].rank)
                     || (currentCards[0].rank == currentCards[1].rank) && (currentCards[4].rank == currentCards[5].rank) && (currentCards[5].rank == currentCards[6].rank)
                      || (currentCards[1].rank == currentCards[2].rank) && (currentCards[3].rank == currentCards[4].rank) && currentCards[4].rank == currentCards[5].rank
                       || (currentCards[1].rank == currentCards[2].rank) && (currentCards[4].rank == currentCards[5].rank) && (currentCards[5].rank == currentCards[6].rank)
                       || (currentCards[2].rank == currentCards[3].rank) && (currentCards[4].rank == currentCards[5].rank) && (currentCards[5].rank == currentCards[6].rank))
                {
                    probability = 1f;
                }
                else
                    probability = 0f;
            }

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbabilityOfStraight(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0f;
            if (currentCards.Count == 2) probability = 0.00001441f;

            if (currentCards.Count == 5)
            {
                int straightCounter;

                if (threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                    currentCards.Remove(currentCards[pairIndex-1]);
                }

                if (pair && !threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                }

                if (twoPair){
                    for(int i = 0; i < currentCards.Count; i++)
                    {
                        for (int j = 1; j < currentCards.Count; j++)
                        {
                            if (i != j)
                            {
                                if (currentCards[i].rank == currentCards[j].rank)
                                {
                                    pairIndex = i;
                                    currentCards.Remove(currentCards[pairIndex]);
                                }
                            }
                        }
                    }
                }

                //if three cards for a straight
                straightCounter = 1;
                for(int i = 1; i < currentCards.Count ;i++)
                {
                    if(currentCards[0].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if(straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 4;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * 
                                ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 4;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 4;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                //if four cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4)
                    {
                        if (currentCards[i].rank == 0) aceInStraight = true;

                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[0].rank == currentCards[1].rank + 1) && (currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                if (aceInStraight)
                                {
                                    straightCounter = straightCounter * 4;
                                }
                                else
                                {
                                    straightCounter = straightCounter * 8;
                                }
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 4;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        if (currentCards[i].rank == 0) aceInStraight = true;

                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                if (aceInStraight)
                                {
                                    straightCounter = straightCounter * 4;
                                }
                                else
                                {
                                    straightCounter = straightCounter * 8;
                                }
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 4;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        if (currentCards[i].rank == 0) aceInStraight = true;

                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1) && (currentCards[4].rank == currentCards[5].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                if (aceInStraight)
                                {
                                    straightCounter = straightCounter * 4;
                                }
                                else
                                {
                                    straightCounter = straightCounter * 8;
                                }
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 4;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                //if five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

            }

            if (currentCards.Count == 6)
            {
                int straightCounter;

                if (threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                    currentCards.Remove(currentCards[pairIndex - 1]);
                }

                if (pair && !threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                }
                if (twoPair)
                {
                    for (int i = 0; i < currentCards.Count; i++)
                    {
                        for (int j = 1; j < currentCards.Count; j++)
                        {
                            if (i != j)
                            {
                                if (currentCards[i].rank == currentCards[j].rank)
                                {
                                    pairIndex = i;
                                    currentCards.Remove(currentCards[pairIndex]);
                                }
                            }
                        }
                    }
                }


                //if three cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                //if four cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].rank - currentCards[i].rank >= 0)
                    {
                        if (currentCards[i].rank == 0) aceInStraight = true;

                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[0].rank == currentCards[1].rank + 1) && (currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank +1))
                            {
                                straightCounter = 5 - straightCounter;
                                if (aceInStraight)
                                {
                                    straightCounter = straightCounter * 4;
                                }
                                else
                                {
                                    straightCounter = straightCounter * 8;
                                }
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 4;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        if (currentCards[i].rank == 0) aceInStraight = true;

                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1) /*&& (currentCards[4].rank == currentCards[5].rank + 1)*/)
                            {
                                straightCounter = 5 - straightCounter;
                                if (aceInStraight)
                                {
                                    straightCounter = straightCounter * 4;
                                }
                                else
                                {
                                    straightCounter = straightCounter * 8;
                                }
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 4;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 4; // four different suits
                            probability = (straightCounter / deck.CardsLeft(GameDeck));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 4; // four different suits
                            probability = (straightCounter / deck.CardsLeft(GameDeck));
                        }
                    }
                }
                //for five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].rank - currentCards[i].rank >= 0)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }

            if(currentCards.Count == 7)
            {
                int straightCounter;

                if (threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                    currentCards.Remove(currentCards[pairIndex - 1]);
                }

                if (pair && !threeOfAKind)
                {
                    currentCards.Remove(currentCards[pairIndex]);
                }
                if (twoPair)
                {
                    for (int i = 0; i < currentCards.Count; i++)
                    {
                        for (int j = 1; j < currentCards.Count; j++)
                        {
                            if (i != j)
                            {
                                if (currentCards[i].rank == currentCards[j].rank)
                                {
                                    pairIndex = i;
                                    currentCards.Remove(currentCards[pairIndex]);
                                }
                            }
                        }
                    }
                }

                //for five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].rank - currentCards[i].rank >= 0)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }


            if (fourOfAKind) probability = 0;

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }
 
        public double ProbabilityOfFlush(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            currentCards = currentCards.OrderBy(o => o.suit).ToList();
            currentCards.Reverse();

            probability = 0f;

            if(currentCards.Count == 2)
            {
                if(currentCards[0].suit == currentCards[1].suit)
                {
                    probability = (((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit)) / deck.CardsLeft(GameDeck)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) - 1) / (deck.CardsLeft(GameDeck) - 1)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) - 2) / (deck.CardsLeft(GameDeck) - 2))) + 
                        ((13f / 50f) * (12f / 49f) * (11f / 48f) * (10f / 47f) * (9f / 46f));
                }else
                {
                    probability = (((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) / deck.CardsLeft(GameDeck)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) - 1) / (deck.CardsLeft(GameDeck) - 1)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) - 2) / (deck.CardsLeft(GameDeck) - 2)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[0].suit) - 3) / (deck.CardsLeft(GameDeck) - 3))) +
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[1].suit) / deck.CardsLeft(GameDeck)) * 
                        ((deck.TypeOfSuitLeft(GameDeck, currentCards[1].suit) - 1) / (deck.CardsLeft(GameDeck) - 1))
                        * ((deck.TypeOfSuitLeft(GameDeck, currentCards[1].suit) - 2) / (deck.CardsLeft(GameDeck) - 2))
                        * ((deck.TypeOfSuitLeft(GameDeck, currentCards[1].suit) - 3) / (deck.CardsLeft(GameDeck) - 3)))
                        + (13f / deck.CardsLeft(GameDeck)) * (12f / (deck.CardsLeft(GameDeck) - 1f)) * 
                        (11f / (deck.CardsLeft(GameDeck) - 2f)) * (10f / (deck.CardsLeft(GameDeck) - 3f)) * 
                        (9f / (deck.CardsLeft(GameDeck) - 4f)) + (13f / deck.CardsLeft(GameDeck)) * 
                        (12f / (deck.CardsLeft(GameDeck) - 1f)) * (11f / (deck.CardsLeft(GameDeck) - 2f)) *
                        (10f / (deck.CardsLeft(GameDeck) - 3f)) * (9f / (deck.CardsLeft(GameDeck) - 4f))) + 
                        ((13f / 50f) * (12f / 49f) * (11f / 48f) * (10f / 47f) * (9f / 46f));
                }
            }

            if(currentCards.Count == 5)
            {
                //0,1,2
                //1,2,3
                //2,3,4
                if((currentCards[0].suit == currentCards[1].suit) && (currentCards[0].suit == currentCards[2].suit) || (currentCards[1].suit == currentCards[2].suit) && (currentCards[1].suit == currentCards[3].suit) || (currentCards[2].suit == currentCards[3].suit) && (currentCards[2].suit == currentCards[4].suit))
                {
                    probability = ((deck.TypeOfSuitLeft(GameDeck, currentCards[2].suit)) / deck.CardsLeft(GameDeck)) * (((deck.TypeOfSuitLeft(GameDeck, currentCards[2].suit)) - 1) / (deck.CardsLeft(GameDeck) - 1));
                }
                else
                {
                    probability = 0f;
                }
            }

            if(currentCards.Count == 6)
            {
                //0,1,2,3
                //1,2,3,4
                //2,3,4,5
                if ((currentCards[0].suit == currentCards[1].suit) && (currentCards[0].suit == currentCards[2].suit) && (currentCards[0].suit == currentCards[3].suit) || (currentCards[1].suit == currentCards[2].suit) && (currentCards[1].suit == currentCards[3].suit) && (currentCards[1].suit == currentCards[4].suit) || (currentCards[2].suit == currentCards[3].suit) && (currentCards[2].suit == currentCards[4].suit) && (currentCards[2].suit == currentCards[5].suit))
                {
                    probability = (deck.TypeOfSuitLeft(GameDeck, currentCards[3].suit)) / deck.CardsLeft(GameDeck);
                }
                else
                {
                    probability = 0f;
                }
            }

            if(currentCards.Count == 7)
            {
                //0,1,2,3,4
                //1,2,3,4,5
                //2,3,4,5,6
                if ((currentCards[0].suit == currentCards[1].suit) && (currentCards[0].suit == currentCards[2].suit) && (currentCards[0].suit == currentCards[3].suit) && (currentCards[0].suit == currentCards[4].suit) || (currentCards[1].suit == currentCards[2].suit) && (currentCards[1].suit == currentCards[3].suit) && (currentCards[1].suit == currentCards[4].suit) && (currentCards[1].suit == currentCards[5].suit) || (currentCards[2].suit == currentCards[3].suit) && (currentCards[2].suit == currentCards[4].suit) && (currentCards[2].suit == currentCards[5].suit) && (currentCards[2].suit == currentCards[6].suit))
                {
                    probability = 1f;
                }
                else
                {
                    probability = 0f;
                }
            }

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbabilityOfStraightFlush(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            //sort the list in decending order by rank
            currentCards = currentCards.OrderBy(o => o.rank).ToList();
            currentCards.Reverse();

            probability = 0f;
            if (currentCards.Count == 2) probability = 0f;

            if (currentCards.Count == 5)
            {
                int straightCounter;

                //if three cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit) 
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            straightCounter = 5 - straightCounter;
                            probability = (straightCounter / deck.CardsLeft(GameDeck)) * ((straightCounter / 2) / (deck.CardsLeft(GameDeck) - 1));
                        }
                    }
                }

                //if four cards for a straight ot of a five card hand
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++){
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && 
                        currentCards[0].suit == currentCards[i].suit){
                        straightCounter++;
                        if (straightCounter == 4){
                            if ((currentCards[0].rank == currentCards[1].rank + 1) && 
                                (currentCards[1].rank == currentCards[2].rank + 1) && 
                                (currentCards[2].rank == currentCards[3].rank + 1)){
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 2;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else{
                                straightCounter = 5 - straightCounter;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 2;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1) && (currentCards[4].rank == currentCards[5].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 2;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                //if five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

            }

            if (currentCards.Count == 6)
            {
                int straightCounter;

                //if three cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 3)
                        {
                            probability = 0;
                        }
                    }
                }

                //if four cards for a straight
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[0].rank == currentCards[1].rank + 1) && (currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 2;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            if ((currentCards[1].rank == currentCards[2].rank + 1) && (currentCards[2].rank == currentCards[3].rank + 1) && (currentCards[3].rank == currentCards[4].rank + 1) && (currentCards[4].rank == currentCards[5].rank + 1))
                            {
                                straightCounter = 5 - straightCounter;
                                straightCounter = straightCounter * 2;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                            else
                            {
                                straightCounter = 5 - straightCounter;
                                probability = (straightCounter / deck.CardsLeft(GameDeck));
                            }
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 2;
                            probability = (straightCounter / deck.CardsLeft(GameDeck));
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4 && currentCards[3].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 4)
                        {
                            straightCounter = 5 - straightCounter;
                            straightCounter = straightCounter * 2;
                            probability = (straightCounter / deck.CardsLeft(GameDeck));
                        }
                    }
                }
                //for five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4 && currentCards[3].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }

            if (currentCards.Count == 7)
            {
                int straightCounter;

                //for five cards in sequence
                straightCounter = 1;
                for (int i = 1; i < currentCards.Count; i++)
                {
                    if (currentCards[0].rank - currentCards[i].rank <= 4 && currentCards[0].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 2; i < currentCards.Count; i++)
                {
                    if (currentCards[1].rank - currentCards[i].rank <= 4 && currentCards[1].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 3; i < currentCards.Count; i++)
                {
                    if (currentCards[2].rank - currentCards[i].rank <= 4 && currentCards[2].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }

                straightCounter = 1;
                for (int i = 4; i < currentCards.Count; i++)
                {
                    if (currentCards[3].rank - currentCards[i].rank <= 4 && currentCards[3].suit == currentCards[i].suit)
                    {
                        straightCounter++;
                        if (straightCounter == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }


            if (fourOfAKind) probability = 0;

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }

        public double ProbailityOfRoyalFlush(List<BuildDeck.Card> currentCards, List<BuildDeck.Card> GameDeck)
        {
            probability = 0;

            if (currentCards.Count == 2) { probability = 0f; }

            if(currentCards.Count == 5)
            {
                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || 
                        (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if(roaylFlushCard == 3)
                        {
                            roaylFlushCard =  5 - roaylFlushCard;
                            probability = ((roaylFlushCard / deck.CardsLeft(GameDeck)) * ((roaylFlushCard / 2) / 
                                (deck.CardsLeft(GameDeck) - 1)));
                        }else
                        {
                            probability = 0f;
                        }
                    }
                }

                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 4)
                        {
                            roaylFlushCard = 5 - roaylFlushCard;
                            probability = roaylFlushCard / deck.CardsLeft(GameDeck);
                        }
                    }
                }

                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 5)
                        { 
                            probability = 1f;
                        }
                    }
                }
            }

            if (currentCards.Count == 6)
            {
                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 3)
                        {
                            roaylFlushCard = 5 - roaylFlushCard;
                            probability = ((roaylFlushCard / deck.CardsLeft(GameDeck)) * ((roaylFlushCard / 2) / (deck.CardsLeft(GameDeck) - 1)));
                        }
                        else
                        {
                            probability = 0f;
                        }
                    }
                }
                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 4)
                        {
                            roaylFlushCard = 5 - roaylFlushCard;
                            probability = roaylFlushCard / deck.CardsLeft(GameDeck);
                        }
                        else
                        {
                            probability = 0f;
                        }
                    }
                }

                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }

            if (currentCards.Count == 7)
            {
                roaylFlushCard = 0;
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if ((12 - currentCards[i].rank <= 3 && currentCards[0].suit == currentCards[i].suit) || 
                        (currentCards[i].rank == 0 && currentCards[0].suit == currentCards[i].suit))
                    {
                        roaylFlushCard++;
                        if (roaylFlushCard == 5)
                        {
                            probability = 1f;
                        }
                    }
                }
            }

            probability = probability * 100f;
            double prob = System.Math.Round(probability, 2);
            return prob;
        }
    }

}
