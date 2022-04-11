using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class WordsMiddle
    {
        public static string GetMiddle(string s)
        {
            if (s.Length > 2)
            {

                if (s.Length % 2 == 0)
                {
                    return $"{s[s.Length / 2 - 1]}{s[s.Length / 2]}";
                }
                else
                {
                    return $"{s[(s.Length - 1) / 2]}";
                }
            }
            else return s;
        }
    }
}
