using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObject
{
    class StringAndObject
    {
        static void Main(string[] args)
        {
            string one = "Hello";
            string two = "World";
            object three = one + " " + two;
            string four = (string)three;
            //Console.WriteLine(four);
        }
    }
}
