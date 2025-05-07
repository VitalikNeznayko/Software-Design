using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Iterator
{
    public class BreadthIterator : IIterator
    {
        private Queue<LightNode> queue;

        public BreadthIterator(LightNode node)
        {
            queue = new Queue<LightNode>();
            queue.Enqueue(node);
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                Console.WriteLine("No more elements");
            }

            LightNode node = queue.Dequeue();
            if (node is LightElementNode elementNode)
            {
                foreach (LightNode lightNode in elementNode.Children)
                {
                    {
                        queue.Enqueue(lightNode);

                    }
                }
            }
            return node;
        }
    }
}