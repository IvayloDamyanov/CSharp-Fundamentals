using System;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int counter = 1;
            int counterBiggest = 0;
            bool checkBigger = false;
            for (int i = 0; i < N - 1; i++)
            {
                checkBigger = array[i] < array[i + 1];
                counter = (checkBigger == true ? counter + 1 : counter = 1);
                if (counter > counterBiggest)
                {
                    counterBiggest = counter;
                }
            }
            Console.WriteLine(counterBiggest);
        }
    }
}
