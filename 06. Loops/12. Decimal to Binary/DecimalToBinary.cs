using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(1);
                }
                input /= 2;
            }
            int[] temp = list.ToArray();
            int[] array = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                array[temp.Length - i - 1] = temp[i];
            }
            string output = string.Join("",array);
            Console.WriteLine(output);
        }
    }
}
