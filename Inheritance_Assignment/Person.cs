using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
   public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public void sayName()
        {
            firstName = "Evan";
            lastName = "Masters";

            string fullName = firstName + lastName;

            Console.WriteLine("Name: " + fullName);
            Console.ReadLine();
        }
    }
}
