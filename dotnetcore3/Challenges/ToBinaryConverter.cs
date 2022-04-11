using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges
{
    internal static class ToBinaryConverter
    {
        public static string ToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}
