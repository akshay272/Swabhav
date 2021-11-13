using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LSPsolutionApp.Model;

namespace LSPSolutionTEst
{
    [TestClass]
    public class RectangleUnitTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rectangle rectangle = new Rectangle(50, 60);
            rectangle.Height = rectangle.Height + 20;
            Assert.AreEqual<int>(rectangle.Height, 80);
            Assert.AreEqual<int>(rectangle.Width, 50);
        }
        
    }
}
