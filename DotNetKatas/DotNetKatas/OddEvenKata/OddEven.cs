using System;
using System.Text;

namespace DotNetKatas.OddEvenKata
{
    class OddEven
    {
        internal static string Print()
        {
            var output = new StringBuilder();

            for (var i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    output.Append($"Even ");
                else
                    output.Append($"{i} ");
            }

            return output.ToString().Trim();
        }
    }
}
