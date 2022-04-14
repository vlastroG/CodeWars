using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests
{
    public static class WorkWithTime
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            // Get int hours and minutes from input
            var time = timeInMirror.Split(':');
            var hours = int.Parse(time[0]);
            var minutes = int.Parse(time[1]);

            // Calculate real minutes
            var realMinutes = 60 - minutes;
            if (realMinutes == 60)
            {
                realMinutes = 0;
            }

            // Calculate if an hour have already begun
            var hStart = 0;
            if (realMinutes > 0)
            {
                hStart = 1;
            }
            // Calculate real hours
            var realHours = 12 - hours - hStart;
            if (realHours <= 0)
            {
                realHours += 12;
            }

            return $"{realHours:00}:{realMinutes:00}";
        }

        public static string WhatIsTheTimeBy_jpdagger(string timeInMirror)
        {
            return DateTime.Parse("12:00").Subtract(TimeSpan.Parse(timeInMirror)).ToString("hh:mm");
        }


        public static string GetReadableTime(int seconds)
        {
            // Input seconds to TimeSpan
            TimeSpan time = new TimeSpan(0, 0, seconds);

            TimeSpan maxTime = new TimeSpan(99, 59, 59); // Calculate max time
            if (time > maxTime)
                time = maxTime; // Comparison of input and max time
            var total = (int)time.TotalHours; // Get hours of time without days

            return $"{total:00}:" + time.ToString(@"mm\:ss");
        }

        public static string GetReadableTimeBy_HardTourVela(int seconds)
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}
