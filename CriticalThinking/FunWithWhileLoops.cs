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
            Console.WriteLine("Please the number 42.");
            int counter = Convert.ToInt32(Console.ReadLine());

            while (counter != 42)
            {
                Console.WriteLine("Please try again. Please the number 42.");
                counter = Convert.ToInt32(Console.ReadLine());
            }



        }
        
        


    }
}
