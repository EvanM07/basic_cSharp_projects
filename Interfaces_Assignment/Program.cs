using System;

namespace Interfaces_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            Employee employeeOne = new Employee();
            //string FirstName = "David";
            //string LastName = "Lossy";

            employeeOne.FirstName = "David ";
            employeeOne.LastName = "Lossy ";

            string FullName = employeeOne.FirstName + employeeOne.LastName;
            Console.WriteLine(FullName) ;
            Console.ReadLine();

            IQuittable employeeTwo = new Employee();

            employeeTwo.Quit();


        }
    }
}
