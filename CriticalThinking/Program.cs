﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithForLoops loops = new FunWithForLoops();
            loops.ForLoop();
            loops.UserForLoop();

            //FunWithWhileLoops whileloops = new FunWithWhileLoops();
            //whileloops.WhileLoop();

            Console.WriteLine("Please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            CalculatorMadness calculator = new CalculatorMadness();
            calculator.AddTwoNumbers(numberOne, numberTwo);

        }
    }
}
