using System;
using System.Linq;

namespace DotNetKatas.CalcStatsKata
{
    class CalcStats
    {
        internal static Stats Calc(int[] input)
        {
            var min = GetMin(input);
            var max = GetMax(input);
            var count = input.Length;
            var average = GetAverage(input);

            return new Stats(min, max, count, average);
        }

        private static int GetMin(int[] input)
        {
            return GetStat(input, (x, y) => x < y);
        }

        private static int GetMax(int[] input)
        {
            return GetStat(input, (x, y) => x > y);
        }

        private static int GetStat(int[] input, Func<int, int, bool> comparison)
        {
            var stat = input[0];

            for (var i = 1; i < input.Length; i++)
            {
                var num = input[i];

                if (comparison(num, stat))
                    stat = num;
            }

            return stat;
        }

        private static decimal GetAverage(int[] input)
        {
            decimal sum = input.Sum();

            return sum / input.Length;
        }
    }

    class Stats
    {
        public int Min { get; }
        public int Max { get; }
        public int Count { get; }
        public decimal Average { get; }

        public Stats(int min, int max, int count, decimal average)
        {
            Min = min;
            Max = max;
            Count = count;
            Average = average;
        }
    }
}
