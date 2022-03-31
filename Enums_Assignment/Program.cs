using System;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            
             Console.WriteLine("Plese input a day of the week.");                     
             string userInput = Console.ReadLine();
            try
            {
            var day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


        }
    }
}
