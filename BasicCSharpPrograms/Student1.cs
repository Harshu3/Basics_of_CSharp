using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    internal class Student1
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public static void StudentDataManulation()
        {
            Student1 s = new Student1() { StudentId = 1, StudentName = "Harsh", PhoneNumber = 987654, Address = "Chanda" };
            //list object creation
            List<Student1> students = new List<Student1>();

            //using add method to store objects into list
            students.Add(s);
            students.Add(new Student1() { StudentId = 4, StudentName = "John", PhoneNumber = 968574, Address = "Pune" });

            foreach (Student1 item in students)
            {
                Console.WriteLine("Name:{0} ID:{1} Phone:{2} Address:{3}", item.StudentName, item.StudentId, item.PhoneNumber, item.Address);
            }
        }
    }
}
