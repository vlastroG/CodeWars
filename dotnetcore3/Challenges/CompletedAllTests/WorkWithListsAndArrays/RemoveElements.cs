using System.Collections.Generic;
using System.Linq;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithListsAndArrays
{
    internal static class RemoveElements
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


            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                return listOfItems.Where(s => s.GetType() == typeof(int)).Select(x => (int)x).ToList();
            }

            public static IEnumerable<int> by_Masters_GetIntegersFromList(List<object> listOfItems)
            {
                return listOfItems.OfType<int>();
            }
        }
    }
}
