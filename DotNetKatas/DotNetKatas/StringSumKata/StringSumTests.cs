using Xunit;

namespace DotNetKatas.StringSumKata
{
    public class StringSumTests
    {
        [Fact]
        public void SumsCorrectly()
        {
            Assert.Equal("0", StringSum.Sum("0", "0"));
            Assert.Equal("2", StringSum.Sum("1", "1"));
            Assert.Equal("3", StringSum.Sum("1", "2"));
            Assert.Equal("4", StringSum.Sum("2", "2"));
            Assert.Equal("91", StringSum.Sum("24", "67"));
        }

        [Fact]
        public void InvalidArgumentsResultsInZero()
        {
            Assert.Equal("0", StringSum.Sum("a", "b"));
            Assert.Equal("0", StringSum.Sum("~", "£"));
            Assert.Equal("0", StringSum.Sum("-4", "-2"));
            Assert.Equal("0", StringSum.Sum(null, null));
            Assert.Equal("0", StringSum.Sum("", ""));
        }

        [Fact]
        public void OneInvalidArgumentResultsInTheSecondValue()
        {
            Assert.Equal("14", StringSum.Sum("-5", "14"));
            Assert.Equal("45", StringSum.Sum("45", null));

        }
    }
}
