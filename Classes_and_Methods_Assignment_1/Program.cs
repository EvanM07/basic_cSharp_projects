using System;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 Classes = new Class1();
            {
                Classes.num01 = 2;
                Classes.num02 = 2;
                Classes.num03 = 2.55f;
                Classes.num04 = 3.39f;
                Classes.num05 = 100;
                Classes.num06 = 2;

                Classes.methodOne();
                Classes.methodTwo();
                Classes.methodThree();

                Console.WriteLine("the end ");
                Console.ReadLine();
            }



        }
    }
}

