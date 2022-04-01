using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    public class Employee
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }
        public Employee(string _firstName, string _lastName, int _ID)
        {
            firstName = firstName;
            lastName = lastName;
            ID = _ID;
        }

    }
}
