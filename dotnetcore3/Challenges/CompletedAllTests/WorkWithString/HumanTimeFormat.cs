using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithString
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            TimeSpan timeSpan = new TimeSpan(0, 0, seconds);
            return TimeSpanToString(timeSpan);
        }

        private static string TimeSpanToString(TimeSpan timeSpan)
        {
            //years, days, hours, minutes and seconds.
            int years = timeSpan.Days / 365;
            int days = timeSpan.Days % 365;
            int hours = timeSpan.Hours;
            int minutes = timeSpan.Minutes;
            int seconds = timeSpan.Seconds;
            int[] times = new int[] { years, days, hours, minutes, seconds };
            string[] timeNames = new string[] { "years", "days", "hours", "minutes", "seconds" };
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] > 0)
                {
                    sb.Append(times[i]);
                    sb.Append(' ');
                    string timeName = times[i] == 1 ? timeNames[i].Remove(timeNames[i].Length - 1, 1) : timeNames[i];
                    sb.Append(timeName);
                    sb.Append(", ");
                    count++;
                }
            }
            string timeSpanString = sb.ToString().TrimEnd().TrimEnd(',');
            if (count > 1)
            {
                var lastComma = timeSpanString.LastIndexOf(',');
                var firstPart = timeSpanString.Substring(0, lastComma);
                var secondPart = timeSpanString.Substring(lastComma + 2);
                return firstPart + " and " + secondPart;
            }
            return timeSpanString;
        }

        private class Date
        {
            private static readonly int secondsInYear = 365 * 24 * 60 * 60;

            private static readonly int secondsInDay = 24 * 60 * 60;

            private static readonly int secondsInHour = 60 * 60;

            private static readonly int secondsInMinute = 60;
            public int Years { get; }

            public int Days { get; }

            public int Hours { get; }

            public int Minutes { get; }

            public int Seconds { get; }

            public Date(int seconds)
            {
                Years = seconds / secondsInYear;
                Days = (seconds - Years * secondsInYear) / secondsInDay;
                Hours = (seconds - Years * secondsInYear - Days * secondsInDay) / secondsInHour;
                Minutes = (seconds - Years * secondsInYear - Days * secondsInDay - Hours * secondsInHour) / secondsInMinute;
                Seconds = seconds - Years * secondsInYear - Days * secondsInDay - Hours * secondsInHour - Minutes * secondsInMinute;
            }
        }
    }
}
