using ClassLibrary.Visitor;
namespace ClassLibrary
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        public abstract void Accept(ILightNodeVisitor visitor);
    }
}
