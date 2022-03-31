using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit this job");
            Console.ReadLine();

        }
    }
}
