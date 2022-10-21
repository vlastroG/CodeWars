using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    internal class SqInRect
    {
        public static List<int> sqInRect(int lng, int wdth)
        {
            if (lng < 1 || wdth < 1 || lng == wdth) return null;
            (lng, wdth) = MakeWdthSmallest(ref lng, ref wdth);
            List<int> sqSides = new List<int>();
            int area = wdth * lng;
            while (area > 0)
            {
                sqSides.Add(wdth);
                area -= wdth * wdth;
                lng -= wdth;
                (lng, wdth) = MakeWdthSmallest(ref lng, ref wdth);
            }
            return sqSides;
        }

        private static (int lng, int wdth) MakeWdthSmallest(ref int lng, ref int wdth)
        {
            if (wdth > lng)
            {
                // make width smaller than lng if it's not
                int buff = lng;
                lng = wdth;
                wdth = buff;
            }
            return (lng, wdth);
        }
    }
}
