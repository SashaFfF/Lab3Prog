using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._2.Services
{
    class Calc
    {
        public static void Calculate(double z)
        {
            double x=CalcX.CalculateX(z);
            double y = (2 * Math.Exp(-3 * x) - 4 * Math.Pow(x, 2)) / (Math.Log(Math.Abs(x)) + x);
            Console.WriteLine($"Calculation result {y}");
        }
    }
}
