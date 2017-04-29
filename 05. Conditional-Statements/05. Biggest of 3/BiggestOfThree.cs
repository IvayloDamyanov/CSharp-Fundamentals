using System;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result = a;
            if (b > result)
            {
                result = b;
            }
            if (c > result)
            {
                result = c;
            }
            Console.WriteLine(result);
        }
    }
}
