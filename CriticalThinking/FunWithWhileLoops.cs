using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class FunWithWhileLoops
    {
        
        //member variables

        //constructer

        //member methods
        public void WhileLoop()
        {
            //int counter = 5;
            Console.WriteLine("Please enter a number.");
            int counter = Convert.ToInt32(Console.ReadLine());
            if (counter < 0)
            {
                Console.WriteLine("Please enter a positive number.");
            }
            else
            {
                while (counter < 25)
                {
                    counter++;
                }
            }            

        }
        
        


    }
}
