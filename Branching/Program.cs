﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 12 ? "You have an awsome favorite number" : " You do not have a awsome number.";


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature wher you are? ");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature )
            //{
            //    Console.WriteLine("It is exacly rooom temperature.");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}

            //else if ( roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine(" it is colder than room temperature");
            //}

            //else
            //{
            //    Console.WriteLine("Uhhhhh.... something went wrong.");

            //}

            //Console.ReadLine();

            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //the ternary operator 
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine(" it is warmer than room temperature");
            //}

            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder then room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            //Console.ReadLine();



        }
    }
}
