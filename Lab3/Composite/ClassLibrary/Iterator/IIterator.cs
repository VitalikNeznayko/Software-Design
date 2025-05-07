using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
