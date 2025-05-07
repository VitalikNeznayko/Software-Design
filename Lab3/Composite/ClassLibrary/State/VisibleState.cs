using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.State
{
    public class VisibleState : IState
    {
        public void Render(LightElementNode elementNode)
        {
            Console.WriteLine($"[Visible] {elementNode.OuterHTML}");
        }
    }
}