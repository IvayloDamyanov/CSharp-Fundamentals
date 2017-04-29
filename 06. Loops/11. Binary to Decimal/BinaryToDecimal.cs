using System;
using System.Collections.Generic;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] binaryArray = input.ToCharArray();
            int[] intBinaryArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intBinaryArray[i] = Convert.ToInt32(binaryArray[i].ToString());
            }
            long output = 0;
            for (int i = input.Length; i > 0 ; i--)
            {
                output += (intBinaryArray[input.Length-i] * (long)Math.Pow(2, i-1));
            }
            Console.WriteLine(output);
        }
    }
}
