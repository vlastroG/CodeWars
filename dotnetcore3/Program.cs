using dotnetcore3.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dotnetcore3.Challenges.Converter;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine(isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"));
        //Console.WriteLine(isMerge("", "", ""));
        //Console.WriteLine(isMerge("codewars", "", "codewars"));

        Console.WriteLine(Converter.ToBinary(3));
        Console.WriteLine(Converter.ToBinary(-3));

        Console.ReadLine();
    }

}