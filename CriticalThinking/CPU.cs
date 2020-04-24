using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CPU
    {
        //member variables
        public string Manufacturer;
        public string Name;

        //constructor
        public CPU(string manufacturer, string name)
        {
            Manufacturer = manufacturer;
            Name = name;
        }

        //member methods
        public void CheckRequirements(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (ram.TotalGigabytes > app.RequiredRAM && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                hardDrive.ProcessInstall(app, hardDrive, ram, gpu);
            }
            else
            {
                Console.WriteLine("Does not meet installation requirements");
            }
        }

    }
}
