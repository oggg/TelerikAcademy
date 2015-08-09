using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        const int CorrectNumberOfCardsInHand = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Trying to check a null hand");
            }

            IList<ICard> cards = hand.Cards;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i] == null)
                {
                    throw new NullReferenceException("There is a null card in hand");
                }
                if (i < cards.Count - 1)
                {
                    if (cards[i].Face == cards[i + 1].Face && cards[i].Suit == cards[i + 1].Suit)
                    {
                        return false; // throw new ArgumentException("Cannot have one and the same card in a hand");
                    }
                }
            }

            if (cards.Count != CorrectNumberOfCardsInHand)
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var cards = hand.Cards;
            var sortedCards = cards.OrderBy(card => card.Face).ToList();
            int equalCardFaces = 1;
            for (int i = 1; i < sortedCards.Count; i++)
            {
                if (sortedCards[i].Face == sortedCards[i - 1].Face)
                {
                    equalCardFaces++;
                    if (equalCardFaces == 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var cards = hand.Cards;
            var sortedCards = cards.OrderBy(card => card.Face).ToList();

            for (int i = 1; i < sortedCards.Count; i++)
            {
                if (sortedCards[i].Suit != sortedCards[i - 1].Suit)
                {
                    return false;
                }

                if ((int)sortedCards[i].Face == (int)(sortedCards[i - 1].Face + 1))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
