using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            float w = float.Parse(Console.ReadLine());
            w = w*0.17f;
            Console.WriteLine("{0:0.000}", w);
        }
    }
}
