using System.Collections.Generic;
using Xunit;

namespace DotNetKatas.GameOfLifeKata
{
    public class GameOfLifeTests
    {
        /// <summary>
        /// Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
        /// </summary>
        [Theory]
        [MemberData(nameof(RuleOneInputs))]
        public void RuleOneIsSatisfied(char[,] input, char[,] expectedOutput)
        {
            Assert.True(ArraysEqual(expectedOutput, GameOfLife.NextGeneration(input)));
        }

        /// <summary>
        /// Any live cell with more than three live neighbours dies, as if by overcrowding.
        /// </summary>
        [Theory]
        [MemberData(nameof(RuleTwoInputs))]
        public void RuleTwoIsSatisfied(char[,] input, char[,] expectedOutput)
        {
            Assert.True(ArraysEqual(expectedOutput, GameOfLife.NextGeneration(input)));
        }

        /// <summary>
        /// Any live cell with two or three live neighbours lives on to the next generation.
        /// </summary>
        [Theory]
        [MemberData(nameof(RuleThreeInputs))]
        public void RuleThreeIsSatisfied(char[,] input, char[,] expectedOutput)
        {
            Assert.True(ArraysEqual(expectedOutput, GameOfLife.NextGeneration(input)));
        }

        /// <summary>
        /// Any dead cell with exactly three live neighbours becomes a live cell
        /// </summary>
        [Theory]
        [MemberData(nameof(RuleFourInputs))]
        public void RuleFourIsSatisfied(char[,] input, char[,] expectedOutput)
        {
            Assert.True(ArraysEqual(expectedOutput, GameOfLife.NextGeneration(input)));
        }

        private bool ArraysEqual(char[,] expected, char[,] actual)
        {
            if (expected.Length != actual.Length && expected.LongLength != actual.LongLength)
                return false;

            for (var i = 0; i < expected.GetLength(0); i++)
            {
                for (var j = 0; j < expected.GetLength(1); j++)
                {
                    if (expected[i, j] != actual[i, j])
                        return false;
                }
            }

            return true;
        }

        public static IEnumerable<object[]> RuleOneInputs =>
            new List<object[]> {
                new object[] { new char[,] { { '*' }, { '.' } }, new char[,] { { '.' }, { '.' } } },
                new object[] { new char[,] { { '.', '.', '.' }, { '.', '*', '.' }, { '.', '.', '.' } }, new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } } },
                new object[] { new char[,] { { '.', '.', '.' }, { '.', '*', '.' }, { '.', '.', '.' } }, new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } } },
                new object[] { new char[,] { { '.', '*', '.' }, { '.', '*', '.' }, { '.', '.', '.' } }, new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } } }
            };

        public static IEnumerable<object[]> RuleTwoInputs =>
            new List<object[]> {
                new object[] { new char[,] { { '.', '*', '.' }, { '*', '*', '*' }, { '.', '*', '.' } }, new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } } }
            };

        public static IEnumerable<object[]> RuleThreeInputs =>
           new List<object[]> {
                new object[] { new char[,] { { '*', '*', '*' } }, new char[,] { { '.', '*', '.' } } },
                new object[] { new char[,] { { '*', '*', '*' }, { '.', '*', '.' }}, new char[,] { { '.', '*', '.' }, { '.', '.', '.' } } }
           };

        public static IEnumerable<object[]> RuleFourInputs =>
            new List<object[]> {
                new object[] { new char[,] { { '.', '*', '.' }, { '*', '.', '*' }}, new char[,] { { '.', '.', '.' }, { '.', '*', '.' } } }
            };
    }
}
