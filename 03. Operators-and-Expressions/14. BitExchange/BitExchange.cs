using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            double mask = Math.Pow(2, 3) - 1;
            uint firstMask = (uint)mask << 3;
            firstMask = N & firstMask;
            firstMask >>= 3;
            firstMask <<= 24;
            uint secondMask = (uint)mask << 24;
            secondMask = N & secondMask;
            secondMask >>= 24;
            secondMask <<= 3;
            N = N & (~((uint)mask << 3));
            N = N & (~((uint)mask << 24));
            N = N | firstMask;
            N = N | secondMask;
            Console.WriteLine(N);
        }
    }
}
