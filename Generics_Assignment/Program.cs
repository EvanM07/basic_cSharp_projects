using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
       public static void Main(string[] args)
        {
             Employee<string> employeeOne = new Employee<string>();
             employeeOne.Things = new List<string>() { "apple", "pear", "orange","cat" };


            Employee<int> employeeTwo = new Employee<int>();
            employeeTwo.Things = new List<int>() { 1, 3, 4, 5 };

            for (var i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("The values for employee one are :" +  employeeOne.Things[i]);

                    Console.WriteLine("The values for employee two are  :" + employeeTwo.Things[i]);

                }
            }

        }
    }
}
