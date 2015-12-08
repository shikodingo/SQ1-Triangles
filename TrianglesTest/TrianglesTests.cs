// FileName   : TrianglesTests.cs
// By         : Jennifer Klimova
// Date       : December, 08 2015
// Description: The Triangle program allows the user to input sides, or angles, and get 
//              the hypotenuse, the area, or the missing angle.
//              This contains the tests for the Triangles class. It ensures that the numbers we are getting are correct.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TrianglesTest
{
    [TestClass]
    public class TrianglesTests
    {
        /**
        * Description : This test will take side variables and set them to valid values
        * 
        * Test Method Name : TestFindHypotenuseValid()
        * 
        * How Test is Conducted : This test runs automatically
        * 
        * Type of Test : The type of test is normal/functional.
        * 
        * Sample Data Sets :
        * double side1 = 5.0;
        * double side2 = 6.0;
        * double hypotenuse = 0.0;
        * double expectedH = 7.81;
        * 
        * Expected Result :
        * The expected result is that the hypotenuse matches the expected hypotenuse
        * 
        * Actual Result :
        * Both hypotenuses match up
        */
        [TestMethod]
        public void TestFindHypotenuseValid()
        {
            // Variables
            double side1 = 5.0;
            double side2 = 6.0;
            double hypotenuse = 0.0;
            double expectedH = 7.81;

            // Calls the function
           hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

            // Converts
           string convert = hypotenuse.ToString("N2");
           hypotenuse = double.Parse(convert);

            // Checks if both are equal
            Assert.AreEqual(expectedH, hypotenuse);
        }

        /**
        * Description : This test will take side variables and set them to invalid values
        * 
        * Test Method Name : TestFindHypotenuseInvalid()
        * 
        * How Test is Conducted : This test runs automatically
        * 
        * Type of Test : The type of test is an exception.
        * 
        * Sample Data Sets :
        * double side1 = -5.0;
        * double side2 = -6.0;
        * double hypotenuse = 0.0;
        * double expectedH = 0;
        * 
        * Expected Result :
        * The expected result is that the hypotenuse was not set because it was not greater than zero
        * 
        * Actual Result :
        * The hypotenuse was not set
        */
        [TestMethod]
        public void TestFindHypotenuseInvalid()
        {
            // Variables
            double side1 = -5.0;
            double side2 = -6.0;
            double hypotenuse = 0.0;
            double expectedH = 0;

            // Call function
            hypotenuse = Triangles.Triangles.FindHypotenuse(side1, side2);

            // Convert
            string convert = hypotenuse.ToString("N2");
            hypotenuse = double.Parse(convert);

            // Checks if they match
            Assert.AreEqual(expectedH, hypotenuse);
        }

        /**
        * Description : This test will take side variables and set them to valid values
        * 
        * Test Method Name : TestFindAreaValid()
        * 
        * How Test is Conducted : This test runs automatically
        * 
        * Type of Test : The type of test is normal/functional.
        * 
        * Sample Data Sets :
        * double side1 = 5.0;
        * double side2 = 6.0;
        * double area = 0.0;
        * double expectedA = 15.0;
        * 
        * Expected Result :
        * The expected result is that the area matches the expected area
        * 
        * Actual Result :
        * Both areas match up
        */
        [TestMethod]
       public void TestFindAreaValid()
        {
            // Variables
            double side1 = 5.0;
            double side2 = 6.0;
            double area = 0.0;
            double expectedA = 15.0;

            // Call function
            area = Triangles.Triangles.FindArea(side1, side2);

            // Convert
            string convert = area.ToString("N2");
            area = double.Parse(convert);

            // Checks if matches
            Assert.AreEqual(expectedA, area);
        }

        /**
        * Description : This test will take side variables and set them to invalid values
        * 
        * Test Method Name : TestFindAreaInvalid()
        * 
        * How Test is Conducted : This test runs automatically
        * 
        * Type of Test : The type of test is an exception.
        * 
        * Sample Data Sets :
        * double side1 = -5.0;
        * double side2 = -6.0;
        * double area = 0.0;
        * double expectedA = 0;
        * 
        * Expected Result :
        * The expected result is that the area was not set because it was not greater than zero
        * 
        * Actual Result :
        * The area was not set
        */
       [TestMethod]
       public void TestFindAreaInvalid()
        {
            // Variables
            double side1 = -5.0;
            double side2 = -6.0;
            double area = 0.0;
            double expectedA = 0;

           // Call the find area function
            area = Triangles.Triangles.FindArea(side1, side2);

           // Convert
            string convert = area.ToString("N2");
            area = double.Parse(convert);

           // Check if matches
            Assert.AreEqual(expectedA, area);
        }

       /**
       * Description : This test will take angle variables and set them to valid values
       * 
       * Test Method Name : TestFindAngleValid()
       * 
       * How Test is Conducted : This test runs automatically
       * 
       * Type of Test : The type of test is normal/functional.
       * 
       * Sample Data Sets :
       * double side1 = 50.0;
       * double side2 = 51.0;
       * double hypotenuse = 0.0;
       * double expectedH = 79;
       * 
       * Expected Result :
       * The expected result is that the angle matches the expected angle
       * 
       * Actual Result :
       * Both angles match up
       */
        [TestMethod]
       public void TestFindAngleValid()
       {
            // Variables
           double angle1 = 50.0;
           double angle2 = 51.0;
           double missingAngle = 0.0;
           double expectedAn = 79;

            // Call the function
           missingAngle = Triangles.Triangles.FindAngle(angle1, angle2);

            // Convert
           string convert = missingAngle.ToString("N2");
           missingAngle = double.Parse(convert);

            // Check if matches
           Assert.AreEqual(expectedAn, missingAngle);
       }

        /**
        * Description : This test will take angle variables and set them to invalid values
        * 
        * Test Method Name : TestFindAngleInvalid()
        * 
        * How Test is Conducted : This test runs automatically
        * 
        * Type of Test : The type of test is an exception.
        * 
        * Sample Data Sets :
        * double side1 = -50.0;
        * double side2 = -51.0;
        * double area = 0.0;
        * double expectedA = 0;
        * 
        * Expected Result :
        * The expected result is that the angle was not set because it was not greater than zero
        * 
        * Actual Result :
        * The angle was not set
        */
        [TestMethod]
        public void TestFindAngleInvalid()
        {
            // Variables
            double angle1 = -50.0;
            double angle2 = -51.0;
            double missingAngle = 0.0;
            double expectedAn = 0;

            // Call function
            missingAngle = Triangles.Triangles.FindAngle(angle1, angle2);

            // Convert
            string convert = missingAngle.ToString("N2");
            missingAngle = double.Parse(convert);

            // Check if matches
            Assert.AreEqual(expectedAn, missingAngle);
        }
    }
}
