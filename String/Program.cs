using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = " Battfield 2042 ";
            string b = " was a ";
            string c = " dissapointment ";
            Console.WriteLine(a + b + c);


            string d = "lowercase";
            d = d.ToUpper();
            Console.WriteLine(d);
            Console.ReadLine();

            StringBuilder e = new StringBuilder();

            e.Append("\t Hello world, let's see what is going on today. ");
            e.Append(" Sees like nothing going on out there, but it does look like we are going to get rian. ");
            e.Append("We haven't gotten any rain for quite sometime now. So I am looking forward to it.");
            e.Append("I just hope that it won't wash my gravel driveway again. ");

            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
