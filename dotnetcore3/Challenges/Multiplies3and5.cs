using System.Linq;

namespace dotnetcore3.Challenges
{
    internal static class Multiplies3and5
    {
        public static int Solution(int value)
        {
            var sum = 0;
            if (value < 3) return 0;
            else
            {
                for (int i = 3; i < value; i++)
                {
                    if ((i % 3 == 0) && (i % 5 != 0)
                        || (i % 3 != 0) && (i % 5 == 0)
                        || (i % 3 == 0) && (i % 5 == 0))
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        public static int Solution_by_mansyfan(int n)
        {
            return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
}
