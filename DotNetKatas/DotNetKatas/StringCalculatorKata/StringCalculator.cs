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

            var delimeters = new[] { ',', '\n' };

            if (numbers.StartsWith("//"))
            {
                delimeters = new[] { numbers[2] };

                numbers = numbers.Substring(4);
            }

            var splitNumbers = numbers.Split(delimeters);

            return splitNumbers.Sum(x => Convert.ToInt32(x));
        }
    }
}
