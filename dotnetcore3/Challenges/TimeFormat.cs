using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    //Write a function, which takes a non-negative integer(seconds) as input
    //and returns the time in a human-readable format(HH: MM:SS)

    //HH = hours, padded to 2 digits, range: 00 - 99
    //MM = minutes, padded to 2 digits, range: 00 - 59
    //SS = seconds, padded to 2 digits, range: 00 - 59
    //The maximum time never exceeds 359999(99:59:59)

    //You can find some examples in the test fixtures.

    public static class TimeFormat
    {
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
