using System;

namespace N_thBit
{
    class NthBit
    {
        static void Main()
        {
            long P = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int mask = 1 << N;
            P = P & mask;
            P = P >> N;
            Console.WriteLine(P);
        }
    }
}
