using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms.Passing_Parameters
{
    internal class ReferenceType
    {
        public static void PassReferenceType()
        {
            Student student = new Student();
            student.StudentId = 1;
            student.StudentName = "Harsh";
            Console.WriteLine("Before modify ID:{0} Name:{1}", student.StudentId, student.StudentName);
            ChangeValue(student);
            Console.WriteLine("After modify ID:{0} Name:{1}", student.StudentId, student.StudentName);
        }

        public static void ChangeValue(Student student)
        {
            student.StudentId = 5;
            student.StudentName = "John";
        }
    }
}
