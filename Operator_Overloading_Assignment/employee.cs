using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName  { get; set; }

        public int ID { get; set; }



        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID) {
                Console.WriteLine("The ID's are equal");

        }
            return true;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                Console.WriteLine("The ID's are equal ");
            }
            return false;
        }
    }
}
