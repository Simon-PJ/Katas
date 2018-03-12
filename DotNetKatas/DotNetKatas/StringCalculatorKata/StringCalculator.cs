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

            var delimeters = new[] { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                if (numbers.Contains("[") && numbers.Contains("]"))
                {
                    var firstSquareBracket = numbers.IndexOf('[');
                    var secondSquareBracket = numbers.IndexOf(']');
                    var delimeter = numbers.Substring(firstSquareBracket + 1, secondSquareBracket - firstSquareBracket - 1);

                    delimeters = new[] { delimeter };

                    numbers = numbers.Substring(secondSquareBracket + 2);
                }
                else
                {
                    delimeters = new[] { numbers[2].ToString() };

                    numbers = numbers.Substring(4);
                }
            }

            return GetSum(numbers, delimeters);
        }

        private static int GetSum(string numbers, string[] delimeters)
        {
            var splitNumbers = numbers.Split(delimeters, StringSplitOptions.None);

            var sum = 0;

            var negativeNumbers = new List<int>();

            foreach (var num in splitNumbers)
            {
                var intNum = Convert.ToInt32(num);

                if (intNum < 0)
                    negativeNumbers.Add(intNum);

                if (intNum < 1000)
                    sum += intNum;
            }

            if (negativeNumbers.Count > 0)
                throw new Exception($"{ExceptionMessage}: {string.Join(",", negativeNumbers)}");

            return sum;
        }
    }
}
