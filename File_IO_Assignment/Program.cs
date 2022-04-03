using System;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input a words or numbers ");

            string userInput = "";

            userInput = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\Laptop\Documents\GitHub\basic_cSharp_projects\File_IO_Assignment\log\log.txt", true))
            {
                file.WriteLine(userInput);
            }


        }
    }
}
