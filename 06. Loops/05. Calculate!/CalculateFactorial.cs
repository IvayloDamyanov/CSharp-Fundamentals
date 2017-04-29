using System;

namespace Calculate
{
    class CalculateFactorial
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 1;
            double factorial = 1;
            for (byte i = 1; i <= N; i++)
            {
                result += (factorial / Math.Pow(x, i));
                factorial = factorial * (i+1);
            }
            Console.WriteLine("{0:0.00000}", result);
        }
    }
}