using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    public class Fibonacci
    {
        public static int Fib(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            else
            {
                var f = 0;
                for (int i = 2, f1 = 0, f2 = 1; i < n; i++)
                {
                    f = f1 + f2;
                    f1 = f2;
                    f2 = f;
                }
                return f;
            }

        }
    }
}
