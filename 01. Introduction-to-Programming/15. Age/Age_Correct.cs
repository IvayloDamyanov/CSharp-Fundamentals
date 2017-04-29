using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birth = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
            DateTime now = DateTime.Now;
            int age = now.Year - birth.Year;
            if (now.Month < birth.Month || now.Month == birth.Month && now.Day < birth.Day)
            {
                age--;
            }
            Console.WriteLine("{0}\n{1}", age, age+10);
        }
    }
}
