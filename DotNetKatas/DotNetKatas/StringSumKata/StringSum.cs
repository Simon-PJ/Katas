using System;

namespace DotNetKatas.StringSumKata
{
    public class StringSum
    {
        internal static string Sum(string num1, string num2)
        {
            var int1 = ParseNumber(num1);
            var int2 = ParseNumber(num2);

            return (int1 + int2).ToString();
        }

        internal static int ParseNumber(string num)
        {
            var parsed = int.TryParse(num, out var parsedNum);

            if (parsed && parsedNum > 0)
            {
                return parsedNum;
            }
            else
            {
                return 0;
            }
        }
    }
}
