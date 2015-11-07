using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Task4;

namespace HashTable.test
{
    [TestClass]
    public class Tests
    {
        public class HashtableTest
        {
            private static readonly Random Rng = new Random();

            [Test]
            public void InitialCountShouldBeZero()
            {
                var hashtable = new HashTable<string, string>();

                NUnit.Framework.Assert.AreEqual(0, hashtable.Count);
            }

            [Test]
            public void IndexerShouldReturnTheElementAddedWithAdd()
            {
                var hashtable = new HashTable<string, string>();

                var key = "npesheva";
                var value = "es6 promises";

                hashtable.Add(key, value);

                NUnit.Framework.Assert.AreEqual(value, hashtable[key]);
            }
        }
    }
}