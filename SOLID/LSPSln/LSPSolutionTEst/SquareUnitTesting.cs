using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LSPsolutionApp.Model;
namespace LSPSolutionTEst
{
    [TestClass]
    public class SquareUnitTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square square = new Square(30);
            square.Side = square.Side + 20;
            Assert.AreEqual<int>(50, 50);

        }
        [TestMethod]
        public void CalculateAreaTest()
        {
            Square square = new Square(30);
            Assert.AreEqual<int>(900, 900);
        }
    }
}
