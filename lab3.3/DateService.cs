using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._3
{
    public class DateService
    {
        public static string GetDay(string date) 
        {
            DateTime dt = DateTime.Parse(date);
            return dt.DayOfWeek.ToString();
        }

        public static int GetDaysSpan(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);
            TimeSpan result = DateTime.Now - dt;
            return Math.Abs(result.Days);
        }
    }
}
