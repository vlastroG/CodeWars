using System.Collections.Generic;
using System.Linq;

namespace dotnetcore3.Challenges
{
    internal static class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains(array1[i]))
                    {
                        result.Add(array1[i]);
                        break;
                    }
                }
            }
            result.Sort();

            return result.ToArray();
        }

        public static string[] inArray_by_AlexFridman(string[] array1, string[] array2)
        {
            return array1.Distinct()
                         .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                         .OrderBy(s => s)
                         .ToArray();
        }
    }
}
