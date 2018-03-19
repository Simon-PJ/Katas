using System.Collections.Generic;
using Xunit;
using static DotNetKatas.PrimeFactorsKata.PrimeFactors;

namespace DotNetKatas.PrimeFactorsKata
{
    public class PrimeFactorsTests
    {
        private List<int> List(params int[] ints)
        {
            var list = new List<int>();

            foreach (var i in ints)
            {
                list.Add(i);
            }

            return list;
        }

        [Fact]
        public void TestOne()
        {
            Assert.Equal(List(), Generate(1));
        }

        [Fact]
        public void TestTwo()
        {
            Assert.Equal(List(2), Generate(2));
        }

        [Fact]
        public void TestThree()
        {
            Assert.Equal(List(3), Generate(3));
        }

        [Fact]
        public void TestFour()
        {
            Assert.Equal(List(2, 2), Generate(4));
        }

        [Fact]
        public void TestSix()
        {
            Assert.Equal(List(2, 3), Generate(6));
        }

        [Fact]
        public void TestEight()
        {
            Assert.Equal(List(2, 2, 2), Generate(8));
        }

        [Fact]
        public void TestNine()
        {
            Assert.Equal(List(3, 3), Generate(9));
        }
    }
}
