using System;
using System.Linq;

namespace MatrixOfNumbersChallenge
{
    class MatrixOfNumbersChallenge
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int[] matrix = Enumerable.Range(i, N).ToArray();
                Console.WriteLine(String.Join(" ", matrix));
            }
        }
    }
}
