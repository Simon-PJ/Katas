using System.Linq;
using Xunit;

namespace DotNetKatas.OddEvenKata
{
    public class OddEvenTests
    {
        [Fact]
        public void PrintsGivenRange()
        {
            Assert.Equal(100, GetCount(1, 100));
            Assert.Equal(39, GetCount(35, 73));
        }

        [Fact]
        public void PrintsEvenNumbers()
        {
            Assert.Equal("Even", GetNumber(2));
            Assert.Equal("Even", GetNumber(4));
            Assert.Equal("Even", GetNumber(78));
        }

        [Fact]
        public void PrintsOddNumbers()
        {
            Assert.Equal("Odd", GetNumber(9));
            Assert.Equal("Odd", GetNumber(15));
            Assert.Equal("Odd", GetNumber(75));
        }

        [Fact]
        public void PrintsPrimeNumbers()
        {
            Assert.Equal("3", GetNumber(3));
            Assert.Equal("5", GetNumber(5));
            Assert.Equal("7", GetNumber(7));
            Assert.Equal("41", GetNumber(41));
            Assert.Equal("97", GetNumber(97));
        }

        private int GetCount(int min, int max)
        {
            var result = OddEven.Print(min, max);
            var numbers = result.Split(' ');

            return numbers.Length;
        }

        private string GetNumber(int number)
        {
            return OddEven.PrintNumber(number);
        }
    }
}
