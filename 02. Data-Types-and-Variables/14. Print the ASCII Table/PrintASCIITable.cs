using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
