using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            ulong mask = (ulong)1 << P;
            if (v == 1)
            {
                N = N | mask;
            }
            else
            {
                N = N & ~mask;
            }
            Console.WriteLine(N);
        }
    }
}
