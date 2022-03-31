using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public interface IQuittable
    {

        public void Quit()
        {

            Console.WriteLine("I am quiting this job");
            Console.ReadLine();


            
        }
    }
}
