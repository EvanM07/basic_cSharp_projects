using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 4, 10, 60, 50, 30 };
            Console.WriteLine("Type in a number ");
            int input = Convert.ToInt32(Console.ReadLine());

            try
            {
            foreach (int number in numberList)
            {
                int total = number / input;
                Console.WriteLine(number + " Divided by " + input + " equals " + total );
            }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by 0, it hurts my brain :( ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use only numbers not going to ask again !");
            }

            catch (NotFiniteNumberException)
            {
                Console.WriteLine("This is not a number ");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("We are out of the try catch block.");

            Console.WriteLine("thank you for trying this program ");
            Console.ReadLine();





        }
    }
}
