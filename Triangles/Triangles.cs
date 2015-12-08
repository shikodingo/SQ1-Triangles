using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Triangles
    {
        public static double FindHypotenuse(double side1, double side2)
        {
            double hypotenuse = 0.0;

            if ((side1 > 0) && side2 > 0)
            {
                hypotenuse = ((side1 * side1) + (side2 * side2));
                hypotenuse = Isqrt(hypotenuse);
                string.Format("{0:F2}", hypotenuse);
            }
            else
            {
                hypotenuse = 0;
            }
            return hypotenuse;
        }

        public static double FindArea(double side1, double side2)
        {
            double area = 0.0;

            if((side1 > 0) && side2 > 0)
            {
                area = 0.5 * (side1 * side2);
                string.Format("{0:F2}", area);
            }
            else
            {
                area = 0;
            }

            return area;
        }

        public static double FindAngle(double angle1, double angle2)
        {
            double angle = 0.0;

            if((angle1 > 0) && angle2 > 0)
            {
                angle = 180 - (angle1 + angle2);
                string.Format("{0:F2}", angle);
            }
            else
            {
                angle = 0;
            }
            return angle;
        }

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
