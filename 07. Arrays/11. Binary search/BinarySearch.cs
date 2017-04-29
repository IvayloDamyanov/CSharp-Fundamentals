using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());
            int output = -1;
            int iMax = N;
            int iMin = 0;
            int iOld = N+1;
            for (int i = N / 2; i < N; i=((iMax+iMin)/2))
            {
                if (iOld == i)
                {
                    goto end;
                }
                iOld = i;
                if (X < array[i])
                {
                    iMax = i;
                }
                if (X > array[i])
                {
                    iMin = i;
                }
                if (X == array[i])
                {
                    output = i;
                    goto end;
                }
            }
            end:
            Console.WriteLine(output);
        }
    }
}