using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    abstract class Applications
    {
        //member variables
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        //constructor
        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRAM = 4.0; //In Gigabytes
            RequiredStorage = 0.512; //In Gigabytes
        }
        //member methods


    }
}
