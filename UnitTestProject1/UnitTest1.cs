using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public int totaal { get; private set; }
         
      
        [DataRow(0, 0, 0)]
        [DataRow(3, 5, 8)]
        [DataRow(2, 100, 102)]
        [DataTestMethod]
        public void Add(int X, int Y, int z)
        {
            var calc = new Rekenmachine();
            totaal = calc.Optellen(X,Y);
            Assert.AreEqual(z, totaal);
        }
        
        [DataRow(0, 0, 0)]
        [DataRow(13, 7, 6)]
        [DataRow(3000, 1400, 1600)]
        [DataTestMethod]
        public void Subtract(int X, int Y, int z)
        {
            var calc = new Rekenmachine();
            totaal = calc.Aftrekken(X, Y);
            Assert.AreEqual(z, totaal);        
        }

        [DataRow(10, 2, 5)]
        [DataRow(1400, 7, 200)]
        [DataRow(3, 3, 1)]
        [DataTestMethod]
        public void Divide(int X, int Y, int z)
        {
            var calc = new Rekenmachine();
            totaal = calc.Delen(X, Y);
            Assert.AreEqual(z, totaal);   
        }
    }
}
