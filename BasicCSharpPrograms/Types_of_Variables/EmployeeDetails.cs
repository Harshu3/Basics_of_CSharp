using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms.Types_of_Variables
{
    internal class EmployeeDetails
    {
        public static string companyName;
        public string employeeName;
        public int phoneNumber;

        public EmployeeDetails()
        {
            Console.WriteLine("Default constructor");
        }
        public EmployeeDetails(string name, int phone)
        {
            employeeName = name;
            phoneNumber = phone;
        }

        public void EmployeeData()
        {
            Console.WriteLine("Company:{0} Name of employee:{1} phoneNumber:{2}", companyName, employeeName, phoneNumber);
        }
    }
}
