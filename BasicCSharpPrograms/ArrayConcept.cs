using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class ArrayConcept
    {
        public int[] arr;

        public void ReadArrayElements()
        {
            Console.WriteLine("Please enter array size");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int k = i;
                Console.WriteLine("Please enter {0}st number", (k + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayArrayElements()
        {
            Console.WriteLine("\nDisplaying Array Elements");
            foreach (int element in arr)
            {
                Console.Write(element + " " );
            }
        }
    }
}
