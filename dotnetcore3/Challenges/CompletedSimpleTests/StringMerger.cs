using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            int j = 0;
            int k = 0;
            bool lastIsEqual = false;
            for (int i = 0; i < s.Length; i++)
            {
                char sC = s[i];
                bool theseEqual = j < part1.Length && k < part2.Length && part1[j].Equals(part2[k]);
                if (j < part1.Length && s[i].Equals(part1[j]))
                {
                    char p1C = part1[j];
                    if (theseEqual)
                    {
                        j++;
                        if (j != part1.Length) k++;
                    }
                    else
                    {
                        j++;
                        if (lastIsEqual && part2.Length != k) k--;
                    }
                    lastIsEqual = theseEqual;
                    continue;
                }
                else if (k < part2.Length && s[i].Equals(part2[k]))
                {
                    char p2C = part2[k];
                    if (theseEqual)
                    {
                        j++;
                        if (j != part1.Length) k++;
                    }
                    else
                    {
                        k++;
                        if (lastIsEqual && part1.Length != j) j--;
                    }
                    lastIsEqual = theseEqual;
                    continue;
                }
                else return false;
            }
            return (j == part1.Length) && (k == part2.Length);
        }
    }
}
