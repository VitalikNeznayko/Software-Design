using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class IProneTablet : ITablet
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"IProne Tablet створено.");
        }
    }
}
