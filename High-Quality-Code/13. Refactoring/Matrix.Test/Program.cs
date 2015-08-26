using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matrix.Test
{
    [TestClass]
    public class Test
    {
        private const string MatrixOneElement = " 1\r\n";

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMatrixWithSize0ShouldThrow()
        {
            var m = new Matrix(0);
        }

        [TestMethod]
        public void TestMatrixWithSize1ShouldReturnCorrectResult()
        {
            var matrix = new Matrix(1);
            Assert.AreEqual(matrix.ToString(), MatrixOneElement);
        }

    }
}
