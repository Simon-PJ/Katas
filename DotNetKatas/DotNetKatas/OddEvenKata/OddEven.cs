﻿using System;
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
                if (i % 2 == 0)
                    output.Append($"Even ");
                else if (i % 2 != 0 && !IsPrime(i))
                    output.Append($"Odd ");
                else
                    output.Append($"{i} ");
            }

            return output.ToString().Trim();
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
