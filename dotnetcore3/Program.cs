﻿using dotnetcore3.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dotnetcore3.Challenges.ZerosToEnd;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine(isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"));
        //Console.WriteLine(isMerge("", "", ""));
        //Console.WriteLine(isMerge("codewars", "", "codewars"));

        //Console.WriteLine(Converter.ToBinary(3));
        //Console.WriteLine(Converter.ToBinary(-3));

        //Console.WriteLine(Order("is2 Thi1s T4est 3a"));
        //Console.WriteLine(Order(""));   

        //Console.WriteLine(Order_byNDusan88("is2 Thi1s T4est 3a"));
        //Console.WriteLine(Order_byNDusan88(""));

        //Console.WriteLine(WordsMiddle.GetMiddle("test"));
        //Console.WriteLine(WordsMiddle.GetMiddle("testing"));
        //Console.WriteLine(WordsMiddle.GetMiddle("middle"));
        //Console.WriteLine(WordsMiddle.GetMiddle("A"));

        //Console.WriteLine(RomainConvert.Solution(1000));
        //Console.WriteLine(RomainConvert.Solution(1));
        //Console.WriteLine(RomainConvert.Solution(2));
        //Console.WriteLine(RomainConvert.Solution(4));
        //Console.WriteLine(RomainConvert.Solution(500));
        //Console.WriteLine(RomainConvert.Solution(1990));
        //Console.WriteLine(RomainConvert.Solution(2008));

        Console.WriteLine(ZerosToEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));

        Console.ReadLine();
    }

}