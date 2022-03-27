using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : abstract_class, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
            Employee newEmployee2 = new Employee();
            newEmployee2.firstName = "Sample";
            newEmployee2.lastName = "Employee";
            newEmployee2.SayName();

            Employee newEmployee = new Employee();
            newEmployee.firstName = "Joe";
            newEmployee.lastName = "Shmo";
            newEmployee.SayName();
        }
      

    }

 
}
