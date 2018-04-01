namespace DotNetKatas.GameOfLifeKata
{
    class GameOfLife
    {
        internal static char[,] NextGeneration(char[,] input)
        {
            var nextGen = new char[input.GetLength(0), input.GetLength(1)];

            for (var i = 0; i < input.GetLength(0); i++)
            {
                for (var j = 0; j < input.GetLength(1); j++)
                {
                    var neighbours = NeighbourCount(input, i, j);

                    if (neighbours == 3)
                        nextGen[i, j] = '*';
                    else if (neighbours > 3 || neighbours < 2)
                        nextGen[i, j] = '.';
                    else
                        nextGen[i, j] = input[i, j];
                }
            }

            return nextGen;
        }

        private static int NeighbourCount(char[,] input, int i, int j)
        {
            int count = 0;

            if (j - 1 >= 0 && input[i, j - 1] == '*')
                count++;

            if (i - 1 >= 0 && input[i - 1, j] == '*')
                count++;

            if (j + 1 < input.GetLength(1) && input[i, j + 1] == '*')
                count++;

            if (i + 1 < input.GetLength(0) && input[i + 1, j] == '*')
                count++;

            return count;
        }
    }
}
