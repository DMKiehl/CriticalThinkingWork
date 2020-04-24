using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class TextEditor : Applications
    {
        //member variables

        //constructor
        public TextEditor(string applicationName, string applicationType, double requiredRAM, double requiredStorage)
        {
            ApplicationName = applicationName;
            ApplicationType = applicationType;
            RequiredRAM = requiredRAM; //In Gigabytes
            RequiredStorage = requiredStorage; //In Gigabytes
        }

        //member methods
    }
}
