using BasicCSharpPrograms.Passing_Parameters;
using BasicCSharpPrograms.Types_of_Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options:");
            Console.WriteLine("1.Even or Odd\n2.Prime or not\n3.Reverse\n4.Array Concept\n5.Factorial\n6.String Reverse\n7.ValueType\n8.ReferenceType\n9.List Collection\n10.Local Variable\n11.Instance Variable");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter integer number to find Even or Odd");
                    int input = Convert.ToInt32(Console.ReadLine());
                    string res = EvenOrOddNumbers.FindEvenOrOdd(input);
                    Console.WriteLine(res);
                    break;
                case 2:
                    Console.WriteLine("Please enter integer number to find Prime or not");
                    input = Convert.ToInt32(Console.ReadLine());
                    PrimeOrNot.FindPrimeNumber(input);
                    break;
                case 3:
                    Console.WriteLine("Please enter integer number to Reverse it");
                    input = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.FindReverse(input);
                    break;
                case 4:
                    ArrayConcept arrayConcept = new ArrayConcept();
                    arrayConcept.ReadArrayElements();
                    arrayConcept.DisplayArrayElements();
                    break;
                case 5:
                    Console.WriteLine("Enter number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    //Factorial.FindFactorial(n);
                    Console.WriteLine("Fcatorail is: " + Factorial.FindFactorialUsingRecursion(n));
                    break;
                case 6:
                    Console.WriteLine("Please enter a statement");
                    string s = Console.ReadLine();
                    StringReverse.MakeReverse(s);
                    //StringReverse.MakeReverseUsingBuiltIn(s);
                    StringReverse.MakeEachWordReverse(s);
                    break;
                case 7:
                    ValueType.PassValueTypeVariable();
                    break;
                case 8:
                    ReferenceType.PassReferenceType();
                    break;
                case 9:
                    Student.StudentDataManupulation();
                    break;
                case 10:
                    StudentDetails.StudentAge();
                    break;
                case 11:
                    Console.WriteLine("Instance variable concept");
                    Marks marks = new Marks();
                    marks.physics = 50;
                    marks.maths = 80;
                    marks.GetMarks();
                    Marks marks2 = new Marks();
                    marks2.physics = 70;
                    marks2.maths = 90;
                    marks2.GetMarks();

                    Console.WriteLine("\nStatic variable concept");
                    EmployeeDetails.companyName = "Deloitte";
                    EmployeeDetails details = new EmployeeDetails("Harshita", 987654321);
                    details.EmployeeData();
                    break;
                default:
                    Console.WriteLine("Please choose within given options");
                    break;
            }
        }
    }
}