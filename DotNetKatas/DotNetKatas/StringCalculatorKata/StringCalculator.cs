using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetKatas.StringCalculatorKata
{
    class StringCalculator
    {
        const string ExceptionMessage = "negatives not allowed";

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

            return GetSum(numbers, delimeters);
        }

        private static int GetSum(string numbers, char[] delimeters)
        {
            var splitNumbers = numbers.Split(delimeters);

            var sum = 0;

            var negativeNumbers = new List<int>();

            foreach (var num in splitNumbers)
            {
                var intNum = Convert.ToInt32(num);

                if (intNum < 0)
                    negativeNumbers.Add(intNum);

                sum += intNum;
            }

            if (negativeNumbers.Count > 0)
                throw new Exception($"{ExceptionMessage}: {string.Join(",", negativeNumbers)}");

            return sum;
        }
    }
}
