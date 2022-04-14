using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace dotnetcore3.Challenges
{
    internal static class WordsOrder
    {
        public static string Order(string words)
        {
            if (String.IsNullOrEmpty(words))
            {
                // Work with empty input
                return words;
            }

            StringBuilder sb = new StringBuilder();

            var t = words.Split(' ');
            var wordsTest = words
                .Split(' ')
                .ToDictionary(w => Int32.Parse(Regex.Match(w, @"\d+").Value), w => w.ToString()) // Find numbers in words and create dictionary
                .OrderBy(elem => elem.Key) // Sort words in dictionary by containing numbers
                .ToDictionary(pair => pair.Key, pair => pair.Value) // Convert IOrderEnumerable to Dictionary
                .Values; // Get words in necessary order

            sb.AppendJoin(" ", wordsTest);

            return sb.ToString();
        }

        public static string Order_byNDusan88(string words)
        {
            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }
    }
}
