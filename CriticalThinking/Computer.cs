using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Computer
    {

        public void BuildComputer()
        {
            GPU gpu = new GPU("Dell", 512);
            CPU cpu = new CPU("Dell", "Name");
            HardDrive hardDrive = new HardDrive(1000.0, 950.0);
            RAM ram = new RAM(512, "Dell");
            Motherboard motherboard = new Motherboard("Dell", ram, cpu, hardDrive, gpu);
        }


    }
}
