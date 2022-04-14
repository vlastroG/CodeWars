using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotnetcore3.Challenges.InWork
{
    public class FridayThe13ths
    {
        public static string FridayTheThirteenths(int Start, int End = int.MinValue)
        {
            DateTime timeStart = new DateTime(Start, 1, 1);
            var time = timeStart;
            DateTime timeEnd = new DateTime(End + 1, 1, 1);

            StringBuilder sb = new StringBuilder();

            while (time.Day != timeEnd.Day)
            {
                if (time.DayOfWeek == DayOfWeek.Friday && time.Day == 13)
                {
                    Console.WriteLine(time.Day);
                }
                time += TimeSpan.FromDays(1);
            }
            //var days13 = DateTime;
            var t = (timeEnd - timeStart).Days;
            return timeStart.ToString();
        }
    }
}
