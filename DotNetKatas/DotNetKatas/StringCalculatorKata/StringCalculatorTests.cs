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

        [Fact]
        public void ManyNumbersSumCorrectly()
        {
            Assert.Equal(0, StringCalculator.Add("0,0,0,0,0"));
            Assert.Equal(10, StringCalculator.Add("1,2,3,4"));
            Assert.Equal(233, StringCalculator.Add("104,51,78"));
        }

        [Fact]
        public void WorksWithLineBreakDelimeter()
        {
            Assert.Equal(0, StringCalculator.Add("0\n0"));
            Assert.Equal(6, StringCalculator.Add("4\n2"));
            Assert.Equal(10, StringCalculator.Add("2\n1\n7"));
        }

        [Fact]
        public void WorksWithCommaAndLineBreakDelimeterMixture()
        {
            Assert.Equal(6, StringCalculator.Add("1\n2,3"));

        }

        [Fact]
        public void CustomDelimeters()
        {
            Assert.Equal(3, StringCalculator.Add(@"//;\1;2"));
            Assert.Equal(3, StringCalculator.Add(@"//.\1.2"));
            Assert.Equal(3, StringCalculator.Add(@"//t\1t2"));
            Assert.Equal(10, StringCalculator.Add(@"///\4/2/3/1"));
            Assert.Equal(10, StringCalculator.Add(@"//\\4\2\3\1"));
        }
    }
}
