using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.State
{
    public class DisabledState : IState
    {
        public void Render(LightElementNode elementNode)
        {
            Console.WriteLine($"[Disabled] {elementNode.OuterHTML}");
        }
    }
}