using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class ValueType
    {
        public static void PassValueTypeVariable()
        {
            int a = 10;
            ChangeValue(a);
        }

        public static void ChangeValue(int a)
        {
            Console.WriteLine("Value of 'a' before modify: " + a);
            a = a + 10;
            Console.WriteLine("Value of 'a' after modify: " + a);
        }
    }
}
