using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public class newClass
    {
        public void methodOne(int userInput, int num2 = 2)
        {
            int theAnswer = userInput * num2;

            Console.WriteLine("The answer is " + theAnswer);
            Console.ReadLine();
        }

        public void  outPut(int I)
        {
            int temp = 5;
            I = temp;
        }




    }
}
