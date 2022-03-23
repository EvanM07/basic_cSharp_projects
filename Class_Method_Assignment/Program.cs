using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Class_Method_Assignment

{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput;
            Console.WriteLine("Please input a number ");
            userInput = Convert.ToInt32(Console.Read());

            int overload;
            Console.WriteLine("Please input a number");
            overload = Convert.ToInt32(Console.ReadLine());

            newClass theClass = new newClass();
            {
                theClass.methodOne(userInput);

                theClass.methodOne(overload);

                int b = 30;
                theClass.outPut(b);

                Console.WriteLine("The output is " + b);
                Console.ReadLine();
            }
        }
    }
}
