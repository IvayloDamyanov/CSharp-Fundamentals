using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string v = Console.ReadLine();
            switch (s)
            {
                case "integer":
                    Console.WriteLine(int.Parse(v) + 1);
                    break;
                case "real":
                    Console.WriteLine("{0:0.00}", double.Parse(v) + 1);
                    break;
                case "text":
                    Console.WriteLine("{0}*", v);
                    break;
                default:
                    break;
            }
        }
    }
}
