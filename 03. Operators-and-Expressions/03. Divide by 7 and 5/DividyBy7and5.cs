using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividyBy7and5
{
    class DividyBy7and5
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool check = (num % 7 == 0 && num % 5 == 0);
            if (check == true)
            {
                Console.WriteLine("true " + num);
            }
            else
            {
                Console.WriteLine("false " + num);
            }
        }
    }
}
