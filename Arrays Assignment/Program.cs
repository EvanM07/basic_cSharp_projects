using System;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {
            //string[] words = { "this", "computer", "is", "a", "computer" };

            //Console.WriteLine("Please select a index in the array");

            //int answer = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(words[answer]);



            int[] numberArray = { 10, 30, 209, 49, 30 };

            Console.WriteLine("select an index in the 4 index array");

            int input = Convert.ToInt32(Console.ReadLine());

            foreach (int numer in numberArray)
            {

                if (input < numberArray.Length)
                {
                    Console.WriteLine(input);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("that index does not exist. ");
                    Console.ReadLine();
                }

            }
        }
    }
}
