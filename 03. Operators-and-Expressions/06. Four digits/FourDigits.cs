using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int d = num;
            int c = d / 10;
            int b = c / 10;
            int a = b / 10;
            d %= 10;
            c %= 10;
            b %= 10;
            a %= 10;
            Console.WriteLine(a+b+c+d);
            Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
        }
    }
}
