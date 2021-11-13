using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSPVoilatonApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPVoilatonApp.Model;
namespace LSPVoilatonApp.Model.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleTest(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height = rectangle.Height + 20;
            var after = rectangle.Width;
            Assert.AreEqual<int>(before, after);
            
        }

       /* [TestMethod()]
        public void CalculateAreaTest()
        {
            Assert.Fail();
        }*/
    }
}