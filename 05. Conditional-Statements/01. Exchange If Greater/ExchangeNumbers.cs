using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = 0;
            if (A > B)
            {
                C = B;
                B = A;
                A = C;
            }
            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
