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
            double expectedH = 0;

            hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

            string convert = hypotenuse.ToString("N2");
            hypotenuse = double.Parse(convert);

            Assert.AreEqual(expectedH, hypotenuse);
        }
        [TestMethod]
       public void TestFindAreaValid()
        {
            // Variables
            double side1 = 5.0;
            double side2 = 6.0;
            double area = 0.0;
            double expectedA = 15.0;

            area = Triangles.Triangles.FindArea(side1, side2);

            string convert = area.ToString("N2");
            area = double.Parse(convert);

            Assert.AreEqual(expectedA, area);
        }

       [TestMethod]
       public void TestFindAreaInvalid()
        {
            // Variables
            double side1 = -5.0;
            double side2 = -6.0;
            double area = 0.0;
            double expectedA = 0;

            area = Triangles.Triangles.FindArea(side1, side2);

            string convert = area.ToString("N2");
            area = double.Parse(convert);

            Assert.AreEqual(expectedA, area);
        }

        [TestMethod]
       public void TestFindAngleValid()
       {
           double angle1 = 50.0;
           double angle2 = 51.0;
           double missingAngle = 0.0;
           double expectedAn = 79;

           missingAngle = Triangles.Triangles.FindAngle(angle1, angle2);

           string convert = missingAngle.ToString("N2");
           missingAngle = double.Parse(convert);

           Assert.AreEqual(expectedAn, missingAngle);
       }

        [TestMethod]
        public void TestFindAngleInvalid()
        {
            double angle1 = -50.0;
            double angle2 = -51.0;
            double missingAngle = 0.0;
            double expectedAn = 0;

            missingAngle = Triangles.Triangles.FindAngle(angle1, angle2);

            string convert = missingAngle.ToString("N2");
            missingAngle = double.Parse(convert);

            Assert.AreEqual(expectedAn, missingAngle);
        }
    }
}
