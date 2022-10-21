using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithListsAndArrays.RangeExtraction
{
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(args[0]);
            for (int i = 1; i < args.Length; i++)
            {
                var test = args[i];
                if (args[i - 1] + 1 == args[i]
                    && i + 1 != args.Length)
                {
                    // the sequence is preserved and the current element is not the last
                    continue;
                }
                else if (args[i - 1] + 1 == args[i]
                    && i + 1 == args.Length)
                {
                    // the sequence is preserved and the current element is the last
                    if (i != 1 && args[i - 2] + 1 == args[i - 1])
                    {
                        sb.Append('-');
                    }
                    else
                    {
                        sb.Append(',');
                    }
                    sb.Append(args[i]);
                }
                else if (args[i - 1] + 1 != args[i])
                {
                    // Sequence not continued
                    if (i != 1 && args[i - 2] + 1 == args[i - 1])
                    {
                        // the sequence was previously preserved and the current element is not the second
                        if (i > 2 && args[i - 3] + 1 == args[i - 2])
                        {
                            sb.Append('-');
                        }
                        else
                        {
                            sb.Append(',');
                        }
                        sb.Append(args[i - 1]);
                        sb.Append(',');
                        sb.Append(args[i]);
                    }
                    else
                    {
                        // the sequence was not continued before and the previous condition was already satisfied
                        sb.Append(',');
                        sb.Append(args[i]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
