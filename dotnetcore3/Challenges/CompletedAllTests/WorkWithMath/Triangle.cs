using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }
    }
}
