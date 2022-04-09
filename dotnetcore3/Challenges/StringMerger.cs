using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
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
