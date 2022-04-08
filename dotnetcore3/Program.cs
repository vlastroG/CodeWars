using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dotnetcore3.Challenges.ClockInMirror;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(WhatIsTheTimeBy_jpdagger("01:20"));
        Console.WriteLine(WhatIsTheTimeBy_jpdagger("10:40"));
        Console.WriteLine(WhatIsTheTimeBy_jpdagger("05:25"));
        Console.WriteLine(WhatIsTheTimeBy_jpdagger("06:35"));

        Console.ReadLine();
    }

}