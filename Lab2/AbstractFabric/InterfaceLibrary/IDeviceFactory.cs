using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        ITablet CreateTablet();
        ISmartphone CreateSmartphone();
    }
}
