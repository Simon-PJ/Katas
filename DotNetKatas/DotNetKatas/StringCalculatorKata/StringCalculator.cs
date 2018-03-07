using System;
using System.Linq;

namespace DotNetKatas.StringCalculatorKata
{
    class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var splitNumbers = numbers.Split(',', '\n');

            return splitNumbers.Sum(x => Convert.ToInt32(x));
        }
    }
}
