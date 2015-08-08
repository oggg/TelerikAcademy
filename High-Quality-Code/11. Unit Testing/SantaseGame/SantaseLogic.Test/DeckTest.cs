using NUnit.Framework;
using Santase;
using Santase.Logic;
using Santase.Logic.Cards;

namespace SantaseLogic.Test
{
    [TestFixture]

    public class DeckTest
    {
        private const int InitialNumberOfCardsInDeck = 24;

        [Test]
        public void TestTheDeckIsNotNull()
        {
            Deck newDeck = new Deck();
            Assert.IsNotNull(newDeck, "The newly created deck is empty");
        }

        [Test]
        public void TestChangingOfTrumpCards()
        {
            Deck newDeck = new Deck();
            Card newTrumpCard = new Card(CardSuit.Diamond, CardType.King);
            newDeck.ChangeTrumpCard(newTrumpCard);
            Assert.AreSame(newTrumpCard, newDeck.GetTrumpCard);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void CheckTheNumberOfCardsLeftAfterGettingCardsFromDeck(int cardsPulled)
        {
            Deck newDeck = new Deck();
            for (int i = 0; i < cardsPulled; i++)
            {
                newDeck.GetNextCard();
            }

            int cardsLeft = InitialNumberOfCardsInDeck - cardsPulled;

            Assert.AreEqual(cardsLeft, newDeck.CardsLeft);
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void TestThrowingExceptionWhenAllCardsArePulledFromDeckAndTryingToPullAnotherCard()
        {
            Deck newDeck = new Deck();
            for (int i = 0; i < InitialNumberOfCardsInDeck; i++)
            {
                newDeck.GetNextCard();
            }

            newDeck.GetNextCard();
        }
        
    }
}
