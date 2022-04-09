using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dotnetcore3.Challenges.StringMerger;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"));
        Console.WriteLine(isMerge("", "", ""));
        Console.WriteLine(isMerge("codewars", "", "codewars"));
        

        Console.ReadLine();
    }

}