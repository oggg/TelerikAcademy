namespace EqualNumbers.Test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSubsequence
    {
        [TestMethod]
        public void ExpectingListOfThreeElementsToBeReturnedCorrectly()
        {
            List<int> collection = new List<int> { 1, 1, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 6, 7, 87, 43 };
            var equalSubsequence = Subsequence.Find(collection);
            CollectionAssert.AreEqual(new List<int> { 4, 4, 4, 4, 4, 4, 4 }, equalSubsequence);
        }

        [TestMethod]
        public void ExpectingListOfThreeElementsToBeIncorrect()
        {
            List<int> collection = new List<int> { 1, 1, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 6, 7, 87, 43 };
            var equalSubsequence = Subsequence.Find(collection);
            CollectionAssert.AreNotEqual(new List<int> { 4, 4, 4, 4, 4, 4 }, equalSubsequence);
        }
    }
}
