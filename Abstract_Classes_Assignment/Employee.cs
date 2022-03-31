using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : IQuittable
    {
        //public override void SayName()
        //{
        //    base.SayName();

        //}

        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            string FirstName = firstName;
            string LastName = lastName;
            string fullName = firstName + lastName;

            Console.WriteLine("The person's full name is " + fullName);
            Console.ReadLine();
        }



    }


}
