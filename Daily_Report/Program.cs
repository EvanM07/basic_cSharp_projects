using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string page_number = Console.ReadLine();
            int pageNum = Convert.ToInt32(page_number);


            Console.WriteLine("Do you need help with anything? Please answer \"true” or \"false\"");
            string help = Console.ReadLine();
            bool value = Convert.ToBoolean(help);
            Console.ReadLine();
            if (true)
            {
                Console.WriteLine("Pleasse tell me more");
            }
            else
            {
                Console.WriteLine("okay let me know if you need any help in the future");
            }
            Console.ReadLine();


            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours_study = Console.ReadLine();
            int Hstudy = Convert.ToInt32(hours_study);

            if (0>=8)
            {
                Console.WriteLine("Good job you can have the rest of the day off");
            }
            else
            {
                Console.WriteLine("Please do some more work");
            }
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
