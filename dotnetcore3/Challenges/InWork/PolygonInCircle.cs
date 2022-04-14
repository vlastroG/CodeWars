using System;
using static System.Math;

namespace dotnetcore3.Challenges.InWork
{
    internal class PolygonInCircle
    {
        public class Calculator
        {
            public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
            {
                return Math.Round(numberOfSides * circleRadius * circleRadius / 2 * Math.Sin(2 * Math.PI / numberOfSides), 3);
            }
        }
    }
}
