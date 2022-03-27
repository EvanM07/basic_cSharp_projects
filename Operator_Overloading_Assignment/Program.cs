using System;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            employee employee1 = new employee();
            employee1.firstName = "David";

            employee employee2 = new employee();
            employee2.firstName = "Jack";

            public static employee operator ==(employee employee1, employee employee2)
        {
            if (employee1.firstName == employee2.firstName)
                Console.WriteLine("these are the same ");

        }
        else 
        {
        Console.WriteLine("these are not the same ");
        }



    }



    }
}

