using BasicCSharpPrograms.Passing_Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public static void StudentDataManupulation()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { StudentId = 3, StudentName = "Jay", PhoneNumber = 654798654, Address = "Mumbai" },
                new Student() { StudentId = 6, StudentName = "Kalpana", PhoneNumber = 845136689, Address = "Delhi" },
                new Student() { StudentId = 7, StudentName = "Suresh", PhoneNumber = 754688248, Address = "Banglore" }
            };

            Student s = new Student() { StudentId = 1, StudentName = "Harsh", PhoneNumber = 987654784, Address = "Chanda" };
            students.Add(s);
            students.Add(new Student() { StudentId = 4, StudentName = "John", PhoneNumber = 968574394, Address = "Pune" });
            //students.RemoveAt(2);

            foreach (Student student in students)
            {
                Console.WriteLine("Name:{0} ID:{1} Phone:{2} Address:{3}", student.StudentName, student.StudentId, student.PhoneNumber, student.Address);
            }

            Console.WriteLine("Please enter student name to delete from collection");
            string name = Console.ReadLine();
            bool isPresent = false;
            foreach (Student student in students)
            {
                if (student.StudentName.Equals(name))
                {
                    Console.WriteLine("Student is present so removing");
                    students.Remove(student);
                    isPresent = true;
                    Console.WriteLine("\nAfter remove operation");
                    break;
                }
            }
            if (!isPresent)
            {
                Console.WriteLine("Student not exist please provide proper name");
            }

            foreach (Student student in students)
            {
                Console.WriteLine("Name:{0} ID:{1} Phone:{2} Address:{3}", student.StudentName, student.StudentId, student.PhoneNumber, student.Address);
            }

            StudentupdateDetails(students);
        }

        public static void StudentupdateDetails(List<Student> list)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please specify which student to update");
            string name = Console.ReadLine();
            bool isPresent = false;
            foreach (Student s in list)
            {
                if (s.StudentName.Equals(name))
                {
                    isPresent = true;
                    Console.WriteLine("Name:{0} ID:{1} Phone:{2} Address:{3}", s.StudentName, s.StudentId, s.PhoneNumber, s.Address);

                    Console.WriteLine("Please select which details you want to update");
                    Console.WriteLine("1.StudentID\n2.Phone\n3.Address");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("please enter studentID");
                            s.StudentId = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("please enter phone number");
                            s.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("please enter address");
                            s.Address = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("After update");
                    Console.WriteLine("Name:{0} ID:{1} Phone:{2} Address:{3}", s.StudentName, s.StudentId, s.PhoneNumber, s.Address);
                }
            }

            if (!isPresent)
            {
                Console.WriteLine("Student not exist");
            }
        }
    }
}
