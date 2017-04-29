using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int countMax = 0;
            int number = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 1; i <= max; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (array[j] == i)
                    {
                        count++;
                    }
                }
                if (count > countMax)
                {
                    countMax = count;
                    number = i;
                }
            }
            Console.WriteLine("{0} ({1} times)", number, countMax);
        }
    }
}
