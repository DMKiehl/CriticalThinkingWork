﻿using System;
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
            AddTwoNumbers(5, 7);
        }
            
    }
}
