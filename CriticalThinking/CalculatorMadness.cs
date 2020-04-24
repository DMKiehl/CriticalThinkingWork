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
        public void AddTwoNumbers()
        {
            Console.WriteLine("Please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is: " + result);
        }
            
    }
}
