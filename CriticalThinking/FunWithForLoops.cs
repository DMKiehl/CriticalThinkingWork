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
        string userResult;
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
            //Console.ReadLine();    
            
        }

        public void UserForLoop()
        {
            Console.WriteLine("How many times would you like the loop to run?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < userInput; i++)
            {
                userResult += i.ToString() + ",";
            }

            string removecomma1 = userResult.Remove(userResult.Length - 1);
            Console.WriteLine(removecomma1);
            Console.ReadLine();
        }
    }
}
