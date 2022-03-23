using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    class theMaking
    {

        public int Method(int num1, int num2 = 2)
        {
            int answer = num1 * num2;
            Console.WriteLine("Answer is " + answer);
            Console.ReadLine();
            return answer;
        }
    }
}

