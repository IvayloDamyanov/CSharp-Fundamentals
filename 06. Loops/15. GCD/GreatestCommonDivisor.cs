using System;
using System.Collections.Generic;
using System.Numerics;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int A = int.Parse(split[0]);
            int B = int.Parse(split[1]);
            int greater = (A >= B ? A : B);
            int smaller = (A <= B ? A : B);
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = greater % smaller;
                greater = smaller;
                smaller = remainder;
            }
            Console.WriteLine(greater);
        }
    }
}
