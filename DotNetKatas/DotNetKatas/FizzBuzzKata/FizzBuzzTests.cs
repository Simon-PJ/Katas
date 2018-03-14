using System;
using Xunit;

namespace DotNetKatas.FizzBuzzKata
{
    public class FizzBuzzTests
    {
        [Fact]
        public void PrintsNumbersOneToOneHundred()
        {
            var result = FizzBuzz.PrintNumbers();

            var numbers = result.Split(' ');

            Assert.Equal(100, numbers.Length);
        }

        [Fact]
        public void NonMultiplesPrintNumber()
        {
            Assert.Equal("1", FizzBuzz.PrintNumber(1));
            Assert.Equal("2", FizzBuzz.PrintNumber(2));
            Assert.Equal("4", FizzBuzz.PrintNumber(4));
            Assert.Equal("22", FizzBuzz.PrintNumber(22));

            Assert.Equal("1", GetPrintNumbersResult(1));
            Assert.Equal("2", GetPrintNumbersResult(2));
            Assert.Equal("4", GetPrintNumbersResult(4));
            Assert.Equal("22", GetPrintNumbersResult(22));
        }

        [Fact]
        public void MultiplesOfThreePrintFizz()
        {
            Assert.Equal("Fizz", FizzBuzz.PrintNumber(3));
            Assert.Equal("Fizz", FizzBuzz.PrintNumber(6));
            Assert.Equal("Fizz", FizzBuzz.PrintNumber(33));

            Assert.Equal("Fizz", GetPrintNumbersResult(3));
            Assert.Equal("Fizz", GetPrintNumbersResult(6));
            Assert.Equal("Fizz", GetPrintNumbersResult(33));
        }

        [Fact]
        public void MultiplesOfFivePrintBuzz()
        {
            Assert.Equal("Buzz", FizzBuzz.PrintNumber(5));
            Assert.Equal("Buzz", FizzBuzz.PrintNumber(10));
            Assert.Equal("Buzz", FizzBuzz.PrintNumber(20));

            Assert.Equal("Buzz", GetPrintNumbersResult(5));
            Assert.Equal("Buzz", GetPrintNumbersResult(10));
            Assert.Equal("Buzz", GetPrintNumbersResult(20));
        }

        [Fact]
        public void MultiplesOfBothThreeAndFivePrintFizzBuzz()
        {
            Assert.Equal("FizzBuzz", FizzBuzz.PrintNumber(15));
            Assert.Equal("FizzBuzz", FizzBuzz.PrintNumber(30));
            Assert.Equal("FizzBuzz", FizzBuzz.PrintNumber(90));

            Assert.Equal("FizzBuzz", GetPrintNumbersResult(15));
            Assert.Equal("FizzBuzz", GetPrintNumbersResult(30));
            Assert.Equal("FizzBuzz", GetPrintNumbersResult(90));
        }

        [Fact]
        public void GivenNumberMustBetweenOneAndOneHundred()
        {
            Assert.Throws<ArgumentException>(() => FizzBuzz.PrintNumber(0));
            Assert.Throws<ArgumentException>(() => FizzBuzz.PrintNumber(-1));
            Assert.Throws<ArgumentException>(() => FizzBuzz.PrintNumber(101));
        }

        private string GetPrintNumbersResult(int n)
        {
            var result = FizzBuzz.PrintNumbers();
            var numbers = result.Split(' ');
            return numbers[n - 1];
        }
    }
}
