using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class HardDrive
    {
        //member variables
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;

        //constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
        }

        //member methods
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        }


    }
}
