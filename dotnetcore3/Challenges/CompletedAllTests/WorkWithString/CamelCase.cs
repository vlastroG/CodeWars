using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithString
{
    internal class CamelCase
    {
        public static string ToCamelCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            var strSplitted = str.Split(new char[] { '-', '_' });
            sb.Append(strSplitted[0]);
            for (int i = 1; i < strSplitted.Length; i++)
            {
                sb.Append(strSplitted[i][0].ToString().ToUpper());
                for (int j = 1; j < strSplitted[i].Length; j++)
                {
                    sb.Append(strSplitted[i][j]);
                }
            }
            return sb.ToString();
        }
    }
}
