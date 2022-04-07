using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in your age");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is " + Age);

            if (Age <= 0) 
            {
            try
            {


            }
            catch (Exception e)
            {
                
                Console.WriteLine("Number can't be under zero!!!!!!!!!!!!!!");



            }
            }


         


        }
    }
}
