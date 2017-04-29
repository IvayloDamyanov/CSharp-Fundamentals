using System;
using System.Collections.Generic;

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            ushort N = ushort.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (ushort i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    list.Add(i);
                }
            }
            int[] array = list.ToArray();
            Console.Write(string.Join(" ", array));
        }
    }
}
