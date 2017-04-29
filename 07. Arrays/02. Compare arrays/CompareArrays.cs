using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array1 = new int[number];
            int[] array2 = new int[number];
            bool check = true;
            for (int i = 0; i < number; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                check = array1[i] == array2[i];
                if (check == false)
                {
                    goto end;
                }
            }
            end:
            Console.WriteLine(check == true ? "Equal" : "Not equal");
        }
    }
}