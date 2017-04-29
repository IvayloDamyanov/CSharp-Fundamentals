using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                int min = numbers[i];
                for (int j = i; j < N; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = min;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
