using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Motherboard
    {
        //member variable
        string Manufacturer;
        CPU processor;
        RAM temporaryMemory;
        HardDrive storage;
        GPU graphics;

        //constructor
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            processor = cpu;
            temporaryMemory = ram;
            storage = hardDrive;
            graphics = gpu;
        }

        //member methods
       
    }
}
