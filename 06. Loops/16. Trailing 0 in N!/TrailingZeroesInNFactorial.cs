using System;

namespace TrailingZeroesInNFactorial
{
    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int result = 0;
            int times = (int)Math.Log(N, 5);
            for (int i = 1; i <= times; i++)
            {
                result += (N / (int)(Math.Pow(5, i)));
            }
            Console.WriteLine(result);
        }
    }
}