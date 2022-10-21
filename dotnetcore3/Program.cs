using dotnetcore3.Challenges;
using dotnetcore3.Challenges.CompletedAllTests.WorkWithMath;
using System;

public class Program
{
    public static void Main()
    {
        var list = SqInRect.sqInRect(3, 5);
        if (!list.Equals(null))
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        Console.ReadLine();
    }

}