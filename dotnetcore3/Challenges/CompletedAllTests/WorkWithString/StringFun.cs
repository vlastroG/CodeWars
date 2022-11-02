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

        public static string Decode(string morseCode)
        {
            StringBuilder sb = new StringBuilder();
            var wordsMorse = morseCode.TrimStart().TrimEnd().Split("   ");
            foreach (var wordMorse in wordsMorse)
            {
                var word = String.Concat(wordMorse.Split(' ').Select(morse => /*MorseCode.Get(morse)*/morse));
                sb.Append(word);
                sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }

        public static int DuplicateCount(string str)
        {
            var charsAnalyze = str.ToLower().Trim().ToList();
            var chars = charsAnalyze.Distinct().ToList();
            int count = 0;
            foreach (var symbol in chars)
            {
                int countBeforeDeletion = charsAnalyze.Count;
                charsAnalyze.RemoveAll(x => x == symbol);
                int countAfterDeletion = charsAnalyze.Count;
                count = countBeforeDeletion - countAfterDeletion > 1 ? ++count : count;
            }
            return count;

            // or just this :)
            // return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }
    }
}
