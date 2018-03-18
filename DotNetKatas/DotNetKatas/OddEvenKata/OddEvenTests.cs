using System.Linq;
using Xunit;

namespace DotNetKatas.OddEvenKata
{
    public class OddEvenTests
    {
        [Fact]
        public void PrintsNumbersOneToOneHundred()
        {
            var result   = OddEven.Print();
            var numbers = result.Split(' ');

            Assert.Equal(100, numbers.Length);
        }
    }
}
