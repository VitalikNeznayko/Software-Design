using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class IProneSmartphone : ISmartphone
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"IProne Smartphone створено.");
        }
    }
}
