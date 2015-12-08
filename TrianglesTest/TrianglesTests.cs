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
            // Variables
            double side1 = 5.0;
            double side2 = 6.0;
            double hypotenuse = 0.0;
            double expectedH = 7.81;

           hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

           string convert = hypotenuse.ToString("N2");
           hypotenuse = double.Parse(convert);

            Assert.AreEqual(expectedH, hypotenuse);
        }
        [TestMethod]
        public void TestFindHypotenuseInvalid()
        {
            // Variables
            double side1 = -5.0;
            double side2 = -6.0;
            double hypotenuse = 0.0;
            double expectedH = -7.81;

            hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

            string convert = hypotenuse.ToString("N2");
            hypotenuse = double.Parse(convert);

            Assert.AreEqual(expectedH, hypotenuse);
        }
    }
}
