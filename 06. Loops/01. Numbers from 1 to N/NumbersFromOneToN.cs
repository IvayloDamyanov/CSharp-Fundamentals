﻿using System;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i);
                if (i<N)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
