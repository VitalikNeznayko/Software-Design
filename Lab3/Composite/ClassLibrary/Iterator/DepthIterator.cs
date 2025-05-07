using System.Text;

namespace ClassLibrary.Iterator
{
    public class DepthIterator : IIterator
    {
        private Stack<LightNode> stack;

        public DepthIterator(LightNode node)
        {
            stack = new Stack<LightNode>();
            stack.Push(node);
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                Console.WriteLine("No more elements");
                return null;
            }

            LightNode node = stack.Pop();
            if (node is LightElementNode elementNode)
            {
                for (int i = elementNode.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.Children[i]);
                }
            }
            return node;
        }
    }
}