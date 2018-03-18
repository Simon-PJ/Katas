using System.Linq;
using Xunit;

namespace DotNetKatas.OddEvenKata
{
    public class OddEvenTests
    {
        [Fact]
        public void PrintsNumbersOneToOneHundred()
        {
            var result = OddEven.Print();
            var numbers = result.Split(' ');

            Assert.Equal(100, numbers.Length);
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

        private string GetNumber(int number)
        {
            var result = OddEven.Print();
            var numbers = result.Split(' ');

            return numbers[number - 1];
        }
    }
}
