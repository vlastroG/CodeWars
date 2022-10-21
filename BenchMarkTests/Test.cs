using BenchmarkDotNet.Attributes;
using System.Text.RegularExpressions;
using dotnetcore3.Challenges.CompletedAllTests.WorkWithMath;

namespace BenchMarkTests
{
    [MemoryDiagnoser]
    [WarmupCount(1)]
    [IterationCount(10)]
    public class Test
    {
        private int[] _num = new int[1000000];

        [Benchmark]
        public int[]? UpArray()
        {
            int[] num = _num;
            if (num.Length == 0 || num.Any(a => a < 0 || a > 9))
                return null;

            for (var i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == 9)
                {
                    num[i] = 0;
                }
                else
                {
                    num[i]++;
                    return num;
                }
            }
            return new[] { 1 }.Concat(num).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int[]? My_UpArray()
        {
            return UpArrayKata.UpArray(_num);
        }
    }
}
