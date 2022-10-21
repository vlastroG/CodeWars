using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore3.Challenges.CompletedAllTests.WorkWithMath
{
    public class UpArrayKata
    {
        public static int[] UpArray(int[] num)
        {
            if (!ValidateInput(num)) return null;

            bool onlyCheck = false;
            for (int i = 1; i <= num.Length; i++)
            {
                if (!onlyCheck)
                {
                    num[^i] += 1;
                    if (num[^i] >= 1 && num[^i] <= 10)
                    {
                        if (num[^i] == 10)
                        {
                            num[^i] = 0;
                            if (i == num.Length)
                            {
                                var listInt = new List<int> { 1 };
                                listInt.AddRange(num);
                                return listInt.ToArray();
                            }
                        }
                        else
                        {
                            onlyCheck = true;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (num[^i] < 0 || num[^i] > 9)
                    {
                        return null;
                    }
                }
            }
            return num;
        }

        private static bool ValidateInput(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
