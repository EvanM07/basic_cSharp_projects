using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
   static class ex_of_static
    {
       static int a = 2;
       static int b = 2;
       
        static int moreStatic (int a, int b)
        {
            int total = a + b;
            Console.WriteLine("The total is " + total);
            Console.ReadLine();
            return total;
        }
    }
}
