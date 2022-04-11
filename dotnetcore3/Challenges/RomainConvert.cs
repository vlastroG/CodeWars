using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class RomainConvert
    {
        public static string Solution(int n)
        {
            Dictionary<int, string> RomanLetters = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

            var romain = new StringBuilder();
            while (n > 0)
            {
                foreach (var key in RomanLetters.Keys)
                {
                    if (n >= key)
                    {
                        n -= key;
                        romain.Append(RomanLetters[key]);
                        break;
                    }
                }
            }
            return romain.ToString();
        }

    }
}
