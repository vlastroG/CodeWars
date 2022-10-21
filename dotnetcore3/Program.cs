using dotnetcore3.Challenges;
using dotnetcore3.Challenges.CompletedAllTests.WorkWithListsAndArrays.RangeExtraction;
using dotnetcore3.Challenges.CompletedAllTests.WorkWithMath;
using System;

public class Program
{
    public static void Main()
    {
        var list = RangeExtraction.Extract(new[] { -1, 0, 1, 3, 5, 7, 8, 9 });

        Console.ReadLine();
    }

}