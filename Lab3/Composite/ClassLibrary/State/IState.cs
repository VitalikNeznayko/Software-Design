using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.State
{
    public interface IState
    {
        void Render(LightElementNode elementNode);
    }
}
