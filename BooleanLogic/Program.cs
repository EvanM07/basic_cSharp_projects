using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.ReadLine();

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);
            Console.ReadLine();


            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);
            Console.ReadLine();

            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);
            Console.ReadLine();

            //these are the x or operators in c sharp
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();


        }
    }
}
