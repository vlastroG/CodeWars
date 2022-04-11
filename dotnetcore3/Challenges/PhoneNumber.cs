using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore3.Challenges
{
    internal static class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            List<int> nums = numbers.ToList();

            return $"({String.Join("", nums.GetRange(0, 3))}) {String.Join("", nums.GetRange(3, 3))}-{String.Join("", nums.GetRange(6, 4))}";
        }

        public static string CreatePhoneNumber_by_DimaNeDima(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
