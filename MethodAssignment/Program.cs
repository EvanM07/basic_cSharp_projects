using System;

namespace MethodAssignment
{
     public class Program
    {
       public static void Main(string[] args)
        {
            Problem theSolution = new Problem();
            int number1;
            int number2;
            int number3;
            Console.WriteLine("We need three seperate numbers \n");

            Console.WriteLine("Input first number ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input third number");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now we are going to do something with these numbers. Don't ask what tho...");

            Problem.Math1(number1);
            Problem.math2(number2);
            Problem.math3(number3);


        }
    }
}
