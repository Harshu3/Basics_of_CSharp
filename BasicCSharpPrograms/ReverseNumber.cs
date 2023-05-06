using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class ReverseNumber
    {
        public static void FindReverse(int number)
        {
            int reverse = 0;
            //exmaple 567
            while (number != 0)
            {
                int remainder = number % 10;
                reverse= (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("After Reverse: " + reverse);
        }
    }
}
