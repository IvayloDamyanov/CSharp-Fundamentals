using System;
using System.Collections.Generic;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            for (byte i = 1; i <= N; i++)
            {
                List<int> list = new List<int>();
                for (byte j = i; j <= N+i-1; j++)
                {
                    list.Add(j);
                }
                int[] array = list.ToArray();
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
