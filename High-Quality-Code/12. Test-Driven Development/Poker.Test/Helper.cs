using System;
using System.Collections.Generic;
using System.Linq;
using Poker;

namespace Poker.Test
{
    public static class Helper
    {
        public static List<Card> GeneratePockerHand(int numberOfCards)
        {
            int cardCounter = 0;
            List<Card> cards = new List<Card>();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
                {
                    cardCounter++;
                    Card newCard = new Card(face, suit);
                    cards.Add(newCard);
                    if (cardCounter == numberOfCards)
                    {
                        break;
                    }
                }

                if (cardCounter == numberOfCards)
                {
                    break;
                }
            }
            return new List<Card>(cards);
        }

        public static IList<CardSuit> GetAllSuits()
        {
            return new List<CardSuit>
            {
               CardSuit.Clubs,
               CardSuit.Diamonds,
               CardSuit.Hearts,
               CardSuit.Spades
            };
        }

    }
}
