using System;
using static System.Math;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotnetcore3.Challenges.InWork
{
    public static class SquareOrNotTo
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var num = Math.Sqrt(array[i]);
                if (num != Math.Round(num))
                {
                    array[i] = array[i] * array[i];
                }
                else
                {
                    array[i] = (int)num;
                }
            }
            return array;
        }

        public static int[] SquareOrSquareRoot_byMasters(int[] array)
        {
            return array.Select(x => (int)(Math.Sqrt(x) % 1 == 0 ? Math.Sqrt(x) : x * x)).ToArray();
        }
    }
}
