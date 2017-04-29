using System;
using System.Collections.Generic;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
