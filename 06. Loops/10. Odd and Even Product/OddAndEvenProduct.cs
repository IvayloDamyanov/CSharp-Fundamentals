using System;
using System.Collections.Generic;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            long odd = 1;
            long even = 1;
            for (int i = 0; i < N; i++)
            {
                long integer = long.Parse(inputArray[i]);
                if (i % 2 == 0)
                {
                    odd *= integer;
                }
                else
                {
                    even *= integer;
                }
            }
            Console.WriteLine(odd == even ? "yes {0}" : "no {0} {1}", odd, even);
        }
    }
}