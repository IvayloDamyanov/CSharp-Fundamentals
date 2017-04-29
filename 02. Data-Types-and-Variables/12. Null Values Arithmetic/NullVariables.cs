using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVariables
{
    class NullVariables
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("{0}\n{1}", a, b);
            a = a + 1;
            b = b + 0.1;
            Console.WriteLine("{0}\n{1}", a, b);
        }
    }
}
