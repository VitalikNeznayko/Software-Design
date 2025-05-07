namespace ClassLibrary.Visitor
{
    public class HtmlPrinterVisitor : ILightNodeVisitor
    {
        public void VisitTextNode(LightTextNode textNode)
        {
            Console.WriteLine($"Текст: {textNode.InnerHTML}");
        }

        public void VisitElementNode(LightElementNode elementNode)
        {
            Console.WriteLine($"Елемент: <{elementNode.TagName}> з класами: {string.Join(", ", elementNode.CssClasses)}");
            foreach (var child in elementNode.Children)
            {
                child.Accept(this);
            }
        }
    }
}
