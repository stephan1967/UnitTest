using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public int totaal { get; private set; }

        [DataRow(0, 0, 0)]
        [DataRow(3, 5, 8)]
        [DataRow(2, 667751, 667753)]
        [DataTestMethod]
        public void TestMethod1(int X, int Y, int z)
        {

            var calc = new Rekenmachine();
            totaal = calc.Optellen(X,Y);
            Assert.AreEqual(z, totaal);

        }
    }
}
