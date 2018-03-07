using Xunit;

namespace DotNetKatas.StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            Assert.Equal(0, StringCalculator.Add(""));
        }

        [Fact]
        public void SingleNumbersSumsCorrectly()
        {
            Assert.Equal(1, StringCalculator.Add("1"));
            Assert.Equal(2, StringCalculator.Add("2"));
            Assert.Equal(56, StringCalculator.Add("56"));
        }

        [Fact]
        public void TwoNumbersSumsCorrectly()
        {
            Assert.Equal(0, StringCalculator.Add("0,0"));
            Assert.Equal(1, StringCalculator.Add("0,1"));
            Assert.Equal(5, StringCalculator.Add("3,2"));
            Assert.Equal(46, StringCalculator.Add("34,12"));
        }
    }
}
