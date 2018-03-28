using Xunit;

namespace DotNetKatas.CalcStatsKata
{
    public class CalcStatsTests
    {
        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 1)]
        [InlineData(new[] { 3, 6, 8 }, 3)]
        [InlineData(new[] { 7, 4, 10, 11 }, 4)]
        [InlineData(new[] { 6, 9, 15, -2, 92, 11 }, -2)]
        public void CalculatesMinValue(int[] input, int expected)
        {
            Assert.Equal(expected, CalcStats.Calc(input).Min);
        }

        [Theory]
        [InlineData(new[] { 12 }, 12)]
        [InlineData(new[] { 7, 2 }, 7)]
        [InlineData(new[] { 9, 22, 1, 14 }, 22)]
        [InlineData(new[] { 6, 9, 15, -2, 92, 11 }, 92)]
        public void CalculatesMaxValue(int[] input, int expected)
        {
            Assert.Equal(expected, CalcStats.Calc(input).Max);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 22, 32 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
        [InlineData(new[] { 6, 9, 15, -2, 92, 11 }, 6)]
        public void CountsElementsInSequence(int[] input, int expected)
        {
            Assert.Equal(expected, CalcStats.Calc(input).Count);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2, 3 }, 2)]
        [InlineData(new[] { -5, 7, 2, 3 }, 1.75)]
        [InlineData(new[] { 3, 77, -24, 67, -77 }, 9.2)]
        public void CalculatesAverage(int[] input, decimal expected)
        {
            Assert.Equal(expected, CalcStats.Calc(input).Average);
        }
    }
}
