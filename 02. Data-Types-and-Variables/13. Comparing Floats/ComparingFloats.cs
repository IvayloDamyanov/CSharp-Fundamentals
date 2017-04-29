using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool check = (Math.Abs(one - two) < eps);
            if (check == true)
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
