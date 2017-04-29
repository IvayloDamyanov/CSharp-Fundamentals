using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateFactorialAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            for (int i = K+1; i <= N; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine(fac);
        }
    }
}
