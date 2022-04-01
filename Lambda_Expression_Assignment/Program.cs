using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
   public class Program
    {
        public static void Main(string[] args)
        {
            //List<Employee> employeeJoe = new List<Employee>();
            List<Employee> Employees = new List<Employee>();
            List<Employee> employeesFull = new List<Employee>();
            List<string> firstnames = new List<string>(10)
            {
                "Bob", "Jeff", "Dale", "Kate", "Ann",
                "Joe", "Joe", "Bobby", "Nick", "Gage"

            };
            //foreach (string x in firstnames)
            //{
            //    Console.WriteLine(firstnames);
            //}

            List<string> lastnames = new List<string>()
            {
                "Jackson", "Smith", "Miller", "Turner", "Johnson",
                "Myles", "Jones", "Bones", "Kelper", "Davis"
            };

            List<int> IDs = new List<int>()
            {
                32, 45, 63, 20, 40,
                69, 21, 80, 25, 11,

            };
            for (int i = 0; i < firstnames.Count; i++)
            {
                employeesFull.Add(new Employee(firstnames[i], lastnames[i], IDs[i]));
            }

            

            //Console.WriteLine("The first names are " + firstnames);
            //foreach (var v in firstnames)
            ////{
            ////    if (v == "Joe")
            ////        //  employeeJoe.ToArray();
            ////    Console.WriteLine(employeeJoe);
            ////}



            //List<Employee> employeeJoe = firstnames.FindAll(x => x == "Joe").ToList();

            firstnames.Where(x => x == "Joe");


             IDs.Where(x => x > 5);

            Console.WriteLine(IDs);




        }
    }
}
