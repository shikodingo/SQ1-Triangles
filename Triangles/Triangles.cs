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
