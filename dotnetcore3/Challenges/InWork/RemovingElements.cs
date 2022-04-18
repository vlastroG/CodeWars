using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnetcore3.Challenges.InWork
{
    internal static class RemovingElements
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> result = new List<object>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static object[] byMaster_RemoveEveryOther(object[] arr)
        {
            return arr.Where((e, i) => i % 2 == 0).ToArray();
        }
    }
}
