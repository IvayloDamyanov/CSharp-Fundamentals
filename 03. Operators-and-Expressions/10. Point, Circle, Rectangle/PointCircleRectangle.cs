using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double top = 1;
            double left = -1;
            double width = 6;
            double height = 2;
            double a = x - 1;
            double b = y - 1;
            double c = Math.Sqrt(a * a + b * b);
            string inCircle = "outside circle";
            if (c <= 1.5)
            {
                inCircle = "inside circle";
            }
            double bot = top - height;
            double right = left + width;
            string outRect = "outside rectangle";
            if (x <= right && x >= left && y <= top && y >= bot)
            {
                outRect = "inside rectangle";
            }
            Console.WriteLine("{0} {1}", inCircle, outRect);
        }
    }
}
