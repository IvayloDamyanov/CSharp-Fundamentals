using System;
using System.Collections.Generic;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            List<char> list = new List<char>();
            while (input > 0)
            {
                long remainder = input % 16;
                switch (remainder)
                {
                    case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9:
                        list.Add((char)(remainder+48));
                        break;
                    case 10:
                        list.Add('A');
                        break;
                    case 11:
                        list.Add('B');
                        break;
                    case 12:
                        list.Add('C');
                        break;
                    case 13:
                        list.Add('D');
                        break;
                    case 14:
                        list.Add('E');
                        break;
                    case 15:
                        list.Add('F');
                        break;
                    default:
                        break;
                }
                input /= 16;
            }
            char[] temp = list.ToArray();
            char[] array = new char[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                array[temp.Length - i - 1] = temp[i];
            }
            string output = string.Join("", array);
            Console.WriteLine(output);

        }
    }
}
