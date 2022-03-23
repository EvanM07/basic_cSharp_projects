using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    public class classQ
    {

        public void methodVoid(int a = 3, int b = 4)
        {
            int math1 = a * 40;
            Console.WriteLine(math1);
            Console.WriteLine(b);
        }
        
        public void methodnamed(int apple, int berry)
        {
            if (apple < berry)
            {
                Console.WriteLine("this aint it cheif");

            }
            else
            {
                Console.WriteLine("yes this is it ");
            }
        }

    }
}
