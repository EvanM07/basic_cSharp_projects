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
        public static void Main(string[] args)
        {


                List<int> numbers = new List<int>();
                numbers.AddRange(Enumerable.Range(0, 100));

                foreach (int number in numbers)
                    Console.WriteLine(number);

                Console.WriteLine("Please type in your age");
                int Age = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            
                if (Age != i )
                {
                    throw new ArgumentOutOfRangeException("Sorry can't be a negative number or over the range " +
                                                          "  of numbers listed " );

                }


                else
                {
                    Console.WriteLine("Your age is " + Age, numbers);

                }


















        }
    }
}






















//List<int> numbers = new List<int>();
//numbers.AddRange(Enumerable.Range(0, 100));

//foreach (int number in numbers)
//    Console.WriteLine(number);

//Console.WriteLine("Please type in your age");
//int Age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Your age is " + Age, numbers);

//for (int i = 0; i < numbers.Count; i++)
//
//    if (Age < i) ;


//