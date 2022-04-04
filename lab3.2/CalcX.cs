using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._2
{
    public class CalcX
    {
        public static double CalculateX(double z)
        {
            if (z > 0)
            {
                Console.WriteLine("The first branch was used for the calculations");
                return  (1 / (Math.Pow(z, 2) + 2 * z));
            }
            else
            {
                Console.WriteLine("The second branch was used for the calculations");
                return (1 - Math.Pow(z, 3));
            }
        }
    }
}
