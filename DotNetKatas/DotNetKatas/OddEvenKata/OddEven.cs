using System;
using System.Text;

namespace DotNetKatas.OddEvenKata
{
    class OddEven
    {
        internal static string Print(int min, int max)
        {
            var output = new StringBuilder();

            for (var i = min; i <= max; i++)
            {
                output.Append($"{PrintNumber(i)} ");
            }

            return output.ToString().Trim();
        }

        internal static string PrintNumber(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else if (!IsPrime(number))
                return "Odd";
            else
                return number.ToString();
        }

        private static bool IsPrime(int number)
        {
            for (var n = 2; n < number; n++)
            {
                if (number % n == 0)
                    return false;
            }

            return true;
        }
    }
}
