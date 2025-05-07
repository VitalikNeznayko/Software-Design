using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.State
{
    public class HiddenState : IState
    {
        public void Render(LightElementNode elementNode)
        {
            Console.WriteLine($"[Hidden] {elementNode.OuterHTML}");
        }
    }
}