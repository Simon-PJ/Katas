using System.Collections.Generic;

namespace DotNetKatas.PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> Generate(int n)
        {
            var primes = new List<int>();

            for (var candidate = 2; n > 1; candidate++)
            {
                for (; n % candidate == 0; n /= candidate)
                {
                    primes.Add(candidate);
                }
            }

            return primes;
        }
    }
}
