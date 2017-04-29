using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger fac1 = 1;
            for (int i = 1; i <= 2*N; i++)
            {
                fac1 *= i;
            }
            BigInteger fac2 = 1;
            for (int i = 1; i <= N+1; i++)
            {
                fac2 *= i;
            }
            BigInteger fac3 = 1;
            for (int i = 1; i <= N; i++)
            {
                fac3 *= i;
            }
            Console.WriteLine(fac1/(fac2*fac3));
        }
    }
}