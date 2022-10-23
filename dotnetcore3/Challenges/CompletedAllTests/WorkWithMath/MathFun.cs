﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    public static class MathFun
    {
        public static double SquareArea(double A)
        {
            return Math.Round((4 * A / (2 * Math.PI)) * (4 * A / (2 * Math.PI)), 2);
        }
        public static double FindAverage(double[] array)
        {
            return array.Sum() / array.Length;
        }

        public static int Remainder(int a, int b)
        {
            return Math.Max(a, b) / Math.Min(a, b);
        }

        public static string GeometricSequenceElements(int a, int r, int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = a * (int)Math.Pow(r, i);
            }
            return String.Join(", ", arr);
        }

        public static string GeometricSequenceElements_Finest(int a, int r, int n)
        {
            return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
        }

        public static int СenturyFromYear(int year)
        {
            return year % 100 == 0 ? year / 100 : year / 100 + 1;
        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > (ClassPoints.Sum() + YourPoints) / (ClassPoints.Length + 1);
        }
    }
}
