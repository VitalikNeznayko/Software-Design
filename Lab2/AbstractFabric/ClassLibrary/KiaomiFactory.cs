using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class KiaomiFactory : IBrandFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Kiaomi");
        }
        public IDevice CreateTablet()
        {
            return new Tablet("Kiaomi");
        }
        public IDevice CreateSmartphone()
        {
            return new Smartphone("Kiaomi");
        }
    }
}
