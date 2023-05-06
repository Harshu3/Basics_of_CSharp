using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class StringReverse
    {
        public static void MakeReverse(string statement)
        {
            string result = " ";
            Console.WriteLine(" Reversing Statement");
            char[] arr = { ' ', ',', '/' };
            string[] words = statement.Split(arr);
            foreach (string w in words)
            {
                result = w +" "+ result;
            }
            Console.WriteLine(result);
        }

        public static void MakeReverseUsingBuiltIn(string statement)
        {
            char[] arr = { ' ', ',', '/' };
            string[] words = statement.Split(arr);
            string[] res = words.Reverse().ToArray();
            string result = string.Join(" ", res);
            Console.WriteLine(result);
        }

        public static void MakeEachWordReverse(string statement)
        {
            char[] arr = { ' ', ',', '/' };
            string[] words = statement.Split(arr);
            string result = "";
            //string res = "";
            Console.WriteLine(" Reversing Each Word");
            Console.WriteLine("Before Reverse: " + statement);
            for (int i = 0; i < words.Length; i++)
            {
                string actual = words[i];
                string s = "";
                for (int j = actual.Length - 1; j >= 0; j--)
                {
                    s = s + actual[j];
                    //res = s + result;
                }
                result = result + s + " ";
            }
            Console.WriteLine("After Reversing Each Word at same place: " + result);
            //Console.WriteLine("After Reversing Each Word: " + res);
        }
    }
}
