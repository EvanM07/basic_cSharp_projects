using System;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please write a line");

            Console.WriteLine("Please input a number from 1 to 12");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The time will be " + DateTime.Now.AddHours(userInput));



        }
    }
}
