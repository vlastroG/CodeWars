using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            var input = s;
            var sContainsPart2 = false;
            for (var i = 0; i < part1.Length; i++)
            {
                var index = input.IndexOf(part1[i]);
                if (index >= 0)
                {
                    input = input.Remove(index, 1);
                }
                else return false;
            }
            sContainsPart2 = part2 == input;

            input = s;
            var sContainsPart1 = false;
            for (var i = 0; i < part2.Length; i++)
            {
                var index = input.IndexOf(part2[i]);
                if (index >= 0)
                {
                    input = input.Remove(index, 1);
                }
                else return false;
            }
            sContainsPart1 = part1 == input;

            return sContainsPart1 && sContainsPart2;
        }

        public static bool isMerge2(string s, string part1, string part2)
        {
            StringBuilder _s = new StringBuilder(s);
            StringBuilder _part1 = new StringBuilder(part1);
            StringBuilder _part2 = new StringBuilder(part2);

            if ((_part1.Length > 0) && (_s[0] == _part1[0]))
            {
                for (int i = 0; i < _s.Length; i++)
                {
                    if ((_part1.Length > 0) && (_s[i] == _part1[0]))
                    {
                        _part1.Remove(0, 1);

                        continue;
                    }
                    else if ((_part2.Length > 0) && (_s[i] == _part2[0]))
                    {
                        _part2.Remove(0, 1);
                        continue;
                    }
                    else return false;
                }
            }

            else if ((_part2.Length > 0) && (_s[0] == _part2[0]))
            {
                for (int i = 0; i < _s.Length; i++)
                {
                    if ((_part2.Length > 0) && (_s[i] == _part2[0]))
                    {
                        _part2.Remove(0, 1);

                        continue;
                    }
                    else if ((_part1.Length > 0) && (_s[i] == _part1[0]))
                    {
                        _part1.Remove(0, 1);
                        continue;
                    }
                    else return false;
                }
            }

            if ((_part1.Length + _part2.Length) > 0)
                return false;
            return true;
        }
    }
}
