using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    public class MakeNegativeKata
    {
        public static int MakeNegative(int number)
        {
            return number < 0 ? number : -number;
        }

        public static int SquareDigits(int n)
        {
            StringBuilder sb = new StringBuilder();
            string numbers = n.ToString();
            for (int i = 0; i < numbers.Length; i++)
            {
                // 9119
                // 9
                // 9*9
                // 81
                // 811
                int number = int.Parse(numbers[i].ToString());
                //int number = (int)numbers[i];
                int square = number * number;
                sb.Append(square);
            }
            return int.Parse(sb.ToString());
        }


    }
}
