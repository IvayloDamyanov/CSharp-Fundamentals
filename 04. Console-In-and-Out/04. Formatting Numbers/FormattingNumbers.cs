using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = short.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            //string a1 = Convert.ToString(a, 16).PadLeft(10, ' ').ToUpper();
            //string a2 = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("{0, 10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
