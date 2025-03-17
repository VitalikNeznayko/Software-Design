using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Smartphone : IDevice
    {
        private readonly string _brand;
        public Smartphone(string brand)
        {
            _brand = brand;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{_brand} Smartphone створено.");
        }
    }
}
