using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CalculatorMadness
    {
        //member variables

        //constructor

        //member methods
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            //Console.WriteLine("Please enter the first number:");
            //numberOne = Console.ReadLine();

            //Console.WriteLine("Please enter the second number: ");
           // numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            return result;
            //Console.WriteLine("The result of this addition is: " + result);
        }

        public void RunCalculations()
        {
            int result = MultiplyTwoNumbers(40, 35);
            int newResult = DivideTwoNumbers(result, 4);
            int myResult = AddTwoNumbers(6, 5);
            int thisResult = SubtractTwoNumbers(myResult, newResult);
            int finalResult = thisResult + MultiplyTwoNumbers(2, 2);
            Console.WriteLine(finalResult);
            Console.ReadLine();
            
        }

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }
            
    }
}
