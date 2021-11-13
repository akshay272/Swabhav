using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LSPVoilatonApp.Model;

namespace LSPVoilationTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestMethod1(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height = rectangle.Height + 20;
            var after = rectangle.Width;
            Assert.IsTrue(before == after);
            
        }
    }
}
