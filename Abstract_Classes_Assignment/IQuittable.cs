using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public interface IQuittable
    {
        public virtual void Quit()
        {
            string answer;

            Console.WriteLine("Does this employee get a raise?");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Thank you for the raise ");
            }
            else
            {
            Console.WriteLine("I quit");
            Console.ReadLine();
            }
        }
    }
}
