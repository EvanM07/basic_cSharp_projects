using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello," + name + "!");
            //Console.Read();
            //Console.WriteLine("\"in the name of the zar\"");
            //Console.Read();

            /// this is simple program                                    To comment out a block of code use crtl + k + c
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            Console.WriteLine("What is yoru favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);                                     
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            //bool isStudying = false;
        }
    }
}
