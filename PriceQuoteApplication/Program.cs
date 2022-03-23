using System;

namespace PriceQuoteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Please tell us the weight of your package");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Have a good day");
                Console.ReadLine();
            }

            else if (weight <= 50)
            {
                Console.WriteLine("Great lets continue the proccess ");
            }

            Console.WriteLine("What is the package width? ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the height? ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the length? ");
            int length = Convert.ToInt32(Console.ReadLine());

            int total = (width + height + length);

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            else if (total <= 50 )
            {
                int moneyTotal = (height + width + length * total / 100);
                Console.WriteLine("Your estimated total for shipping this package is: " + moneyTotal + " dollars");
                Console.ReadLine();
            }
        }
    }
}
