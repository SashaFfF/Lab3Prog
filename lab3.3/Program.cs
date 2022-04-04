using System;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Please enter a day:");
            day = Convert.ToInt32(Console.ReadLine());
            int month;
            Console.WriteLine("Please enter a month:");
            month = Convert.ToInt32(Console.ReadLine());
            int year;
            Console.WriteLine("Please enter a year:");
            year = Convert.ToInt32(Console.ReadLine());
            int difference=DateService.GetDaysSpan(day, month, year);
            Console.WriteLine($"Difference between specified date and current date:{difference}");
            string date;
            Console.WriteLine("Please enter the date in the format day/month/year(day.month.year):");
            date =Console.ReadLine();
            string dayOfWeek = DateService.GetDay(date);
            Console.WriteLine($"Day of the week for this date:{dayOfWeek}");

        }
    }
}
