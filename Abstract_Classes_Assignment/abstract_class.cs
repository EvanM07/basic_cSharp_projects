using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
   public class abstract_class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            string firstName = "Sample";
            string lastName = "Student";
            string fullName = firstName + lastName;

            Console.WriteLine("The person's full name is " + fullName);
            Console.ReadLine();
        }
    }
}
