using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithString
{
    public class StringFun
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] lines = text.Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                string lineSplit = lines[i].Split(commentSymbols[0]).First().TrimEnd();
                foreach (var trimmer in commentSymbols)
                {
                    var lineSplitNew = lines[i].Split(trimmer).First().TrimEnd();
                    lineSplit = lineSplitNew.Length < lineSplit.Length ? lineSplitNew : lineSplit;
                }
                lines[i] = lineSplit;
            }
            return String.Join("\n", lines);
        }


        public static bool HasUniqueChars(string str)
        {
            return str.Length == str.Distinct().Count();
        }

        public static string ToCsvText(int[][] array)
        {
            return String.Join('\n', array.Select(arr => String.Join(',', arr)));
        }

        public static int CountSmileys(string[] smileys)
        {
            return smileys.Where(smile => Regex.IsMatch(smile, @"^[:;][-~]?[)D]")).Count();
        }

        public static string GenerateShape(int n)
        {
            return String.Join('\n', new string[n].Select(line => String.Concat(new char[n].Select(s => s = '+'))));
        }

        public static string GenerateShape_Best(int n)
            => string.Join("\n", Enumerable.Repeat(new string('+', n), n));
    }
}
