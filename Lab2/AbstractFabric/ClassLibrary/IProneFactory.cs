using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public ITablet CreateTablet()
        {
            return new IProneTablet();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}
