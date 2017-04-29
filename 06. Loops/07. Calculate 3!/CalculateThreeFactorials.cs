using System;
using System.Numerics;

namespace CalculateThreeFactorials
{
    class CalculateThreeFactorials
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger facOne = 1;
            for (int i = K + 1; i <= N; i++)
            {
                facOne *= i;
            }
            BigInteger facTwo = 1;
            for (int i = 1; i <= N - K; i++)
            {
                facTwo *= i;
            }
            Console.WriteLine(facOne/facTwo);
        }
    }
}
