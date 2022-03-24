using System;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            {
                newEmployee.firstName = "Sample";
                newEmployee.lastName = "Student";

                newEmployee.sayName();
            }


        }
    }
}
