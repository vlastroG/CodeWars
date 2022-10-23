using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.InWork
{
    public class LargeFactorial
    {
        public static string Factorial(int n)
        {
            if (n < 0) return null;
            if (n == 0) return "1";
            ulong factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= (ulong)i;
            }
            return factorial.ToString();
        }
    }
}
