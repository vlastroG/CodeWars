using BenchmarkDotNet.Attributes;

namespace BenchMarkTests
{
    [MemoryDiagnoser]
    public class RemoveArrItemsTest
    {
        private object[] _objs = new object[10000];

        [Benchmark(Baseline = true)]
        public object[] RemoveEveryOther()
        {
            return _objs.Where((e, i) => i % 2 == 0).ToArray();
        }

        [Benchmark]
        public object[] MyRemoveEveryOther()
        {
            List<object> result = new List<object>();
            for (int i = 0; i < _objs.Length; i++)
            {
                if (i % 2 == 0)
                    result.Add(_objs[i]);
            }
            return result.ToArray();
        }
    }
}
