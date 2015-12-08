// FileName   : Triangles.cs
// By         : Jennifer Klimova
// Date       : December, 08 2015
// Description: The Triangle program allows the user to input sides, or angles, and get 
//              the hypotenuse, the area, or the missing angle.
//              This handles all of the logic which calculates the angles, hypotenuse, and area.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Triangles
    {
        // Method Name   : FindHypotenuse()
        // Parameters    : double side1 : contains side 1
        //               : double side2 : contains side 2
        // Description   : this is called when the user clicks the hypotenuse button to get the hypotenuse
        // Return        : double hypotenuse : contains the hypotenuse
        public static double FindHypotenuse(double side1, double side2)
        {
            // Variable
            double hypotenuse = 0.0;

            // Checks if the number is greater than 0
            if ((side1 > 0) && side2 > 0)
            {
                // a^2 + b^2 = c^2
                hypotenuse = ((side1 * side1) + (side2 * side2));
                // Gets the square root of c^2
                hypotenuse = Isqrt(hypotenuse);
                // Convert
                string.Format("{0:F2}", hypotenuse);
            }
            else
            {
                hypotenuse = 0;
            }
            return hypotenuse;
        }

        // Method Name   : FindArea()
        // Parameters    : double side1 : contains side 1
        //               : double side2 : contains side 2
        // Description   : this is called when the user clicks the area button to get the area
        // Return        : double area : contains the area
        public static double FindArea(double side1, double side2)
        {
            // Variable
            double area = 0.0;

            // Checks if the number is greater than 0
            if((side1 > 0) && side2 > 0)
            {
                //area=0.5*AB
                area = 0.5 * (side1 * side2);
                // Convert
                string.Format("{0:F2}", area);
            }
            else
            {
                area = 0;
            }
            return area;
        }

        // Method Name   : FindAngle()
        // Parameters    : double angle1 : contains angle 1
        //               : double angle2 : contains angle 2
        // Description   : this is called when the user clicks the angle button to get the angle
        // Return        : double angle : contains the angle
        public static double FindAngle(double angle1, double angle2)
        {
            // Variable
            double angle = 0.0;

            // Checks if the number is greater than 0
            if((angle1 > 0) && angle2 > 0)
            {
                //180 - A+B
                angle = 180 - (angle1 + angle2);
                // Convert
                string.Format("{0:F2}", angle);
            }
            else
            {
                angle = 0;
            }
            return angle;
        }

        // Method Name   : Isqrt()
        // Parameters    : double num : contains the hypotenuse squared
        // Description   : this will square root the hypotenuse
        // Return        : double num : contains the square root of the hypotenuse
        // This function is modified from 
        //http://www.codecodex.com/wiki/Calculate_an_integer_square_root#C.23
        // Finds the integer square root of a positive number  
        public static double Isqrt(double num)
        {
            if (0 == num) { return 0; }  // Avoid zero divide  
            double n = (num / 2) + 1;       // Initial estimate, never low  
            double n1 = (n + (num / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (num / n)) / 2;
            } // end while
            string.Format("{0:F2}", n);
            return n;
        } // end Isqrt() 
    }
}
