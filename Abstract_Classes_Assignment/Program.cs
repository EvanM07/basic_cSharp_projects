using System;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            {
                newEmployee.firstName = "Sample";
                newEmployee.lastName = "Student";
                newEmployee.SayName();
            }

        }
    }
}
