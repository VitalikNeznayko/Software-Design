using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public ITablet CreateTablet()
        {
            return new KiaomiTablet();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
