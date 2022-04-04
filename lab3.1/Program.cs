using System;

namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Please enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            int result = Calc.Replacement(a);
            Console.WriteLine($"The new value of the number: {result}");
        }
    }
}
