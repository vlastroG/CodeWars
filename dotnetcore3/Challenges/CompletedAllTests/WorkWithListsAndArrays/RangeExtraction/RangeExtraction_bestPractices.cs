using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithListsAndArrays.RangeExtraction
{
    public class RangeExtraction_bestPractices
    {
        public int Value, Count;
        public int NextValue => Value + Count;

        public RangeExtraction_bestPractices(int value)
        {
            Value = value;
            Count = 1;
        }

        public override string ToString()
            => Count == 1 ? $"{Value}" :
               Count == 2 ? $"{Value},{Value + 1}" :
                            $"{Value}-{NextValue - 1}";

        public static string Extract(int[] args)
        {
            var list = new List<RangeExtraction_bestPractices>();

            foreach (var n in args)
                if (list.LastOrDefault()?.NextValue == n) list.Last().Count++;
                else list.Add(new RangeExtraction_bestPractices(n));

            return string.Join(",", list);
        }
    }
}
