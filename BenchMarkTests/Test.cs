using BenchmarkDotNet.Attributes;
using System.Text.RegularExpressions;

namespace BenchMarkTests
{
    [MemoryDiagnoser]
    public class Test
    {
        private string _name = "pwgjb245625467sdfgljb0578ewgh54whRWTHJFFGNSFGNSFDGH94034567sde;kbgnj$%^@#%$YHU@%^Q";

        [Benchmark(Baseline = true)]
        public bool Alphanumeric() =>
            new Regex("^[a-zA-Z0-9]+$").Match(_name).Success;

        [Benchmark]
        public bool My_Alphanumeric()
        {
            if (_name == String.Empty)
                return false;
            else
            {
                var charArr = _name.ToLower().ToCharArray();
                foreach (var item in charArr)
                {
                    if (!(item >= 97 && item <= 122 || item >= 48 && item <= 57))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
