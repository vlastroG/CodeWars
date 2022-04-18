using System;

namespace dotnetcore3.Challenges.InWork
{
    public static class NotVerySecure
    {
        public static bool Alphanumeric(string str)
        {
            if (str == String.Empty)
                return false;
            else
            {
                var charArr = str.ToLower().ToCharArray();
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
