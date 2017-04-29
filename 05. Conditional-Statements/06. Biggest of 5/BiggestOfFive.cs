using System;

namespace BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double result = a;
            if (b > result)
            {
                result = b;
            }
            if (c > result)
            {
                result = c;
            }
            if (d > result)
            {
                result = d;
            }
            if (e > result)
            {
                result = e;
            }
            Console.WriteLine(result);
        }
    }
}
