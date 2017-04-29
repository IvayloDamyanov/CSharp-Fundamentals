using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even " + num);
            }
            else
            {
                Console.WriteLine("odd "+ num);
            }
        }
    }
}
