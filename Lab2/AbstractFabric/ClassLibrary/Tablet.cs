using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Tablet : IDevice
    {
        private readonly string _brand;
        public Tablet(string brand)
        {
            _brand = brand;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{_brand} Tablet створено.");
        }
    }
}
