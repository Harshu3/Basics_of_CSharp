using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class EvenOrOddNumbers
    {
        public static string FindEvenOrOdd(int number)
        {
            if (number % 2 == 0)
                //Console.WriteLine("{0} is Even Number ", number);
                return "Given number is Even";
            else
                return "Given number is Odd";
        }
    }
}
