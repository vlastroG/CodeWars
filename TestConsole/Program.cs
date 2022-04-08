﻿using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string test = "To_camel_case";
        Console.WriteLine(ToCamelCase(test));

        Console.ReadLine();
    }

    public static string ToCamelCase(string str)
    {
        var words = StringSplitter(str);

        if (Char.IsUpper(words[0][0]))
        {
            words[0] = FirstCharUp(words[0]);
        }

        for (int i = 1; i < words.Length; i++)
        {
            words[i] = FirstCharUp(words[i]);
        }


        StringBuilder sb = new();
        foreach (var item in words)
        {
            sb.Append(item);
        }
        return sb.ToString();
    }

    private static string[] StringSplitter(string str)
    {
        var words = new List<string>();
        try
        {
            words = str.Split('-').ToList();
            if (!(words.Count > 1))
            {
                try
                {
                    words = str.Split('_').ToList();
                    if (!(words.Count > 1))
                    {
                        throw new ArgumentException($"{nameof(str)} содержит меньше 2-х слов.");
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException();
                }
            }
        }
        catch (Exception)
        {
            throw new ArgumentException();
        }

        return words.ToArray();
    }

    private static string FirstCharUp(string word)
    {
        char letter = Char.ToUpper(word[0]);
        return letter + word.Substring(1);
    }
}