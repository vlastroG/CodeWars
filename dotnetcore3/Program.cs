using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dotnetcore3.Challenges.TimeFormat;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetReadableTime(60));
        Console.WriteLine(GetReadableTime(2147483647));

        Console.ReadLine();
    }

}