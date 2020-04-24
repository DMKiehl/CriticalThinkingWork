using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Games : Applications
    {
        //member variables
        public double RequiredEffectiveMemory;

        //constructor
        public Games(string applicationName, string applicationType, double requiredRAM, double requiredStorage, double requiredEffectiveMemory)
        {
            ApplicationName = applicationName;
            ApplicationType = applicationType;
            RequiredRAM = requiredRAM; //In Gigabytes
            RequiredStorage = requiredStorage; //In Gigabytes
            RequiredEffectiveMemory = requiredEffectiveMemory;
        }
        
        //member methods

    }
}
