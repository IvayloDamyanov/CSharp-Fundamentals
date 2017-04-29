using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            char result;
            if (a == 0 || b == 0 || c == 0)
            {
                result = '0';
            }
            else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                result = '-';
            }
            else
            {
                result = '+';
            }
            Console.WriteLine(result);
        }
    }
}
