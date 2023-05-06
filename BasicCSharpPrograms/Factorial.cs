using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class Factorial
    {
        public static void FindFactorial(int number)
        {
            int product = 1;
            int input = number;
            //while (number != 0)
            //{
            //    product = product * number;
            //    number = number - 1;
            //}
            for (int i = number; i > 0; i--)
            {
                product = product * i;
            }
            Console.WriteLine("Factorial of {0}! is: {1}", input, product);
        }

        public static int FindFactorialUsingRecursion(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * FindFactorialUsingRecursion(number - 1);
        }
    }
}
