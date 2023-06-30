namespace dotnet6.MathChallenges {
    //https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
    internal static class MultipliesOfThreeOrFive {
        public static int Solution(int value) {
            int result = 0;
            for (int i = 0; i < value - 1; i++) {
                int number = i + 1;
                if ((number % 3 == 0) || (number % 5 == 0)) {
                    result += number;
                }
            }
            return result;

            //best practices
            //return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
}
