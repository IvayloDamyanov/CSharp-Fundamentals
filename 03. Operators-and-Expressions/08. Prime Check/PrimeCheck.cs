using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (N < 2)
            {
                isPrime = false;
            }
            if (isPrime == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
