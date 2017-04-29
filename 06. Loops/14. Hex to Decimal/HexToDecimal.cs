using System;
using System.Collections.Generic;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] binaryArray = input.ToCharArray();
            int[] intBinaryArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                switch (binaryArray[i])
                {
                    case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
                        intBinaryArray[i] = Convert.ToInt32(binaryArray[i].ToString());
                        break;
                    case 'A':
                        intBinaryArray[i] = 10;
                        break;
                    case 'B':
                        intBinaryArray[i] = 11;
                        break;
                    case 'C':
                        intBinaryArray[i] = 12;
                        break;
                    case 'D':
                        intBinaryArray[i] = 13;
                        break;
                    case 'E':
                        intBinaryArray[i] = 14;
                        break;
                    case 'F':
                        intBinaryArray[i] = 15;
                        break;
                    default:
                        break;
                }
            }
            long output = 0;
            for (int i = input.Length; i > 0; i--)
            {
                output += (intBinaryArray[input.Length - i] * (long)Math.Pow(16, i - 1));
            }
            Console.WriteLine(output);
        }
    }
}
