using System;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
       public static void Main(string[] args)
        {    

            theMaking maybe = new theMaking();

            int num1;  // this stores the user input as separate int variable  

            string num2; // this stores the second optional user input as a string to be converted in to
                          // a int if needed later in the program

            Console.WriteLine("Please input a number");
            num1 = Convert.ToInt32( Console.ReadLine()); // since we are storing this number as an int we 
                                                         // we need to convert from a string to an int 
            Console.WriteLine("This second number is optional");
            num2 = Console.ReadLine();

            if (num2 == "")  // this says if num2 variable is null then call method and use the default value   
                            // of num2 
            {

                maybe.Method(num1); // this num1 is uses the converted user input 


            }

            else
            {
                int converted = Convert.ToInt32(num2); // since the user decided to type in a value we 
                                                       // need to convert it into a string so we can call
                                                       // the method and do a math operation on the converted value 

                maybe.Method(num1 = 3, converted = 4);
            }

        }
    }
}
