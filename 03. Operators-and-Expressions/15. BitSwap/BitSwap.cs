using System;

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte q = byte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            double kMask = Math.Pow(2, k) - 1;
            uint firstMask = (uint)kMask << q;
            firstMask = n & firstMask;
            firstMask >>= q;
            firstMask <<= p;
            uint secondMask = (uint)kMask << p;
            secondMask = n & secondMask;
            secondMask >>= p;
            secondMask <<= q;
            n &= ~((uint)kMask << p);
            n &= ~((uint)kMask << q);
            n |= firstMask;
            n |= secondMask;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine(n);
        }
    }
}
