using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Problem
    {
        public static int Math1(int number1)
        {
            int answer1 = number1 * 2;
            Console.WriteLine("The answer is " + answer1);
            Console.ReadLine();
            return answer1;
        }

        public static int math2(int number2)
        {
            int answer2 = number2 - 20;
            Console.WriteLine("The answer is " + answer2);
            Console.ReadLine();
            return answer2;
        }
        public static int math3(int numer3)
        {
            int answer3 = numer3 + 100;
            Console.WriteLine("The answer is " + answer3);
            Console.ReadLine();
            return answer3;
        }

    }
}
