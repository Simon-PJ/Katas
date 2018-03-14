using System;
using System.Text;

namespace DotNetKatas.FizzBuzzKata
{
    class FizzBuzz
    {
        private const int MinNumber = 1;
        private const int MaxNumber = 100;

        internal static string PrintNumbers()
        {
            var output = new StringBuilder();

            for (var i = MinNumber; i <= MaxNumber; i++)
            {
                output.Append($"{PrintNumber(i)} ");
            }

            return output.ToString().TrimEnd();
        }

        internal static string PrintNumber(int number)
        {
            if (number < MinNumber || number > MaxNumber)
                throw new ArgumentException();

            if (number % 15 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
