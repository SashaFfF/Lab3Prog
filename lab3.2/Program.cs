using System;
using lab3._2.Services;

namespace lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            Console.WriteLine("Please enter a number:");
            z = Convert.ToInt32(Console.ReadLine());
            Calc.Calculate(z);
        }
    }
}
