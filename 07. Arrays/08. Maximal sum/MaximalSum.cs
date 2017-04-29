using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = array[0];
            int bestSum = array[0];
            for (int i = 0; i < N; i++)
            {
                sum = array[i];
                for (int j = i+1; j < N; j++)
                {
                    sum += array[j];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
