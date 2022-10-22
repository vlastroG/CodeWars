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
    }
}
