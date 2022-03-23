using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see if you qulify car insurance.");

            Console.WriteLine("What is your age?");
            int age = 15;
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string dui = "false";
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = 3;
            Console.ReadLine();

            bool qualify = (age >= 15 && dui == "false" && speeding >= 3);

            Console.WriteLine("The answer is \n " + qualify);

        }
    }
}
