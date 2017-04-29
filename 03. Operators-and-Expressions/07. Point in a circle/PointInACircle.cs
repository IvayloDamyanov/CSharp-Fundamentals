using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = Math.Sqrt(x * x + y * y);
            if (z <= 2)
            {
                Console.WriteLine("yes {0:0.00}", z);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", z);
            }
        }
    }
}
