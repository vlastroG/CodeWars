using System.Linq;

namespace dotnetcore3.Challenges
{
    internal static class ZerosToEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var result = arr.Where(num => num != 0).ToList();
            result.AddRange(Enumerable.Repeat(0, arr.Where(x => x == 0).ToArray().Count()));

            return result.ToArray();
        }

        public static int[] MoveZeroes_by_kampotE(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
