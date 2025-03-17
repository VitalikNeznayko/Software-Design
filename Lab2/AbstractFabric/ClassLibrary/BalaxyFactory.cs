using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BalaxyFactory : IBrandFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("IProne");
        }
        public IDevice CreateTablet()
        {
            return new Tablet("IProne");
        }
        public IDevice CreateSmartphone()
        {
            return new Smartphone("IProne");
        }
    }
}
