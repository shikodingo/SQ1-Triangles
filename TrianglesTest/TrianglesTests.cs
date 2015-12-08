using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TrianglesTest
{
    [TestClass]
    public class TrianglesTests
    {
        
        [TestMethod]
        public void TestFindHypotenuseValid()
        {
            double side1 = 5;
            double side2 = 6;
            double hypotenuse = 0;
            double expectedH = 7.81;

           hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

            Assert.AreEqual(expectedH, hypotenuse);
        }
    }
}
