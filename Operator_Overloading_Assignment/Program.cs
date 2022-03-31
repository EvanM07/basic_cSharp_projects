using System;

namespace Operator_Overloading_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //    employee employee1 = new employee();
            //    employee1.firstName = "David";

            //    employee employee2 = new employee();
            //    employee2.firstName = "Jack";

            //    public employee operator ==(string fistName, string lastName)
            //{
            //    if (employee1.firstName == employee2.firstName)
            //        Console.WriteLine("these are the same ");

            //}
            //else 
            //{
            //Console.WriteLine("these are not the same ");
            //}

                Employee employee1 = new Employee();
            employee1.firstName = "david ";

            Employee employee2 = new Employee();
            employee2.firstName = "nathan";

            employee1.ID = 1;
            employee2.ID = 2;

            Console.WriteLine("The two employee ID's match true or false");

            Console.WriteLine(employee1.ID == employee2.ID);

            Console.ReadLine();

        }

    }

}




