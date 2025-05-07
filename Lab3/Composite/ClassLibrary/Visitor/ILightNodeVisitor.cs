namespace ClassLibrary.Visitor
{
    public interface ILightNodeVisitor
    {
        void VisitTextNode(LightTextNode textNode);
        void VisitElementNode(LightElementNode elementNode);
    }
}
