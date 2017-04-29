using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            N = N / 100;
            N = N % 10;
            if (N == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false "+N);
            }
        }
    }
}
