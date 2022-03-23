using System;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a number and we'll multiply it by 50");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is " + number1 * 50);


            Console.WriteLine(" Type a number and we'll add 25 to it");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int total = number2 + 25;
            Console.WriteLine("The answer is " + total);

            Console.WriteLine("Type a number and we'll divide it by 12.5");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is " + number3 / 12.5);

            Console.WriteLine("Type a number and we'll see it is greater then 50");
            int number4 = Convert.ToInt32(Console.ReadLine());
            bool check = number4 > 50;
            Console.WriteLine("The answer is " + check);

            Console.WriteLine("Type in a number and we'll divide by 7 and see if there is a remainder");
            int number5 = Convert.ToInt32(Console.ReadLine());
            int remain = number5 % 7;
            Console.WriteLine("The answer is " + remain);
        }
    }
}
