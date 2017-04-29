using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            bool checkEqual = true;
            bool? checkArr1smaller = null;
            for (int i = 0; i < (array1.Length < array2.Length ? array1.Length : array2.Length); i++)
            {
                checkEqual = (array1[i] == array2[i]);
                if (checkEqual == false)
                {
                    checkArr1smaller = array1[i] < array2[i] ? true : false;
                    goto next1;
                }
            }
        next1:
            if (checkEqual == true && array1.Length != array2.Length)
            {
                checkEqual = false;
                checkArr1smaller = array1.Length < array2.Length ? true : false;
            }
            Console.WriteLine(checkEqual == true ? "=" : (checkArr1smaller == true ? "<" : ">"));
        }
    }
}
