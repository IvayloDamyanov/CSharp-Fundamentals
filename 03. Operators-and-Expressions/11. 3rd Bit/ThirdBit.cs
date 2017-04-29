using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            n = n & mask;
            n >>= p;
            Console.WriteLine(n);
        }
    }
}
