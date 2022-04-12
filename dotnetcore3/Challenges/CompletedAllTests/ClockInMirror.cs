using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal class ClockInMirror
    {
        //05:25 --> 06:35
        //01:50 --> 10:10
        //11:58 --> 12:02
        //12:01 --> 11:59

        //Please complete the function WhatIsTheTime(timeInMirror),
        //where timeInMirror is the mirrored time(what Peter sees) as string.
        //Return the real time as a string.

        //Consider hours to be between 1 <= hour< 13.
        //So there is no 00:20, instead it is 12:20.
        //There is no 13:20, instead it is 01:20.

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
    }
}
