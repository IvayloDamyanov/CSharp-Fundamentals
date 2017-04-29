using System;
using System.Numerics;

namespace MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverageOfNNumbers
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double max = min;
            double sum = min;
            double avg = min/N;
            for (int i = 1; i < N; i++)
            {
                double j = double.Parse(Console.ReadLine());
                if (j < min)
                {
                    min = j;
                }
                if (j > max)
                {
                    max = j;
                }
                sum += j;
            }
            avg = sum / N;
            Console.WriteLine("min={0:0.00}\nmax={1:0.00}\nsum={2:0.00}\navg={3:0.00}", min, max, sum, avg);
        }
    }
}
