using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class FunWithForLoops
    {
        //member variables
        string result;
        //constructor
        public FunWithForLoops()
        {

        }

        //member methods
        public void ForLoop()
        {
            
            for (int i = 9; i >= 0; i--)
            {
                result += i.ToString() + ",";
                
            }
            string removecomma = result.Remove(result.Length - 1);
            Console.WriteLine(removecomma);
            Console.ReadLine();
            

            
            
        }
    }
}
