using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    public class Class1
    {
        public int num01;
        public int num02;
        public float num03;
        public float num04;
        //public string num05;
        public int num05;
        public int num06;

        public int methodOne()
        {
            int answer = num01 * num02;

            Console.WriteLine("The answer is " + answer);
            return answer;
        }

        public int methodTwo()
        {
             //int numhalf = 3;
            int answerTwo = Convert.ToInt32( num03 + num04 );

            Console.WriteLine("The answer is " + answerTwo);
            return answerTwo;
            
        }

        public  int methodThree()
        {
            //string  converted = Convert.ToString(num05);
            //int answerThree = Convert.ToInt32(num05 - num06);

            int answerThree = num05 / num06;
            Console.WriteLine("The answer is " + answerThree);

            return answerThree;
        }
        


    }
}
