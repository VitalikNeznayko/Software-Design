using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BalaxyFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }

        public ITablet CreateTablet()
        {
            return new BalaxyTablet();
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
}
