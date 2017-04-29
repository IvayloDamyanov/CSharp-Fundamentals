using System;
using System.Linq;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            array = array.OrderByDescending(i => i).ToArray();
            for (int i = 0; i < K; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
