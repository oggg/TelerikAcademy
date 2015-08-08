using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace Poker.Test
{
    [TestClass]
    public class UnitTest1
    {
        const int CorrectNumberOfCardsInHand = 5;
        const int InCorrectNumberOfCardsInHand = 6;

        [TestMethod]
        public void TestCardPrinting()
        {
            Card diamondQueen = new Card(CardFace.Queen, CardSuit.Diamonds);
            Assert.AreEqual("Queen Diamonds", diamondQueen.ToString());
        }

        [TestMethod]
        public void TestHandPrinting()
        {
            IList<ICard> cards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand));
            Hand newHand = new Hand(cards);

            Assert.AreEqual(string.Join(", ", cards), newHand.ToString());
        }

        [TestMethod]
        public void TestCorrectNumberOfCardsInAHand()
        {
            IList<ICard> cards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand));
            Hand newHand = new Hand(cards);

            Assert.AreEqual(true, new PokerHandsChecker().IsValidHand(newHand));
        }

        [TestMethod]
        public void TestINCorrectNumberOfCardsInAHand()
        {
            IList<ICard> cards = new List<ICard>(Helper.GeneratePockerHand(InCorrectNumberOfCardsInHand));
            Hand newHand = new Hand(cards);

            Assert.AreNotEqual(CorrectNumberOfCardsInHand, newHand.Cards.Count);
        }

        [TestMethod]
        public void TestSameCardsInHand()
        {
            IList<ICard> cards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand - 1));
            ICard sameCard = new Card(cards[cards.Count - 1].Face, cards[cards.Count - 1].Suit);
            cards.Add(sameCard);
            Hand newHand = new Hand(cards);

            Assert.AreEqual(false, new PokerHandsChecker().IsValidHand(newHand));
        }


        [TestMethod]
        public void TestTheHandHasFlush()
        {
            IList<ICard> cards = new List<ICard>();
            var currentCardFace = CardFace.Two;

            for (int i = 0; i < CorrectNumberOfCardsInHand; i++)
            {
                ICard card = new Card(currentCardFace, CardSuit.Diamonds);
                cards.Add(card);
                currentCardFace = currentCardFace + 2;
            }
            Hand newHand = new Hand(cards);
            Assert.AreEqual(true, new PokerHandsChecker().IsFlush(newHand));
        }

        [TestMethod]
        public void TestIfTheHandHasNoFlushWithConsecutiveCards()
        {
            IList<ICard> noFlushCards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand));
            Hand newHand = new Hand(noFlushCards);

            Assert.AreNotEqual(true, new PokerHandsChecker().IsFlush(newHand));
        }

        [TestMethod]
        public void TestIfTheHandHasNoFlushWithDifferentSuits()
        {
            IList<ICard> hasFlushCards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand - 1));
            ICard lastCard = hasFlushCards[hasFlushCards.Count - 1];
            int lastCardSuit = (int)lastCard.Suit;
            ICard nonSameSuitCard = new Card(((CardFace)(lastCard.Face + 2)), (CardSuit)(lastCardSuit + 1));
            hasFlushCards.Add(nonSameSuitCard);
            Hand newHand = new Hand(hasFlushCards);

            Assert.AreNotEqual(true, new PokerHandsChecker().IsFlush(newHand));
        }

        [TestMethod]
        public void TestWhenThereAreFourOfAKind()
        {
            var commonCardFace = CardFace.Nine;

            IList<ICard> fourOfAKindCards = new List<ICard>();

            for (int i = 0; i < Helper.GetAllSuits().Count; i++)
            {
                var newCard = new Card(commonCardFace, Helper.GetAllSuits()[i]);
                fourOfAKindCards.Add(newCard);
            }

            fourOfAKindCards.Add(new Card(CardFace.Queen, fourOfAKindCards[0].Suit));
            Hand fourOfAKindHand = new Hand(fourOfAKindCards);

            Assert.AreEqual(true, new PokerHandsChecker().IsFourOfAKind(fourOfAKindHand));
        }

        [TestMethod]
        public void TestWhenThereIsNoFourOfAKind()
        {
            IList<ICard> noFourOfAKindCards = new List<ICard>(Helper.GeneratePockerHand(CorrectNumberOfCardsInHand));
            Hand newHand = new Hand(noFourOfAKindCards);

            Assert.AreNotEqual(true, new PokerHandsChecker().IsFourOfAKind(newHand));
        }
    }
}
